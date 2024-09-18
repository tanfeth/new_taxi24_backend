using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Dto
{
    public class GetDriverCarsResponse
    {
        public string? CarModel { get; set; }
        public string? CarType { get; set; }
        public string? Plate { get; set; }
        public string? CarCollor { get; set; }
        public int? Year { get; set; }

    }
}
