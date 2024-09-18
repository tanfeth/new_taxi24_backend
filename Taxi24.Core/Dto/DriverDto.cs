using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Dto
{
    public class DriverDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DriverNumber { get; set; }
        public double Rate { get; set; }
        public string CarName { get; set; }
        public string ProfileImage { get; set; }
    }
}
