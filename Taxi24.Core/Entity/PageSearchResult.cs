using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Entity
{
    public class PageSearchResult<T>
    {
        public T Data { get; set; }
        public int NumberOfRecords { get; set; }
    }
}
