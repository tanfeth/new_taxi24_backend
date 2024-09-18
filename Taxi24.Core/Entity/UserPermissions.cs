using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Entity
{
    public class UserPermissions : EntityBase
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int PermissionId { get; set; }
        public Permission Permission { get; set; }
    }

    public sealed class UserPermissionsMap : IEntityTypeConfiguration<UserPermissions>
    {
        public void Configure(EntityTypeBuilder<UserPermissions> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.User).WithMany(x=> x.UserPermissions).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Permission).WithMany().HasForeignKey(x => x.PermissionId).OnDelete(DeleteBehavior.NoAction);
            //builder.HasQueryFilter(x => !x.IsDeleted);
        }
    }
}
