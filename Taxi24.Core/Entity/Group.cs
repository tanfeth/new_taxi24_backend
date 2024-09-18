using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Entity
{
    public class Group : EntityBase
    {
        public string Name { get; set; }
        public List<GroupPermissions>? GroupPermissions { get; set; }
        public bool IsSystem { get; set; }
    }

    public sealed class GroupMap : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(x => x.Id);
            ////builder.HasQueryFilter(x => !x.IsDeleted);
        }
    }
}
