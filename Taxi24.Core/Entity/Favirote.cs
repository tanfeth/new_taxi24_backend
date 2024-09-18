using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Entity
{
    public class Favirote : EntityBase
    {
        public string PlaceId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }

    public sealed class FaviroteMap : IEntityTypeConfiguration<Favirote>
    {
        public void Configure(EntityTypeBuilder<Favirote> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.User).WithMany(x => x.Favirotes).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
            ////builder.HasQueryFilter(x => !x.IsDeleted);
        }
    }
}
