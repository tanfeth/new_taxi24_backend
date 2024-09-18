using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Common.Enum
{
    public enum NotificationTypeEnum
    {
        Application = 1,
        SMS = 2,
        Email = 3
    }

    public enum NotificationNames
    {
        DriverApproveTrip = 1,
        DriverArrive = 2,
        DriverCancelTrip = 3,
        OrderFinalPriceChanged = 4,
        UserCancelTrip = 5,
        DriverDocumentsReminder = 6,
        DriverRejectedDocuments = 7,
        SauidIdApporved = 8,
        LicenseApproved = 9,
        CarRegistrationApproved = 10,
        CarInsuranceApproved = 11,
        ProfileImageApproved = 12

    }
}
