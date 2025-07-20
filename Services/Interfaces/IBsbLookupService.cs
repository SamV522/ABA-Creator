using Creator.ABA.Models.BsbLookup;
using System.Threading.Tasks;

namespace Creator.ABA.Services.Interfaces
{
    public interface IBsbLookupService
    {
        public Task<BsbLookupResult[]> LookupAsync(BsbLookupRequest request);
    }
}
