using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Taxi24.Core.Entity;

namespace Taxi24.Core.IRepository
{
    public interface ICarRepository : IRepository<Car>
    {

        Task<Car> GetDefaultCar(int userId);
        IQueryable<Car> GetDriverCars(int driverId);
    }
}
