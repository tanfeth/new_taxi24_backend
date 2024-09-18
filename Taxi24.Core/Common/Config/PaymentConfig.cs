using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Common.Config
{
    public class PaymentConfig
    {
        public string Url { get; set; }
        public string TerminalId { get; set; }
        public string Password { get; set; }
        public string Currency { get; set; }
        public string Country { get; set; }
        public string MerchantIp { get; set; }
        public string Customerip { get; set; }
        public string Key { get; set; }
    }
}
