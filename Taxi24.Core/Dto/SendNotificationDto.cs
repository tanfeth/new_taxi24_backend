using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Dto.Admin
{
    public class SendNotificationDto
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public List<string> DeviceToken { get; set; }
    }
}
