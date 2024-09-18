
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Entity
{
    public class Account : EntityBase
    {
        public string AccountOwnerName { get; set; }
        public string Bank { get; set; }
        public string IBAN { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }

    public sealed class AccountMap : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Ignore(x => x.CreationDate);
            builder.Ignore(x => x.CreationUser);
            ////builder.HasQueryFilter(x => !x.IsDeleted);

        }
    }
}
