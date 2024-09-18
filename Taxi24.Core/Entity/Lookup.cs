using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Entity
{
    public class Lookup : EntityBase
    {
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string Code { get; set; }
        public virtual ICollection<LookupValues>? LookupValues { get; set; }
    }

    public sealed class LookupMap : IEntityTypeConfiguration<Lookup>
    {
        public void Configure(EntityTypeBuilder<Lookup> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.LookupValues)
                .WithOne(x => x.Lookup)
                .HasForeignKey(x => x.LookupId);

            builder.HasData(
                new Lookup()
                {
                    Id = 1,
                    NameEn = "Cars",
                    NameAr = "سيارات",
                    Code = "cars",
                    CreationDate = new DateTime(2024, 1, 1),
                    IsDeleted = false,
                },
                new Lookup()
                {
                    Id = 2,
                    NameEn = "Nationalities",
                    NameAr = "الجنسية",
                    Code = "nationality",
                    CreationDate = new DateTime(2024, 1, 1),
                    IsDeleted = false,
                }
                );
         
            ////builder.HasQueryFilter(x => !x.IsDeleted);
        }
    }
}
