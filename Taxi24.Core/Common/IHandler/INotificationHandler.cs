using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi24.Core.Common.Enum;
using Taxi24.Core.Dto;
//using Taxi24.Core.Dto.Admin;
using Taxi24.Core.Entity;

namespace Taxi24.Core.Common.Handler
{
    public interface INotificationHandler
    {
        Task<bool> SendSMSAsync(NotificationDto notifi);
        //Task SendNotification(NotificationOrderDto notifi);
        //Task SendNotifications(SendNotificationDto notifi);
        Task<bool> SendNotificationAsync(List<string> tokens, NotificationMessages notificationMessage, dynamic obj = null
            , LanguageEnum? lang = LanguageEnum.Arabic);
    }
}
