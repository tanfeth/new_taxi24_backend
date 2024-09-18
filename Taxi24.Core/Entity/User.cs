using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi24.Core.Common.Enum;

namespace Taxi24.Core.Entity
{
    public class User : EntityBase
    {
        public User()
        {
            this.UserRoles = new List<UserRole>();
        }
        public string UserName { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Code { get; set; }
        public string? ProfileImage { get; set; }
        public string? DeviceToken { get; set; }
        public string? Password { get; set; }
        public byte[]? Salt { get; set; }
        public bool IsVerified { get; set; }
        public bool IsEmailVerified { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? DateOfBirthHijri { get; set; }
        public Gender? Gender { get; set; }
        public string? ProfileImageState { get; set; }
        public string? IdentityNumber { get; set; }
        public bool IsActive { get; set; }
        public int? GroupId { get; set; }
        public int CancelTripCount { get; set; }
        public bool PasswordReset { get; set; }
        public Group? Group { get; set; }
        public List<UserRole> UserRoles { get; set; }
        public Driver Driver { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<Favirote> Favirotes { get; set; }
        public virtual ICollection<PromoCode> PromoCodes { get; set; }
        public virtual ICollection<UserPermissions> UserPermissions { get; set; }
        public string? City { get; set; }
        public LanguageEnum? Language { get; set; }
        public Wallet Wallet { get; set; }
        public int? CityId { get; set; }
        public LookupValues? Cities { get; set; }
        public string? ProfileImageStateNote { get; set; }
        public string? ProfileImageEdited { get; set; }
        public string? ProfileImageEditedState { get; set; }
        public string? ProfileImageEditedStateNote { get; set; }
        public string RoleName
        {
            get
            {
                string role = "";
                UserRoles.ForEach(x =>
                {
                    if (string.IsNullOrEmpty(role))
                    {
                        role += x?.Role?.Name;
                    }
                    else
                    {
                        role += ",,," + x?.Role?.Name;
                    }


                });
                return role;
            }
        }
    }




    public sealed class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.UserName)
                .IsUnique();
            builder.HasMany(x => x.UserRoles).WithOne(x => x.User).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(x => x.Favirotes).WithOne(x => x.User).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Driver).WithOne(x => x.User).HasForeignKey<Driver>(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Group).WithMany().HasForeignKey(x => x.GroupId);
            ////builder.HasQueryFilter(x => !x.IsDeleted);
            builder.Ignore(x => x.RoleName);

            builder.HasOne(x => x.Cities)
                .WithMany()
                .HasForeignKey(x => x.CityId);

        }
    }
}
