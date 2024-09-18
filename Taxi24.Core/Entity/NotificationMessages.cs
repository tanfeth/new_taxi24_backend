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
    public class NotificationMessages : EntityBase
    {
        public string? TitleEn { get; set; }
        public string? BodyEn { get; set; }
        public string? TitleAr { get; set; }
        public string? BodyAr { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
        public NotificationNames NotificationName { get; set; }
    }

    public sealed class NotificationMessagesMap : IEntityTypeConfiguration<NotificationMessages>
    {
        public void Configure(EntityTypeBuilder<NotificationMessages> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
            builder.Ignore(x => x.ModificationUser);
            builder.Ignore(x => x.ModificationDate);
            ////builder.HasQueryFilter(x => !x.IsDeleted);

            builder.HasData(
                new NotificationMessages
                {
                    Id = 1,
                    TitleEn = "We found driver for you",
                    BodyEn = "[DriverName] will arrive in 5 min",
                    TitleAr = "وجدنا سائق لك",
                    BodyAr = "سوف يصل في 5 دقائق [DriverName]",
                    NotificationName = NotificationNames.DriverApproveTrip,
                },
                new NotificationMessages
                {
                    Id = 2,
                    TitleEn = "Your driver has arrived",
                    BodyEn = "[DriverName] waiting for you,Be sure to meet him before 5 min to avoid any extra fees",
                    TitleAr = "وصل السائق الخاص بك",
                    BodyAr = "في انتظارك ، تأكد من مقابلته قبل 5 دقائق لتجنب أي رسوم إضافية [DriverName]",
                    NotificationName = NotificationNames.DriverArrive,
                },
                new NotificationMessages
                {
                    Id = 3,
                    TitleEn = "Your driver cancelled trip",
                    BodyEn = "we are very sorry for this, you can find other drivers or change your trip",
                    TitleAr = "السائق قام بالغاء الرحلة",
                    BodyAr = "نأسف جدًا لذلك، يمكنك العثور على سائق  اخر أو تغيير رحلتك",
                    NotificationName = NotificationNames.DriverCancelTrip,
                },
                new NotificationMessages
                {
                    Id = 4,
                    TitleEn = "[Amount] SAR withdrawn from your wallet",
                    BodyEn = "Your have been charged with [Amount] SAR from your wallet because your trip fare changed",
                    TitleAr = "ريال سعودي مسحوب من محفظتك [Amount]",
                    BodyAr = "تم تحصيل  [Amount] ريال سعودي من محفظتك بسبب تغيير أجرة رحلتك",
                    NotificationName = NotificationNames.OrderFinalPriceChanged,
                },
                new NotificationMessages
                {
                    Id = 5,
                    TitleEn = "Trip has been canceled",
                    BodyEn = "The user has cancelled the trip. Don't worry we won't charge you.",
                    TitleAr = "تم إلغاء الرحلة",
                    BodyAr = "قام المستخدم بإلغاء الرحلة. لا تقلق لن نفرض عليك رسوم.",
                    NotificationName = NotificationNames.UserCancelTrip,
                },
                new NotificationMessages
                {
                    Id = 6,
                    TitleEn = "Registration Process not complete",
                    BodyEn = "Please complete the information to register with us at Taxi 24",
                    TitleAr = "عملية التسجيل لم تكتمل",
                    BodyAr = "يرجى إكمال المعلومات للتسجيل معنا في تاكسي 24",
                    NotificationName = NotificationNames.DriverDocumentsReminder,
                },
                new NotificationMessages
                {
                    Id = 7,
                    TitleEn = "يرجى إعادة تقديم المستندات المرفوضة",
                    BodyEn = "مرحبًا [DriverName]، للأسف تم رفض بعض مستنداتك، يرجى إعادة إرسالها لمواصلة تسجيلك.",
                    TitleAr = "عملية التسجيل لم تكتمل",
                    BodyAr = "يرجى إكمال المعلومات للتسجيل معنا في تاكسي 24",
                    NotificationName = NotificationNames.DriverRejectedDocuments,
                }

                );

            builder.HasData(new NotificationMessages
            {
                Id = 8,
                TitleEn = "Sauid ID document apporved",
                BodyEn = "Sauid ID document apporved",
                TitleAr = "تم الموافقة على بطاقة الهوية",
                BodyAr = "تم الموافقة على بطاقة الهوية",
                NotificationName = NotificationNames.SauidIdApporved,
            },
                 new NotificationMessages
                 {
                     Id = 9,
                     TitleEn = "Driver License document apporved",
                     BodyEn = "Driver License document apporved",
                     TitleAr = "تم الموافقة على وثيقة رخصة السائق",
                     BodyAr = "تم الموافقة على وثيقة رخصة السائق",
                     NotificationName = NotificationNames.LicenseApproved,
                 },
                 new NotificationMessages
                 {
                     Id = 10,
                     TitleEn = "Car Registration document apporved",
                     BodyEn = "Car Registration  document apporved",
                     TitleAr = "تم الموافقة على وثيقة تسجيل السيارة",
                     BodyAr = "تم الموافقة على وثيقة تسجيل السيارة",
                     NotificationName = NotificationNames.CarRegistrationApproved,
                 },
                 new NotificationMessages
                 {
                     Id = 11,
                     TitleEn = "Driver License document apporved",
                     BodyEn = "Driver License document apporved",
                     TitleAr = "تم الموافقة على وثيقة تأمين السيارة",
                     BodyAr = "تم الموافقة على وثيقة تأمين السيارة",
                     NotificationName = NotificationNames.CarInsuranceApproved
                 }
                 
                 );

            builder.HasData(new NotificationMessages
            {
                Id = 12,
                TitleEn = "Profile image apporved",
                BodyEn = "Profile image apporved",
                TitleAr = "تم الموافقة على الصورة الشخصية",
                BodyAr = "تم الموافقة على الصورة الشخصية",
                NotificationName = NotificationNames.ProfileImageApproved
            });
        }
    }

}
