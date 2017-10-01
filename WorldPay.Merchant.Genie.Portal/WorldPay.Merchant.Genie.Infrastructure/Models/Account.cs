namespace WorldPay.Merchant.Genie.Infrastructure.Models
{
    public class Account
    {
        public string BankName { get; set; }
        public int SortCode { get; set; }
        public int AccountNumber { get; set; }
        public AccountType AccountType { get; set; }
    }
}
