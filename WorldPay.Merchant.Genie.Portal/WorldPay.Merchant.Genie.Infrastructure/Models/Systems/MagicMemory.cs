using System.Collections.Generic;
using WorldPay.Merchant.Genie.Infrastructure.Storage;

namespace WorldPay.Merchant.Genie.Infrastructure.Models.Systems
{
    public class MagicMemory
    {
        public static Dictionary<string, GenieUser> GetAllUsers()
        {
            return new Dictionary<string, GenieUser>()
            {
                {"1", new GenieUser()
                    {
                        Id = "001",
                        Name = "Tai Fa Tang",
                        Accounts = new List<Account>
                        {
                            new Account
                            {
                                BankName = "Barclays",
                                AccountType = AccountType.Saving,
                                AccountNumber = 10001001,
                                SortCode = 101011
                            },
                            new Account
                            {
                                BankName = "HSBC",
                                AccountType = AccountType.Saving,
                                AccountNumber = 20002002,
                                SortCode = 202022
                            },
                            new Account
                            {
                                BankName = "NationWide",
                                AccountType = AccountType.Bills,
                                AccountNumber = 30003003,
                                SortCode = 303033
                            },
                            new Account
                            {
                                BankName = "Santander",
                                AccountType = AccountType.Goal,
                                AccountNumber = 40004004,
                                SortCode = 404044
                            }
                        }
                    }
                }
            };
        }
    }
}