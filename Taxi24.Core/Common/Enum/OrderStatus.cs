using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Common.Enum
{
    public enum OrderStatus
    {
        Pending = 0,
        ConfirmOrder = 1,
        DriverApprovedTrip = 2,
        DriverArrived = 3,
        Start = 4,
        Completed = 5,
        CashPaid = 6,
        UserCancelled = 7,
        PaymentFailed = 8,
        DriverRejectTrip = 9 ,
        DriverCancelledOrder = 10,
        PassangerDidnotShow = 11,
        DeleteTrip = 12
    }
}
