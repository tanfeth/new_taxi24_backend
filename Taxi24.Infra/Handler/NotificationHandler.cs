using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using Taxi24.Core.Common.Config;
using Taxi24.Core.Common.Enum;
using Taxi24.Core.Common.Handler;
using Taxi24.Core.Common.IHelper;
using Taxi24.Core.Common.Utlities;
using Taxi24.Core.Dto;
using Taxi24.Core.Dto.Admin;
using Taxi24.Core.Entity;

namespace Taxi24.Infra.Handler
{
    public class NotificationHandler : INotificationHandler
    {
        private FireBaseConfig fireBaseConfig;
        private readonly IApiHelper apiHelper;
        private readonly IConfiguration configuration;
        public NotificationHandler(IOptions<FireBaseConfig> fireBaseConfig, IApiHelper apiHelper
            , IConfiguration configuration)
        {
            this.fireBaseConfig = fireBaseConfig.Value;
            this.apiHelper = apiHelper;
            this.configuration = configuration;
        }
        public async Task<bool> SendSMSAsync(NotificationDto notifi)
        {
            string url = $"https://www.jawalbsms.ws/api.php/sendsms?user=Taxi24-7&pass=D5J2tX2024Tanfeth&to={notifi.PhoneNumber}&message={notifi.Code}&sender=Taxi24-7";
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);
            var responseString = await response.Content.ReadAsStringAsync();
            return true;


        }

        public async Task<bool> SendNotificationAsync(List<string> tokens,  NotificationMessages notificationMessage, dynamic obj = null
            , LanguageEnum? lang = LanguageEnum.Arabic)
        {

            using (var client = new HttpClient())
            {
                var firebaseOptionsServerId = configuration["Firebase:ServerId"];
                var firebaseOptionsSenderId = configuration["Firebase:SenderId"];

                client.BaseAddress = new Uri("https://fcm.googleapis.com");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization",
                    $"key={firebaseOptionsServerId}");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Sender", $"id={firebaseOptionsSenderId}");
                string title = string.Empty;
                string body = string.Empty;
                if (lang == LanguageEnum.Arabic)
                {
                    title = notificationMessage.TitleEn;
                    body = notificationMessage.BodyEn;
                }
                else
                {
                    title = notificationMessage.TitleAr;
                    body = notificationMessage.BodyAr;
                }
                var data = new
                {
                    registration_ids = tokens,
                    notification = new
                    {
                        body = body,
                        title = title,
                    },
                    //data = obj,
                    priority = "high"
                };

                var json = JsonConvert.SerializeObject(data);
                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                var result = await client.PostAsync("/fcm/send", httpContent);
                var responseContent = await result.Content.ReadAsStringAsync();
                return result.StatusCode.Equals(HttpStatusCode.OK);
            }
        }

     
        public async Task SendNotifications(SendNotificationDto notifi)
        {
            using (var client = new HttpClient())
            {
                var firebaseOptionsServerId = "AAAApRBeIpU:APA91bG7f_A9uuirQ4Cn5JBOqkC2SDS_S6UuAp-1wy1eTkl_iLdtPrXzvqMAwoX37M_E7oiP1t1XrQsU9_5qfzU9zyT0sgcZLZ6HUkntmJ9IpHCw73Apwg7RNiyN8UOiyAZUAym8A84j";
                var firebaseOptionsSenderId = "708944208533";
                client.BaseAddress = new Uri("https://fcm.googleapis.com");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization",
                    $"key={firebaseOptionsServerId}");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Sender", $"id={firebaseOptionsSenderId}");
                var data = new
                {
                    registration_ids = notifi.DeviceToken,
                    notification = new
                    {
                        body = notifi.Body,
                        title = notifi.Title,
                    },
                    priority = "high"
                };
                var json = JsonConvert.SerializeObject(data);
                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                var result = await client.PostAsync("/fcm/send", httpContent);
                var response = result.Content.ReadAsStringAsync();
            }
        }

     
        private double GetDistance(double lon1d, double lat1d, double lon2d, double lat2d)
        {
            var R = 6378137; // Earth’s mean radius in meter
            var dLat = ToRadians(lat2d - lat1d);
            var dLong = ToRadians(lon2d - lon1d);
            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
              Math.Cos(ToRadians(lat1d)) * Math.Cos(ToRadians(lat2d)) *
              Math.Sin(dLong / 2) * Math.Sin(dLong / 2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            var d = R * c;
            return Math.Round(d / 1000, 2); // returns the distance in KM
        }
        private double ToRadians(double degrees) => degrees * Math.PI / 180.0;
    }

}

