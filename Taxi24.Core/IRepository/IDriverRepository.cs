using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi24.Core.Entity;

namespace Taxi24.Core.IRepository
{
    public interface IDriverRepository : IRepository<Driver>
    {

        Task<Driver> GetLoggedInDriver();

    }
}
