using System.Threading.Tasks;

namespace Creator.ABA.Helpers.Interfaces
{
    public interface IBsbValidationHelper
    {
        public Task<BsbValidationResult> IsValidBsb(string bsb);
    }
}
