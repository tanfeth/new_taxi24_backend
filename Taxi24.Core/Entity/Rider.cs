using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Entity
{
    public class Rider : EntityBase
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public User User { get; set; }
        
    }

    public sealed class RiderMap : IEntityTypeConfiguration<Rider>
    {
        public void Configure(EntityTypeBuilder<Rider> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
            //builder.HasQueryFilter(x => !x.IsDeleted);
        }
    }
}
