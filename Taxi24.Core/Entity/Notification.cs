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
    public class Notification : EntityBase
    {
        public string Body { get; set; }
        public string Title { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
        public RoleEnum? RoleEnum { get; set; }

    }

    public sealed class NotificationMap : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
            builder.Ignore(x => x.ModificationUser);
            builder.Ignore(x => x.ModificationDate);
            ////builder.HasQueryFilter(x => !x.IsDeleted);
        }
    }
}
