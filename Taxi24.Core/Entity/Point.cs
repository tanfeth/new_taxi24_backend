using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi24.Core.Common.Enum;

namespace Taxi24.Core.Entity
{
    public class Point : EntityBase
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public int Index { get; set; }
        public string? PlaceId { get; set; }
        public string? Description { get; set; }
        public string? SecondaryText { get; set; }
    }

    public sealed class PointMap : IEntityTypeConfiguration<Point>
    {
        public void Configure(EntityTypeBuilder<Point> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Order).WithMany(x => x.Points).HasForeignKey(x => x.OrderId);
            //builder.HasQueryFilter(x => !x.IsDeleted);
        }
    }

}
