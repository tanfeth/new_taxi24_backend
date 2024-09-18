using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi24.Core.Common.Enum;

namespace Taxi24.Core.Entity
{
    public class PromoCode : EntityBase
    {
        public string Code { get; set; }
        public DateTime ExpiryDate { get; set; }
        public PriceType PriceType { get; set; }
        public double Price { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
        public PromoCodeStatus PromoCodeStatus { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }
        public int TotalUsedCount
        {
            get
            {
                return Orders != null ? Orders.Count : 0;
            }
        }
        public decimal DiscountRate
        {
            get
            {
                decimal discountRate = 0;
                Orders?.ToList()?.ForEach(item => {
                     discountRate += (PriceType == Taxi24.Core.Common.Enum.PriceType.Fixed ? (decimal)Price :
                    (item.TotalPrice * (decimal)Price / 100));
                });
                return discountRate;
            }
        }

    }

    public sealed class PromoCodeMap : IEntityTypeConfiguration<PromoCode>
    {
        public void Configure(EntityTypeBuilder<PromoCode> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.User).WithMany(x => x.PromoCodes).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
            //builder.HasQueryFilter(x => !x.IsDeleted);
            builder.Ignore(x => x.TotalUsedCount);
            builder.Ignore(x => x.DiscountRate);


        }
    }

}
