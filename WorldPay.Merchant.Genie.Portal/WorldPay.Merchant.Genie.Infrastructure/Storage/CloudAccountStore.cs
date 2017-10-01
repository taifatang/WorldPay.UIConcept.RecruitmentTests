using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using WorldPay.Merchant.Genie.Infrastructure.Models;
using WorldPay.Merchant.Genie.Infrastructure.Models.Systems;

namespace WorldPay.Merchant.Genie.Infrastructure.Storage
{
    public class CloudAccountStore : IAccountStorage
    {
        private readonly Dictionary<string, GenieUser> _inMemoryUser;

        public CloudAccountStore()
        {
            _inMemoryUser = MagicMemory.GetAllUsers();
        }
        public async Task<StorageResponse<GenieUser>> GetAsync(string id)
        {
            return await Task.FromResult(new StorageResponse<GenieUser>
            {
                Data = _inMemoryUser[id]
            });
        }

        public Task<StorageResponse> UpdateAsync(string id, Account account)
        {
            throw new NotImplementedException();
        }

        public Task<StorageResponse> AddAsync(string id, Account account)
        {
            throw new NotImplementedException();
        }
    }
}
