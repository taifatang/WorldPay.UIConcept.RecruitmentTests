using System.Net.NetworkInformation;
using System.Threading.Tasks;
using WorldPay.Merchant.Genie.Infrastructure.Exceptions;
using WorldPay.Merchant.Genie.Infrastructure.Models.Systems;
using WorldPay.Merchant.Genie.Infrastructure.Storage;

namespace WorldPay.Merchant.Genie.Infrastructure.Services
{
    public class AccountService
    {
        private readonly IAccountStorage _accountStorage;
        private readonly ILogger _logger;

        public AccountService(IAccountStorage accountStorage, ILogger logger)
        {
            _accountStorage = accountStorage;
            _logger = logger;
        }

        public async Task<GenieUser> GetAsync(string id)
        {
            var response = await _accountStorage.GetAsync(id);

            if (!response.Success)
            {
                _logger.Write(EventType.Error, $"{id} failed to retrieve data");
                _logger.Write(EventType.Error, $"{response}");
                throw new AccountStorageRequestFailedException($"{id} failed to retrieve data");
            }
            return response.Data;
        }
    }
}
