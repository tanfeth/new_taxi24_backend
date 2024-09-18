using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Taxi24.Core.Common.Enum;

namespace Taxi24.Core.Entity
{
    public class Driver : EntityBase
    {

        public string DriverNumber { get; set; }
        public string? License { get; set; }
        public DateTime? LicenceExpiryDate { get; set; }
        public string? SaudiId { get; set; }
        public DateTime? SaudiIdExpiryDate { get; set; }
        public StatusEnum Status { get; set; }
       
        public string? LicenseImageState { get; set; }
        public string? SaudiIdImageState { get; set; }
        public int UserId { get; set; }
        public string? TripId { get; set; }
        public User User { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
        public int RejectedOrdersCount { get; set; }
        public double WorkingHoursInMin { get; set; }
        public string? Eligibility { get; set; }
        public int? CompletedTrip { get { return Orders?.Count(x => x.Status == OrderStatus.CashPaid || x.Status == OrderStatus.Completed); } }
        public int? CancelledTrip { get { return Orders?.Count(x => x.Status == OrderStatus.UserCancelled); } }
        public int? SaudiIdModifiedBy { get; set; }
        public int? LicenseStatusBy { get; set; }
        public User? SaudiIdModifiedUser { get; set; }
        public User? LicenseModifiedUser { get; set; }
        public string? LicenseImageStateNote { get; set; }
        public string? SaudiIdImageStateNote { get; set; }

    }

    public sealed class DriverMap : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.User).WithOne(x => x.Driver).HasForeignKey<Driver>(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.Cars).WithOne(x => x.Driver).HasForeignKey(x => x.DriverId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.SaudiIdModifiedUser).WithMany().HasForeignKey(x => x.SaudiIdModifiedBy);
            builder.HasOne(x => x.LicenseModifiedUser).WithMany().HasForeignKey(x => x.LicenseStatusBy);
            ////builder.HasQueryFilter(x => !x.IsDeleted);
            builder.Ignore(x => x.CompletedTrip);
            builder.Ignore(x => x.CancelledTrip);

        }
    }
}
