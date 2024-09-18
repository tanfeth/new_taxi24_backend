using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> SaveChangesAsync();
    }

}
