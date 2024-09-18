using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Entity
{
    public class Permission : EntityBase
    {

        public string Code { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int? ParentId { get; set; }
        public IEnumerable<GroupPermissions>? GroupPermissions { get; set; }
        public IEnumerable<Permission>? Childs { get; set; }

        public Permission? Parent { get; set; }
        public bool IsSystem { get; set; }
    }

    public sealed class PermissionMap : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Childs).WithOne(x => x.Parent).HasForeignKey(x => x.ParentId);
            ////builder.HasQueryFilter(x => !x.IsDeleted);

            builder.HasData(
                new Permission()
                {
                    Id = 1,
                    Code = "Driver",
                    NameEn = "Driver",
                    NameAr = "Driver"
                },
                new Permission()
                {
                    Id = 2,
                    Code = "delete_driver",
                    NameEn = "Delete Driver",
                    NameAr = "Delete Driver",
                    ParentId = 1,
                },
                new Permission()
                {
                    Id = 3,
                    Code = "approve_documents",
                    NameEn = "Approve ,  Reject Documents",
                    NameAr = "Approve ,  Reject Documents",
                    ParentId = 1
                },
                 new Permission()
                 {
                     Id = 4,
                     Code = "users",
                     NameEn = "Users",
                     NameAr = "Users"
                 },
                 new Permission()
                 {
                     Id = 5,
                     Code = "activate_deactivate_users",
                     NameEn = "Activate , DeActivate User",
                     NameAr = "Activate , DeActivate User",
                     ParentId = 4
                 },
                 new Permission()
                 {
                     Id = 6,
                     Code = "users_delete",
                     NameEn = "Delete User",
                     NameAr = "Delete User",
                     ParentId = 4
                 },
                 new Permission()
                 {
                     Id = 7,
                     Code = "users_edit",
                     NameEn = "Edit User",
                     NameAr = "Edit User",
                     ParentId = 4
                 },
                 new Permission()
                 {
                     Id = 8,
                     Code = "users_details",
                     NameEn = "Details User",
                     NameAr = "Details User",
                     ParentId = 4
                 },
                 new Permission()
                 {
                     Id = 9,
                     Code = "trips",
                     NameEn = "Trips",
                     NameAr = "Trips"
                 },
                 new Permission()
                 {
                     Id = 10,
                     Code = "trips_details",
                     NameEn = "Trips Details",
                     NameAr = "Trips Details",
                     ParentId = 9 
                 },
                 new Permission()
                 {
                     Id = 11,
                     Code = "notifications",
                     NameEn = "Notifications",
                     NameAr = "Notifications"
                 },
                 new Permission()
                 {
                     Id = 12,
                     Code = "notifications",
                     NameEn = "Notification Send",
                     NameAr = "Notification Send",
                     ParentId = 12
                 },
                 new Permission()
                 {
                     Id = 13,
                     Code = "delete_notifications",
                     NameEn = "Notifications Delete",
                     NameAr = "Notifications Delete"
                 },
                 new Permission()
                 {
                     Id = 14,
                     Code = "promo_code",
                     NameEn = "Promo Codes",
                     NameAr = "Promo Codes"
                 },
                 new Permission()
                 {
                     Id = 15,
                     Code = "promo_code_add",
                     NameEn = "Promo Code Add",
                     NameAr = "Promo Code Add",
                     ParentId = 14
                 },
                 new Permission()
                 {
                     Id = 16,
                     Code = "promo_code_delete",
                     NameEn = "Promo Code Delete",
                     NameAr = "Promo Code Delete",
                     ParentId = 14
                 },
                 new Permission()
                 {
                     Id = 17,
                     Code = "activate_deactivate_promoCode",
                     NameEn = "Promo Code Activate ,Deactivate",
                     NameAr = "Promo Code Activate ,Deactivate",
                     ParentId = 14
                 },
                 new Permission()
                 {
                     Id = 18,
                     Code = "transactions",
                     NameEn = "Transactions",
                     NameAr = "Transactions"
                 },
                 new Permission()
                 {
                     Id = 19,
                     Code = "settings",
                     NameEn = "settings",
                     NameAr = "settings"
                 },
                 new Permission()
                 {
                     Id = 20,
                     Code = "support",
                     NameEn = "Support",
                     NameAr = "Support"
                 },
                 new Permission()
                 {
                     Id = 21,
                     Code = "wallets",
                     NameEn = "Wallets",
                     NameAr = "Wallets"
                 },
                 new Permission()
                 {
                     Id = 22,
                     Code = "group",
                     NameEn = "Groups",
                     NameAr = "Groups",
                     IsSystem= true,
                 },
                 new Permission()
                 {
                     Id = 23,
                     Code = "group_add",
                     NameEn = "Groups Add",
                     NameAr = "Groups Add",
                     ParentId = 22,
                     IsSystem = true
                 },
                 new Permission()
                 {
                     Id = 24,
                     Code = "group_edit",
                     NameEn = "Groups Edit",
                     NameAr = "Groups Edit",
                     ParentId = 22,
                     IsSystem = true
                 },
                 new Permission()
                 {
                     Id = 25,
                     Code = "group_delete",
                     NameEn = "Groups Delete",
                     NameAr = "Groups Delete",
                     ParentId = 22,
                     IsSystem = true,
                 },
                 new Permission()
                 {
                     Id = 26,
                     Code = "users_add",
                     NameEn = "Add User",
                     NameAr = "Add User",
                     ParentId = 4,
                     IsSystem = true
                 },
                 new Permission()
                 {
                     Id = 27,
                     Code = "cars",
                     NameEn = "Cars",
                     NameAr = "Cars"
                 },
                 new Permission()
                 {
                     Id = 28,
                     Code = "Approve , Reject documents",
                     NameEn = "Approve , Reject documents",
                     NameAr = "Approve , Reject documents",
                     ParentId = 27
                 },
                 new Permission()
                 {
                     Id = 29,
                     Code = "car_details",
                     NameEn = "Car Details",
                     NameAr = "Car Details",
                     ParentId = 27
                 },
                 new Permission()
                 {
                     Id = 30,
                     Code = "driver_details",
                     NameEn = "Driver Details",
                     NameAr = "Driver Details",
                     ParentId = 1
                 },
                 new Permission()
                 {
                     Id = 31,
                     Code = "dashboard",
                     NameEn = "dashboard",
                     NameAr = "dashboard"
                 },
                 new Permission()
                 {
                     Id = 32,
                     Code = "isAdmin",
                     NameEn = "isAdmin",
                     NameAr = "isAdmin",
                     IsSystem = true
                 }


            );
        }
    }
}
