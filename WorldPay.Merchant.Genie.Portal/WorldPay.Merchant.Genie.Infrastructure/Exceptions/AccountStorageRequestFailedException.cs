using System;
using System.Runtime.Serialization;

namespace WorldPay.Merchant.Genie.Infrastructure.Exceptions
{
    [Serializable]
    public class AccountStorageRequestFailedException : Exception
    {
        public AccountStorageRequestFailedException()
        {
        }

        public AccountStorageRequestFailedException(string message) : base(message)
        {
        }

        public AccountStorageRequestFailedException(string message, Exception inner) : base(message, inner)
        {
        }

        protected AccountStorageRequestFailedException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}