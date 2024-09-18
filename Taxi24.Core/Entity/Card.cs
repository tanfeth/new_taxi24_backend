using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Entity
{
    public class Card : EntityBase
    {
        public int UserId { get; set; }
        public string CardNumber { get; set; }
        public string Token { get; set; }
        public string CardBrand { get; set; }
        public User User { get; set; }
        public DateTime? ExpiryDate { get; set; }
    }

    public sealed class CardsMap : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
            ////builder.HasQueryFilter(x => !x.IsDeleted);
        }
    }
}
