using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Entity
{
    public class UserRole : EntityBase
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public User User { get; set; }
        public Role Role { get; set; }

        public string RoleName
        {
            get
            {
                return Role?.Name;
            }
        }
    }

    public sealed class UserRoleMap : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.User).WithMany(x => x.UserRoles).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Role).WithMany().HasForeignKey(x => x.RoleId);
            builder.Ignore(x => x.CreationDate);
            builder.Ignore(x => x.CreationUser);
            builder.Ignore(x => x.ModificationDate);
            builder.Ignore(x => x.ModificationUser);
            builder.Ignore(x => x.RoleName);


        }
    }
}
