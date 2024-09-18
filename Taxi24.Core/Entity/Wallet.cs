using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Entity
{
    public class Wallet : EntityBase
    {
        public decimal Amount { get; set; }
        public string WalletNumber { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }  
        public virtual ICollection<WalletActions> Actions { get; set; }
    }

    public sealed class WalletMap : IEntityTypeConfiguration<Wallet>
    {
        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.User)
                .WithOne(x=> x.Wallet)
                .HasForeignKey<Wallet>(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x=> x.Actions)
                .WithOne(x=> x.Wallet)
                .HasForeignKey(x=> x.WalletId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Ignore(x => x.CreationDate);
            builder.Ignore(x => x.CreationUser);
            //builder.HasQueryFilter(x => !x.IsDeleted);

        }
    }
}
