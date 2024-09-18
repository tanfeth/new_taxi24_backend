using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Entity
{
    public class Location : EntityBase
    {
        public string PlaceId { get; set; }
        public string Description { get; set; }
        public string SecondaryText { get; set; }
        public string OrignalDescription { get; set; }
        public string OrignalSecondaryText { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
        public bool IsFav { get; set; }
    }

    public sealed class LocationMap : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.User).WithMany(x=> x.Locations).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
            builder.Ignore(x=> x.IsFav);
            ////builder.HasQueryFilter(x => !x.IsDeleted);
        }
    }
}
