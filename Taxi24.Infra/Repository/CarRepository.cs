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
    public class CarRepository : Repository<Car>, ICarRepository
    {
        public CarRepository(StoreContext context, IUserHandler userHandler) : base(context, userHandler)
        {
        }

        public async Task<Car> GetDefaultCar(int userId)
        {
            return await FirstOrDefaultAsync(x => x.Driver.UserId == userId && x.IsDefault, x=> x.Include(f=> f.Driver));
        }

        public  IQueryable<Car> GetDriverCars(int driverId)
        {
            return  GetAll(x => x.DriverId == driverId);
        }
    }
}
