using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Entity
{
    public class GroupPermissions
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int PermissionId { get; set; }
        public Group? Group { get; set; }
        public Permission? Permission  { get; set; }

    }

    public sealed class GroupPermissionsMap : IEntityTypeConfiguration<GroupPermissions>
    {
        public void Configure(EntityTypeBuilder<GroupPermissions> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x=> x.Group)
                .WithMany(x=> x.GroupPermissions)
                .HasForeignKey(x=> x.GroupId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x=> x.Permission)
                .WithMany(x => x.GroupPermissions)
                .HasForeignKey(x=> x.PermissionId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
