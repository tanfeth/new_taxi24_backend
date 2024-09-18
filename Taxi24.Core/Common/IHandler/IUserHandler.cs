using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi24.Core.Entity;

namespace Taxi24.Core.Common.IHandler
{
    public interface IUserHandler
    {
        int? GetUserId();
        string GetLanguage();
    }
}
