using Taxi24.Core.Common.Handler;
using Taxi24.Core.Common.IHandler;
using Taxi24.Core.Entity;
using Taxi24.Core.IRepository;
using Taxi24.Infra.Data;

namespace Taxi24.Infra.Repository
{
    public class NotificationRepository : Repository<Notification>, INotificationRepository
    {
        private readonly StoreContext context;

        public NotificationRepository(StoreContext context, IUserHandler userHandler 
            ) : base(context, userHandler)
        {
            this.context = context;
        }

    }
}
