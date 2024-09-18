using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Entity
{
    public class Transaction : EntityBase
    {

        public int? WalletActionId { get; set; }
        public string Action { get; set; }
        public string TrackId { get; set; }
        public string TransId { get; set; }
        public string? RequestHash { get; set; }
        public string Currency { get; set; }
        public string? CustomerEmail { get; set; }
        public decimal Amount { get; set; }
        public int UserId { get; set; }
        public string? ErrorMessage { get; set; }
        public string? CardNumber { get; set; }
        public User User { get; set; }
        public WalletActions? WalletActions { get; set; }
    }


    public sealed class TransactionMap : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.WalletActions)
                .WithOne()
                .HasForeignKey<Transaction>(x => x.WalletActionId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);
            //builder.HasQueryFilter(x => !x.IsDeleted);
        }
    }
}
