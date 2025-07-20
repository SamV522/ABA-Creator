using System;

namespace Creator.ABA.Models.BsbLookup
{
    internal class BsbLookupResponse
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public DateTime TimeStamp { get; set; }
        public string data { get; set; } // JSON string representation of the BSB data
    }
}
