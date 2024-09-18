using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Entity
{
    public class Role : EntityBase
    {
        public string Name { get; set; }
    }

    public sealed class RoleMap : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Ignore(x => x.CreationDate);
            builder.Ignore(x => x.CreationUser);
            builder.Ignore(x => x.ModificationDate);
            builder.Ignore(x => x.ModificationUser);

            builder.HasData(
                new Role() { Id = 1, Name = "Admin" },
                new Role() { Id = 2, Name = "User" },
                new Role() { Id = 3, Name = "Driver" },
                new Role() { Id = 4, Name = "SubAdmin" }
                );
            ////builder.HasQueryFilter(x => !x.IsDeleted);
        }
    }
}
