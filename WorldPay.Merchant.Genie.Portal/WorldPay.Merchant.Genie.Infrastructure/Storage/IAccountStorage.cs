using System.Threading.Tasks;
using WorldPay.Merchant.Genie.Infrastructure.Models;

namespace WorldPay.Merchant.Genie.Infrastructure.Storage
{
    public interface IAccountStorage
    {
        Task<StorageResponse<GenieUser>> GetAsync(string id);
        Task<StorageResponse> UpdateAsync(string id, Account account);
        Task<StorageResponse> AddAsync(string id, Account account);
    }
}