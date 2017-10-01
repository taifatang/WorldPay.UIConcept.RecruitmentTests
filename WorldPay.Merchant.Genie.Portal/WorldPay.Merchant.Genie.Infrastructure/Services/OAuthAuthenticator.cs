using System;
using System.Threading.Tasks;
using WorldPay.Merchant.Genie.Infrastructure.Models.Systems;

namespace WorldPay.Merchant.Genie.Infrastructure.Services
{
    public class OAuthAuthenticator : IAuthentication
    {
        public async Task<Token> Authorize(Credentials userCredentials)
        {
            if (userCredentials.Secret == MagicMemory.NonSecuredSecret)
            {
                return await Task.FromResult(new Token
                {
                    AccessToken = "access_token",
                    IdToken = "id_token"
                });
            }
            throw new UnauthorizedAccessException($"{userCredentials.Secret} is has not been granted access");
        }

        public bool Verfiy(Token token)
        {
            return token.AccessToken == "access_token";
        }
    }
}