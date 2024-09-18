using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Entity
{
    public class OrderTemp : EntityBase
    {
        public int UserId { get; set; }
        public double SedanCarPrice { get; set; }
        public double FamilyCarPrice { get; set; }
        public int Duration { get; set; }
        public int DistanceInKM { get; set; }
        public int? PromoCodeId { get; set; }
        public string StartPrice { get; set; }
        public string DurationPriceSedan { get; set; }
        public string DurationPriceFamily { get; set; }
        public string SedanCarPriceKM { get; set; }
        public string FamilyCarPriceKM { get; set; }
        public User User { get; set; }
        public PromoCode? PromoCode { get; set; }

    }

    public sealed class OrderTempMap : IEntityTypeConfiguration<OrderTemp>
    {
        public void Configure(EntityTypeBuilder<OrderTemp> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.PromoCode).WithMany().HasForeignKey(x => x.PromoCodeId);
            ////builder.HasQueryFilter(x => !x.IsDeleted);
        }
    }

}
