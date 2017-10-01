using System.Threading.Tasks;

namespace WorldPay.Merchant.Genie.Infrastructure.Services
{
    public interface IAuthentication
    {
        Task<Token> Authorize(Credentials credentials);
        bool Verfiy(Token token);
    }
}
