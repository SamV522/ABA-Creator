using Creator.ABA.Helpers.Interfaces;
using Creator.ABA.Models.BsbLookup;
using Creator.ABA.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Creator.ABA.Helpers
{
    public enum BsbValidationResultType
    {
        UnableToValidate,
        InvalidFormat,
        NoMatch,
        SingleMatch,
        MultipleMatches
    }

    public class BsbValidationResult
    {
        public string Bsb { get; set; }
        public BsbValidationResultType ResultType { get; set; }
        public IReadOnlyList<BsbLookupResult> Matches { get; set; } = Array.Empty<BsbLookupResult>();
    }


    internal class BsbValidationHelper : IBsbValidationHelper
    {
        private readonly IBsbLookupService _bsbLookupService;

        public BsbValidationHelper(IBsbLookupService bsbLookupService)
        {
            _bsbLookupService = bsbLookupService;
        }

        public async Task<BsbValidationResult> IsValidBsb(string bsb)
        {
            var regex = @"[0-9]{3}-[0-9]{3}";

            var match = Regex.Match(bsb, regex);

            if (!match.Success)
            {
                return new BsbValidationResult
                {
                    Bsb = bsb,
                    ResultType = BsbValidationResultType.InvalidFormat
                };
            }

            try
            {
                // Check it against AusPayNetwork
                var results = await _bsbLookupService.LookupAsync(new BsbLookupRequest() { bsbcode = bsb });

                if (results == null || !results.Any())
                {
                    return new BsbValidationResult
                    {
                        Bsb = bsb,
                        ResultType = BsbValidationResultType.NoMatch
                    };
                }
                else
                {
                    if (results.Length > 1)
                    {
                        return new BsbValidationResult
                        {
                            Bsb = bsb,
                            ResultType = BsbValidationResultType.MultipleMatches,
                            Matches = results.ToList()
                        };
                    }
                    else
                    {
                        return new BsbValidationResult
                        {
                            Bsb = bsb,
                            ResultType = BsbValidationResultType.SingleMatch,
                            Matches = results.ToList()
                        };
                    }
                }
            } catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return new BsbValidationResult
            {
                Bsb = bsb,
                ResultType = BsbValidationResultType.UnableToValidate
            };
        }
    }
}
