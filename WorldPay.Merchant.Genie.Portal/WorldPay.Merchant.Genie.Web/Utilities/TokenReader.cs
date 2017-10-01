using System;
using WorldPay.Merchant.Genie.Infrastructure.Services;

namespace WorldPay.Merchant.Genie.Web.Utilities
{
    public class TokenReader
    {
        private readonly Token _token;
        public TokenReader(Token token)
        {
            _token = token;
        }
        public string Read(string claim)
        {
            if (claim == "userId")
            {
                return "1";
            }
            throw new InvalidOperationException("prototype only support user id claim");
        }
    }
}
