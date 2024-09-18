using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Entity
{
    public class EntityBase
    {
        public int Id { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public int? CreationUser { get; set; }
        public int? ModificationUser { get; set; }
        public bool IsDeleted { get; set; }
    }
}
