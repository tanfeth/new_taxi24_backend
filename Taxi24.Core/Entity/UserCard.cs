using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Entity
{
    public class UserCard : EntityBase
    {
        public int UserId { get; set; }
        public string Token { get; set; }
        public User User { get; set; }
        public bool IsDeleted { get; set; }
    }

    public sealed class UserCardMap : IEntityTypeConfiguration<UserCard>
    {
        public void Configure(EntityTypeBuilder<UserCard> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId);
            //builder.HasQueryFilter(x => !x.IsDeleted);
        }
    }
}
