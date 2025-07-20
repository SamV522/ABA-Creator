namespace Creator.ABA.Models.Configuration
{
    public class AppSettings
    {
        public class ApiEndpoints
        {
            public string AusPayNet { get; set; }
            public string BsbLookup { get; set; }
        }

        public string AusPayNetSubscriptionKey { get; set; }
    }
}
