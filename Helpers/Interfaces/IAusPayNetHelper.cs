using System.Threading.Tasks;

namespace Creator.ABA.Helpers.Interfaces
{
    public interface IAusPayNetHelper
    {
        /// <summary>
        /// Retrieves the subscription key from the AusPayNet script.js page.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation, containing the subscription key.</returns>
        Task<string> GetSubscriptionKey();
    }
}
