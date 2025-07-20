using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace Creator.ABA.Models.BsbLookup
{
    public class BsbLookupRequest
    {
        [Required, StringLength(7, MinimumLength = 7), RegexStringValidator(@"\d{3}-\d{3})")]
        public string bsbcode { get; set; }
    }
}
