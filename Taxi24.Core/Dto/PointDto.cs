using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Dto
{
    public class PointDto
    {
        public int Index { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public string? PlaceId { get; set; }
        public string? Description { get; set; }
        public string? SecondaryText { get; set; }
    }
}
