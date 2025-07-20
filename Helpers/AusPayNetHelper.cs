using Creator.ABA.Helpers.Interfaces;
using Creator.ABA.Models.Configuration;
using Creator.ABA.Services.Interfaces;
using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Creator.ABA.Helpers
{
    public class AusPayNetHelper : IAusPayNetHelper
    {
        private readonly HttpClient _httpClient;
        private readonly ISettingsProvider<AppSettings> _appSettingsProvider;

        public AusPayNetHelper(IHttpClientFactory httpClientFactory, ISettingsProvider<AppSettings> appSettingsProvider)
        {
            _httpClient = httpClientFactory.CreateClient("AusPayNet");
            _appSettingsProvider = appSettingsProvider;
        }


        public async Task<string> GetSubscriptionKey()
        {
            // Check the AppSettings for the subscription key
            var _apiKey = _appSettingsProvider.Settings.AusPayNetSubscriptionKey;

            // If it exists, return it
            if (!string.IsNullOrEmpty(_apiKey))
            {
                // This is a work around to avoid the need to fetch the key from the website
                return _apiKey;
            }

            // If it does not exist, fetch it from the AusPayNet website
            // Fetch the script.js file from the AusPayNet website
            // https://auspaynet.com.au/bsbquery/script.js
            var response = await _httpClient.GetAsync("script.js");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            var match = Regex.Match(content,@"const\s+subscriptionKey\s*=\s*'([\dA-z]{32})'");

            if (match.Success && match.Groups.Count > 1)
            {
                return match.Groups[1].Value;
            }

            throw new InvalidOperationException("Subscription key not found in script.js");
        }
    }
}
