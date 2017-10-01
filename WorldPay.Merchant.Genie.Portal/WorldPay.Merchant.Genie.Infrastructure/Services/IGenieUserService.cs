using System.Threading.Tasks;
using WorldPay.Merchant.Genie.Infrastructure.Storage;

namespace WorldPay.Merchant.Genie.Infrastructure.Services
{
    public interface IGenieUserService
    {
        Task<GenieUser> GetAsync(string id);
    }
}