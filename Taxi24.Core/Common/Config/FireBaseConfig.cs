using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Common.Config
{
    public class FireBaseConfig
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Sender { get; set; }
        public string SmsUrl { get; set; }
        public string FirebaseUrl { get; set; }
        public string ServerId { get; set; }
        public string SenderId { get; set; }
    }
}
