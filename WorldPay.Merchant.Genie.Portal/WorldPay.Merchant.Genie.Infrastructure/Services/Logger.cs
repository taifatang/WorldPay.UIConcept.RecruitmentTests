using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldPay.Merchant.Genie.Infrastructure.Models.Systems;

namespace WorldPay.Merchant.Genie.Infrastructure.Services
{
    public class TraceLogger : ILogger
    {
        public void Write(EventType eventType, string text)
        {
            Trace.Write(text);
        }
    }
}
