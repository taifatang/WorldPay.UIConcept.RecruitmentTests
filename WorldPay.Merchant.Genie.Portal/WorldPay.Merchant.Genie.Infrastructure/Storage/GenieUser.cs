using System.Collections.Generic;
using WorldPay.Merchant.Genie.Infrastructure.Models;

namespace WorldPay.Merchant.Genie.Infrastructure.Storage
{
    public class GenieUser
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<Account> Accounts { get; set; }
    }
}