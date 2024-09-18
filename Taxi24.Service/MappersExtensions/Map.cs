using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi24.Core.Common.Enum;
using Taxi24.Core.Common.Utlities;
using Taxi24.Core.Entity;
using Taxi24.Core.Response;

namespace Taxi24.Service.MappersExtensions
{
    public static class Map
    {
        public static LoginResponse MapDriverLoginResponse(this User user)
        {
            var accountStatusStr = "Pending";
            var car = user?.Driver?.Cars?.FirstOrDefault(x => x.IsDefault);
            var accountStatus = user?.ProfileImageState == "Approved" && user?.Driver?.SaudiIdImageState == "Approved"
                && user.Driver?.LicenseImageState == "Approved" && car?.CarInssuranceState == "Approved"
                && car?.CarRegistrationState == "Approved" && car?.Eligibility == "VALID" && user?.Driver?.Eligibility == "VALID";

            if (!accountStatus)
            {
                var isRejected = user?.ProfileImageState == "Rejected" || user?.Driver?.SaudiIdImageState == "Rejected"
                || user.Driver?.LicenseImageState == "Rejected" || car?.CarInssuranceState == "Rejected"
                || car?.CarRegistrationState == "Rejected" || car?.Eligibility == "INVALID" || user?.Driver?.Eligibility == "INVALID";

                if (isRejected)
                    accountStatusStr = "Rejected";
            }
            else
            {
                accountStatusStr = "Approved";
            }
            return new LoginResponse
            {
                IsInTrip = false,
                AccountState = accountStatusStr
            };
        }

        public static LoginResponse MapPassangerResponse(this User user)
        {
            return new LoginResponse
            {
                //UserName = user.UserName,
                //Email = user.Email,
                //Name = user.Name,
            };
        }




    }
}
