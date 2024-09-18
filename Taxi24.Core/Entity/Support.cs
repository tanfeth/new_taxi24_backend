using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Entity
{
    public class Support : EntityBase
    {
        public string Reason { get; set; }
        public string Description { get; set; }
        public int? UserId { get; set; }
        //public List<Photos>? Photos { get; set; }
        public User? User { get; set; }
        public bool IsRead { get; set; }
    }

    public sealed class SupportMap : IEntityTypeConfiguration<Support>
    {
        public void Configure(EntityTypeBuilder<Support> builder)
        {
            builder.HasKey(x => x.Id);
            //builder.HasQueryFilter(x => !x.IsDeleted);
            //builder.HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Cascade);
            //builder.HasMany(x => x.Photos).WithOne().HasForeignKey(x => x.ModelId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
