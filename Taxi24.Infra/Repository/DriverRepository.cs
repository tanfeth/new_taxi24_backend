using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi24.Core.Common.IHandler;
using Taxi24.Core.Entity;
using Taxi24.Core.IRepository;
using Taxi24.Infra.Data;
using Taxi24.Infra.Repository;

namespace Taxi24.Core.Repository
{
    public class DriverRepository : Repository<Driver>, IDriverRepository
    {
        public DriverRepository(StoreContext context, IUserHandler userHandler) : base(context, userHandler)
        {
        }

        public async Task<Driver> GetLoggedInDriver()
        {
            var userId = userHandler.GetUserId();
            return await FirstOrDefaultAsync(x => x.UserId == userId, include: x =>
            x.Include(u => u.User)
            .Include(f => f.Cars)
            .ThenInclude(x => x.CarModelLookup)
             .Include(f => f.Cars)
            .ThenInclude(x => x.CarTypeLookup)
            );
        }
    }
}
