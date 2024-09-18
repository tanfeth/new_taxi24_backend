using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi24.Core.Common.Enum;
using Taxi24.Core.Dto;

namespace Taxi24.Core.Entity
{
    public class Car : EntityBase
    {
        public string? CarType { get; set; }
        public string? CarModel { get; set; }
        public int CarYear { get; set; }
        public string? CarCollor { get; set; }
        public string? CarRegistration { get; set; }
        public DateTime? CarRegistrationExpiryDate { get; set; }
        public string? CarInssurance { get; set; }
        public DateTime? CarInssuranceExpiryDate { get; set; }
        public string? PlateNo { get; set; }
        public int DriverId { get; set; }
        public Driver? Driver { get; set; }
        public string? CarDetailsState { get; set; }
        public string? CarRegistrationState { get; set; }
        public string? CarInssuranceState { get; set; }
        public bool IsDefault { get; set; }
        public string? PlateLetterRight { get; set; }
        public string? PlateLetterMiddle { get; set; }
        public string? PlateLetterLeft { get; set; }
        public string? PlateType { get; set; }
        public CarSeatType? CarSeatType { get; set; }
        public virtual IEnumerable<Photos>? Photos { get; set; }

        public string? Eligibility { get; set; }
        public string? EligibilityExpiryDate { get; set; }
        public string? VehicleLicenseExpiryDate { get; set; }
        public string? RejectionReasons { get; set; }
        public string? SequenceNumber { get; set; }

        public int? CarRegistrationModifiedBy { get; set; }
        public int? CarInssuranceModifiedBy { get; set; }
        public User? CarRegistrationModifiedUser { get; set; }
        public User? CarInssuranceModifiedUser { get; set; }

        public int? CarModelId { get; set; }
        public LookupValues? CarModelLookup { get; set; }

        public int? CarTypeId { get; set; }
        public LookupValues? CarTypeLookup { get; set; }
        public string? CarRegistrationStateNote { get; set; }
        public string? CarInssuranceStateNote { get; set; }

        public string? RegistrationModifiedByName
        {
            get
            {
                return CarRegistrationModifiedUser?.Name;
            }
        }

        public string? CarInssuranceModifiedByName
        {
            get
            {
                return CarInssuranceModifiedUser?.Name;
            }
        }

        public string? Plate
        {
            get
            {
                return PlateNo + " " + PlateLetterRight + " " + PlateLetterMiddle + " " + PlateLetterLeft;
            }
        }
        public string RejectionReasonsAr
        {
            get
            {
                return Eligibility == "INVALID" ? Eligibility.Contains("MAX_AGE_NOT_SATISFIED") ? "عمر السائق أكبر من 65 سنة" :
            Eligibility.Contains("DRIVER_IDENTITY_EXPIRED") ? "هوية السائق منتهية الصلاحية" :
            Eligibility.Contains("DRIVER_LICENSE_EXPIRED") ? "هوية السائق منتهية الصلاحية" :
            Eligibility.Contains("DRIVER_LICENSE_NOT_ALLOWED") ? "نوع رخصة القيادة غير مسموح به" :
            Eligibility.Contains("VEHICLE_INSURANCE_EXPIRED") ? "رخصة القيادة منتهية الصلاحية" :
            Eligibility.Contains("VEHICLE_LICENSE_EXPIRED") ? "هوية السائق منتهية الصلاحية" :
            Eligibility.Contains("VEHICLE_NOT_INSURED") ? "المركبة ليس لديها تأمين صالح" :
            Eligibility.Contains("OLD_VEHICLE_MODEL") ? "موديل السيارة أقدم من 5 سنوات" :
            Eligibility.Contains("PERIODIC_INSPECTION_POLICY_EXPIRED") ? "انتهاء الفحص الدوري للمركبة" :
            Eligibility.Contains("DRIVER_FAILED_CRIMINAL_RECORD_CHECK") ? "السائق غير مؤهل لممارسة نشاط " :
            Eligibility.Contains("DRIVER_REJECTED_CRIMINAL_RECORD_CHECK") ? "تم رفض فحص السجل الجنائي من قبل السائق على بوابة أبشر" :
            Eligibility.Contains("CRIMINAL_RECORD_CHECK_PERIOD_EXPIRED") ? "ولم يقبل السائق ولم يرفض المجرم فحص السجل على بوابة أبشر خلال 10 أيام منذ تاريخ بدء الطلب" :
            Eligibility.Contains("VEHICLE_PLATE_TYPE_NOT_ALLOWED") ? "انتهت صلاحية بطاقة تشغيل المركبة. الاستفادة من خدمة التسجيل لتحديث برنامج التشغيل حالة الأهلية." :
            Eligibility.Contains("OPERATION_CARD_EXPIRED") ? "نتهت صلاحية حالة أهلية السائق. الاستفادة من خدمة التسجيل لتحديث برنامج التشغيل حالة الأهلية." :
            Eligibility.Contains("DRIVER_ELIGIBILITY_EXPIRED") ? "السائق ليس لديه سيارة مؤهلة، و يجب على الشركة التحقق من المركبات المرتبطة بها أسباب الرفض للسائق ثم إصلاح السبب " :
            Eligibility.Contains("NO_VALID_OPERATION_CARD_FOUND") ? "انتهت صلاحية المركبة" :
            Eligibility.Contains("NO_PERIODIC_INSPECTION_POLICY_EXPIRY_DATE") ? "لا تحتوي المركبة على بطاقة تشغيل صالحة تجديد الأهلية." :
            Eligibility.Contains("DRIVER_ELIGIBILITY_EXPIRED") ? "المركبة ليس لها تاريخ انتهاء الفحص الدوري تاريخ." :
             "الرجاء مراجعة تاريخ الميلاد و رقم الهوية" : "";
            }
        }

    }



    public sealed class CarMap : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Driver).WithMany(x => x.Cars).HasForeignKey(x => x.DriverId).OnDelete(DeleteBehavior.NoAction);
            builder.Property(x => x.CarType).HasMaxLength(100);
            builder.Property(x => x.CarModel).HasMaxLength(50);
            builder.Property(x => x.CarYear).HasMaxLength(50);
            builder.HasMany(x => x.Photos).WithOne().HasForeignKey(x => x.ModelId);
            ////builder.HasQueryFilter(x => !x.IsDeleted);
            builder.Ignore(x => x.RejectionReasonsAr);
            builder.HasOne(x => x.CarRegistrationModifiedUser).WithMany().HasForeignKey(x => x.CarRegistrationModifiedBy);
            builder.HasOne(x => x.CarInssuranceModifiedUser).WithMany().HasForeignKey(x => x.CarInssuranceModifiedBy);
            builder.Ignore(x => x.Plate);

            builder.HasOne(x => x.CarModelLookup)
                .WithMany()
                .HasForeignKey(x => x.CarModelId);

            builder.HasOne(x => x.CarTypeLookup)
                .WithMany()
                .HasForeignKey(x => x.CarTypeId);


        }
    }
}
