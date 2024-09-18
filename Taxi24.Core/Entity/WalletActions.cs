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
    public class WalletActions : EntityBase
    {
        public int WalletId { get; set; }
        public WalletActionTypeEnum WalletActionType { get; set; }
        public decimal Amount { get; set; } 
        public int? AccountId { get; set; }
        public Account? Account { get; set; }
        public Wallet Wallet { get; set; }
        public TransferActionEnum TransferAction { get; set; }
        public string? TrackId { get; set; }
        public string? CardNumber { get; set; }

    }

    public sealed class WalletActionsMap : IEntityTypeConfiguration<WalletActions>
    {
        public void Configure(EntityTypeBuilder<WalletActions> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Account)
                .WithMany()
                .HasForeignKey(x => x.AccountId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Wallet)
            .WithMany()
            .HasForeignKey(x => x.WalletId)
            .OnDelete(DeleteBehavior.NoAction);
            builder.Ignore(x => x.CreationDate);
            builder.Ignore(x => x.CreationUser);
            //builder.HasQueryFilter(x => !x.IsDeleted);
        }
    }
}
