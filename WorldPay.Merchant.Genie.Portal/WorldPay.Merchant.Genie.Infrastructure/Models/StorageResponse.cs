using System.Collections.Generic;
using WorldPay.Merchant.Genie.Infrastructure.Models.Systems;

namespace WorldPay.Merchant.Genie.Infrastructure.Models
{
    public class StorageResponse
    {
        public bool Success => Errors == null || Errors.Count == 0;
        public List<Error> Errors { get; set; }

    }
    public class StorageResponse<T> : StorageResponse
    {
        public T Data { get; set; }
    }
}