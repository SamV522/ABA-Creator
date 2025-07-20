using Creator.ABA.Helpers.Interfaces;
using Creator.ABA.Models.BsbLookup;
using Creator.ABA.Services.Interfaces;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace Creator.ABA.Services
{
    public class BsbLookupService : IBsbLookupService
    {
        private readonly HttpClient _httpClient;
        private readonly IAusPayNetHelper _ausPayNetHelper;

        public BsbLookupService(IHttpClientFactory httpClientFactory, IAusPayNetHelper ausPayNetHelper)
        {
            _httpClient = httpClientFactory.CreateClient("BsbLookup");
            _ausPayNetHelper = ausPayNetHelper;
        }

        public async Task<BsbLookupResult[]> LookupAsync(BsbLookupRequest request)
        {
            var apiKey = await _ausPayNetHelper.GetSubscriptionKey();
            
            _httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);

            var response = await _httpClient.PostAsJsonAsync("invoke", request);

            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadFromJsonAsync<BsbLookupResponse>();

            var results = JsonSerializer.Deserialize<BsbLookupResult[]>(result.data, options: new JsonSerializerOptions() { PropertyNameCaseInsensitive = true});

            return results;
        }
    }
}
