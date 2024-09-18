using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Entity
{
    public class OrderPaymentMethod
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }

    public sealed class OrderPaymentMethodMap : IEntityTypeConfiguration<OrderPaymentMethod>
    {
        public void Configure(EntityTypeBuilder<OrderPaymentMethod> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.PaymentMethod).WithMany().HasForeignKey(x => x.PaymentMethodId);
            
        }
    }
}
