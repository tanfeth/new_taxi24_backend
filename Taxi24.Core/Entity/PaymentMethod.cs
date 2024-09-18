using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Entity
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public sealed class PaymentMethodMap : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(new PaymentMethod()
            {
                Id = 1,
                Name = "Cash"
            }, new PaymentMethod()
            {
                Id = 2,
                Name = "Credit"
            },
            new PaymentMethod()
            {
                Id = 3,
                Name = "Wallet"
            },
            new PaymentMethod()
            {
                Id = 4,
                Name = "CashWallet"
            },
            new PaymentMethod()
            {
                Id = 5,
                Name = "CreditWallet"
            }
            
            );


        }
    }

}
