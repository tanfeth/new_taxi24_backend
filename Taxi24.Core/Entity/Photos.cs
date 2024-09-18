using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Entity
{
    public class Photos : EntityBase
    {
        public string Type { get; set; }
        public int ModelId { get; set; }
        public string Image { get; set; }
    }

    public sealed class PhotosMap : IEntityTypeConfiguration<Photos>
    {
        public void Configure(EntityTypeBuilder<Photos> builder)
        {
            builder.HasKey(x => x.Id);
            //builder.HasQueryFilter(x => !x.IsDeleted);
        }
    }
}
