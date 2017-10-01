using WorldPay.Merchant.Genie.Infrastructure.Models.Systems;

namespace WorldPay.Merchant.Genie.Infrastructure.Services
{
    public interface ILogger
    {
        void Write(EventType eventType, string text);
    }
}