using System;

namespace Creator.ABA.Models.BsbLookup
{
    public class BsbLookupResult
    {
        public string BSBCode { get; set; }
        public string BSBName { get; set; }
        public string FiMnemonic { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public string StreamCode { get; set; }
        public DateTime lastmodified { get; set; }
        public string BIC { get; set; }
        public string BICInt { get; set; }
        public string repair { get; set; }
        public string FIName { get; set; }
    }
}
