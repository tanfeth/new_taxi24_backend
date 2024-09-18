using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi24.Core.Common.Enum;

namespace Taxi24.Core.Entity
{
    public class Order : EntityBase
    {
        public int? UserId { get; set; }
        public User User { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal ApplicationPrice { get; set; }
        public decimal DriverPrice { get; set; }
        public decimal TaxPrice { get; set; }
        public decimal? WaitingPrice { get; set; }
        public int? DriverId { get; set; }
        public Driver? Driver { get; set; }
        public int? PromoCodeId { get; set; }
        public PromoCode? PromoCode { get; set; }
        public OrderStatus Status { get; set; }
        public string? RiderName { get; set; }
        public string? RiderMobileNumber { get; set; }
        public string? CancelledReason { get; set; }
        public string? TripId { get; set; }
        public int? UserRate { get; set; }
        public int? DriverRate { get; set; }
        public string? CustomerNote { get; set; }
        public string? DriverNote { get; set; }
        public DateTime? StartTrip { get; set; }
        public DateTime? DriverArriveTime { get; set; }
        public DateTime? EndTrip { get; set; }
        public DateTime? DriverAcceptOrderDate { get; set; }
        public CarSeatType? CarSeatType { get; set; }
        public OrderPaymentStatus? OrderPaymentStatus { get; set; }
        public virtual ICollection<Point> Points { get; set; }
        public virtual ICollection<OrderPaymentMethod> OrderPaymentMethods { get; set; }
        public int? CardId { get; set; }
        public Card? Card { get; set; }
        public decimal? DepitFromWalletAmount { get; set; }
        public int? LocationId { get; set; }
        public Location? Location { get; set; }
        public int? Duration { get; set; }
        public double? DistanceKM { get; set; }

        public int? CarId { get; set; }
        public Car? Car { get; set; }

        public bool IsRegisterdInWsl { get; set; }
        public string? ErrorInRegistreToWsl { get; set; }
        public bool IsCharged { get; set; }
        
    }

    public sealed class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.User).WithMany(x => x.Orders).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Driver).WithMany(x => x.Orders).HasForeignKey(x => x.DriverId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.PromoCode).WithMany(x => x.Orders).HasForeignKey(x => x.PromoCodeId);
            builder.HasMany(x => x.OrderPaymentMethods).WithOne(x => x.Order).HasForeignKey(x => x.OrderId);
            builder.HasOne(x => x.Card).WithMany().HasForeignKey(x => x.CardId);
            builder.HasOne(x => x.Location).WithMany().HasForeignKey(x => x.LocationId);
            builder.HasOne(x => x.Car).WithMany().HasForeignKey(f => f.CarId);
            ////builder.HasQueryFilter(x => !x.IsDeleted);

        }
    }

}
