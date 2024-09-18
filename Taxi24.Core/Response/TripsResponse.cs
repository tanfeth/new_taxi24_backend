using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi24.Core.Common.Enum;
using Taxi24.Core.Dto;

namespace Taxi24.Core.Response
{
    public class TripsResponse
    {
        public List<TripsDto> TripsDtos { get; set; }
        public string Month { get; set; }
    }

    public class TripsDto
    {
        public int OrderId { get; set; }

        public List<PointDto> Points { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public DriverDto Driver { get; set; }
        public DateTime CreationDate { get; set; }
        public decimal Price { get; set; }

    }

    public class TripExistsDto
    {
        public string? TripId { get; set; }
        public int OrderId { get; set; }
    }

}
