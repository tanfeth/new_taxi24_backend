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
    public class LookupValuesRepository : Repository<LookupValues>, ILookupValuesRepository
    {
        public LookupValuesRepository(StoreContext context, IUserHandler userHandler) : base(context, userHandler)
        {
        }
    }
}
