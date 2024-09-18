using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Entity
{
    public class LookupValues : EntityBase
    {
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string Code { get; set; }
        public string? ParentCode { get; set; }
        public int? LookupId { get; set; }
        public Lookup? Lookup { get; set; }
    }

    public sealed class LookupValuesMap : IEntityTypeConfiguration<LookupValues>
    {
        public void Configure(EntityTypeBuilder<LookupValues> builder)
        {
            builder.HasKey(x => x.Id);

            
            builder.HasOne(x => x.Lookup)
                .WithMany(x => x.LookupValues)
                .HasForeignKey(x => x.LookupId);

            ////builder.HasQueryFilter(x => !x.IsDeleted);

    //        builder.HasData(

    //              new LookupValues
    //              {
    //                  Id = 1,
    //                  NameEn = "Toyota",
    //                  NameAr = "تويوتا",
    //                  Code = "TOY",
    //                  LookupId = 1,
    //                  CreationDate = new DateTime(2024, 1, 1),

    //              },
    //              new LookupValues
    //              {
    //                  Id = 103,
    //                  NameEn = "Honda",
    //                  NameAr = "هوندا",
    //                  Code = "HON",
    //                  LookupId = 1,
    //                  CreationDate = new DateTime(2024, 1, 1)
    //              },
    //              new LookupValues
    //              {
    //                  Id = 2,
    //                  NameEn = "Ford",
    //                  NameAr = "فورد",
    //                  Code = "FOR",
    //                  LookupId = 1,
    //                  CreationDate = new DateTime(2024, 1, 1)
    //              },
    //              new LookupValues
    //              {
    //                  Id = 3,
    //                  NameEn = "Chevrolet",
    //                  NameAr = "شيفروليه",
    //                  Code = "CHE",
    //                  LookupId = 1,
    //                  CreationDate = new DateTime(2024, 1, 1)
    //              },
    //              new LookupValues
    //              {
    //                  Id = 4,
    //                  NameEn = "BMW",
    //                  NameAr = "بي ام دبليو",
    //                  Code = "BMW",
    //                  LookupId = 1,
    //                  CreationDate = new DateTime(2024, 1, 1)
    //              },
    //              new LookupValues
    //              {
    //                  Id = 5,
    //                  NameEn = "Mercedes-Benz",
    //                  NameAr = "مرسيدس بنز",
    //                  Code = "MB",
    //                  LookupId = 1,
    //                  CreationDate = new DateTime(2024, 1, 1)
    //              },
    //              new LookupValues
    //              {
    //                  Id = 6,
    //                  NameEn = "Audi",
    //                  NameAr = "أودي",
    //                  Code = "AUD",
    //                  LookupId = 1,
    //                  CreationDate = new DateTime(2024, 1, 1)
    //              },
    //              new LookupValues
    //              {
    //                  Id = 7,
    //                  NameEn = "Nissan",
    //                  NameAr = "نيسان",
    //                  Code = "NIS",
    //                  LookupId = 1,
    //                  CreationDate = new DateTime(2024, 1, 1)
    //              },
    //              new LookupValues
    //              {
    //                  Id = 8,
    //                  NameEn = "Volkswagen",
    //                  NameAr = "فولكس واجن",
    //                  Code = "VW",
    //                  LookupId = 1,
    //                  CreationDate = new DateTime(2024, 1, 1)
    //              },
    //              new LookupValues
    //              {
    //                  Id = 9,
    //                  NameEn = "Hyundai",
    //                  NameAr = "هيونداي",
    //                  Code = "HYU",
    //                  LookupId = 1,
    //                  CreationDate = new DateTime(2024, 1, 1)
    //              },
    //              new LookupValues
    //              {
    //                  Id = 10,
    //                  NameEn = "Kia",
    //                  NameAr = "كيا",
    //                  Code = "KIA",
    //                  LookupId = 1,
    //                  CreationDate = new DateTime(2024, 1, 1)
    //              },
    //              new LookupValues
    //              {
    //                  Id = 11,
    //                  NameEn = "Mazda",
    //                  NameAr = "مازدا",
    //                  Code = "MAZ",
    //                  LookupId = 1,
    //                  CreationDate = new DateTime(2024, 1, 1)
    //              },
    //              new LookupValues
    //              {
    //                  Id = 12,
    //                  NameEn = "Subaru",
    //                  NameAr = "سوبارو",
    //                  Code = "SUB",
    //                  LookupId = 1,
    //                  CreationDate = new DateTime(2024, 1, 1)
    //              },
    //              new LookupValues
    //              {
    //                  Id = 13,
    //                  NameEn = "Porsche",
    //                  NameAr = "بورش",
    //                  Code = "POR",
    //                  LookupId = 1,
    //                  CreationDate = new DateTime(2024, 1, 1)
    //              },
    //              new LookupValues
    //              {
    //                  Id = 14,
    //                  NameEn = "Lexus",
    //                  NameAr = "لكزس",
    //                  Code = "LEX",
    //                  LookupId = 1,
    //                  CreationDate = new DateTime(2024, 1, 1)
    //              },
    //              new LookupValues
    //              {
    //                  Id = 15,
    //                  NameEn = "Volvo",
    //                  NameAr = "فولفو",
    //                  Code = "VOL",
    //                  LookupId = 1,
    //                  CreationDate = new DateTime(2024, 1, 1)
    //              },
    //              new LookupValues
    //              {
    //                  Id = 16,
    //                  NameEn = "Land Rover",
    //                  NameAr = "لاند روڤر",
    //                  Code = "LR",
    //                  LookupId = 1,
    //                  CreationDate = new DateTime(2024, 1, 1)
    //              },
    //              new LookupValues
    //              {
    //                  Id = 17,
    //                  NameEn = "Jaguar",
    //                  NameAr = "جاكوار",
    //                  Code = "JAG",
    //                  LookupId = 1,
    //                  CreationDate = new DateTime(2024, 1, 1)
    //              },
    //              new LookupValues
    //              {
    //                  Id = 104,
    //                  NameEn = "Tesla",
    //                  NameAr = "تسلا",
    //                  Code = "TES",
    //                  LookupId = 1,
    //                  CreationDate = new DateTime(2024, 1, 1)
    //              },
    //              new LookupValues
    //              {
    //                  Id = 18,
    //                  NameEn = "Ferrari",
    //                  NameAr = "فيراري",
    //                  Code = "FER",
    //                  LookupId = 1,
    //                  CreationDate = new DateTime(2024, 1, 1)
    //              },
    //              new LookupValues
    //              {
    //                  Id = 19,
    //                  NameEn = "Maserati",
    //                  NameAr = "مازيراتي",
    //                  Code = "MAS",
    //                  LookupId = 1,
    //                  CreationDate = new DateTime(2024, 1, 1)
    //              },
    //              new LookupValues
    //              {
    //                  Id = 20,
    //                  NameEn = "Bugatti",
    //                  NameAr = "بوغاتي",
    //                  Code = "BUG",
    //                  LookupId = 1,
    //                  CreationDate = new DateTime(2024, 1, 1)
    //              },
    //              new LookupValues
    //              {
    //                  Id = 21,
    //                  NameEn = "McLaren",
    //                  NameAr = "مكلارين",
    //                  Code = "MCL",
    //                  LookupId = 1,
    //                  CreationDate = new DateTime(2024, 1, 1)
    //              },
    //              new LookupValues
    //              {
    //                  Id = 22,
    //                  NameEn = "Rolls-Royce",
    //                  NameAr = "رولز رويس",
    //                  Code = "RR",
    //                  LookupId = 1,
    //                  CreationDate = new DateTime(2024, 1, 1)
    //              },
    //              new LookupValues
    //              {
    //                  Id = 23,
    //                  NameEn = "Bentley",
    //                  NameAr = "بنتلي",
    //                  Code = "BEN",
    //                  LookupId = 1,
    //                  CreationDate = new DateTime(2024, 1, 1)
    //              },
    //              new LookupValues
    //              {
    //                  Id = 24,
    //                  NameEn = "Aston Martin",
    //                  NameAr = "أستون مارتن",
    //                  Code = "AST",
    //                  LookupId = 1,
    //                  CreationDate = new DateTime(2024, 1, 1)
    //              },
    //              new LookupValues
    //              {
    //                  Id = 25,
    //                  NameEn = "Alfa Romeo",
    //                  NameAr = "ألفا روميو",
    //                  Code = "AR",
    //                  LookupId = 1,
    //                  CreationDate = new DateTime(2024, 1, 1)
    //              },


    //        //Toyota
    //        new LookupValues { Id = 26, NameEn = "Camry", NameAr = "كامري", Code = "TOYOTA_CAMRY", ParentCode = "TOY", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 27, NameEn = "Corolla", NameAr = "كورولا", Code = "TOYOTA_COROLLA", ParentCode = "TOY", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 28, NameEn = "Rav4", NameAr = "راف فور", Code = "TOYOTA_RAV4", ParentCode = "TOY", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 29, NameEn = "Prius", NameAr = "بريوس", Code = "TOYOTA_PRIUS", ParentCode = "TOY", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 30, NameEn = "Highlander", NameAr = "هايلاندر", Code = "TOYOTA_HIGHLANDER", ParentCode = "TOY", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 31, NameEn = "Tacoma", NameAr = "تاكوما", Code = "TOYOTA_TACOMA", ParentCode = "TOY", CreationDate = new DateTime(2024, 1, 1) },
    //        // Honda
    //        new LookupValues { Id = 32, NameEn = "Accord", NameAr = "أكورد", Code = "HONDA_ACCORD", ParentCode = "Honda", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 33, NameEn = "Civic", NameAr = "سيفيك", Code = "HONDA_CIVIC", ParentCode = "Honda", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 34, NameEn = "CR-V", NameAr = "سي آر في", Code = "HONDA_CRV", ParentCode = "Honda", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 35, NameEn = "Pilot", NameAr = "بايلوت", Code = "HONDA_PILOT", ParentCode = "Honda", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 36, NameEn = "Odyssey", NameAr = "أوديسي", Code = "HONDA_ODYSSEY", ParentCode = "Honda", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 37, NameEn = "Fit", NameAr = "فت", Code = "HONDA_FIT", ParentCode = "Honda", CreationDate = new DateTime(2024, 1, 1) },
    //        // Nissan
    //        new LookupValues { Id = 38, NameEn = "Altima", NameAr = "ألتيما", Code = "NISSAN_ALTIMA", ParentCode = "Nissan", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 39, NameEn = "Sentra", NameAr = "سنترا", Code = "NISSAN_SENTRA", ParentCode = "Nissan", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 40, NameEn = "Rogue", NameAr = "روغ", Code = "NISSAN_ROGUE", ParentCode = "Nissan", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 41, NameEn = "Maxima", NameAr = "ماكسيما", Code = "NISSAN_MAXIMA", ParentCode = "Nissan", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 42, NameEn = "Pathfinder", NameAr = "باثفايندر", Code = "NISSAN_PATHFINDER", ParentCode = "Nissan", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 43, NameEn = "Titan", NameAr = "تيتان", Code = "NISSAN_TITAN", ParentCode = "Nissan", CreationDate = new DateTime(2024, 1, 1) },

    //        // Ford
    //        new LookupValues { Id = 44, NameEn = "F-150", NameAr = "إف-150", Code = "FORD_F150", ParentCode = "FOR", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 45, NameEn = "Escape", NameAr = "إسكيب", Code = "FORD_ESCAPE", ParentCode = "FOR", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 46, NameEn = "Explorer", NameAr = "إكسبلورر", Code = "FORD_EXPLORER", ParentCode = "FOR", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 47, NameEn = "Focus", NameAr = "فوكس", Code = "FORD_FOCUS", ParentCode = "FOR", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 48, NameEn = "Mustang", NameAr = "موستانغ", Code = "FORD_MUSTANG", ParentCode = "FOR", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 49, NameEn = "Edge", NameAr = "إيدج", Code = "FORD_EDGE", ParentCode = "FOR", CreationDate = new DateTime(2024, 1, 1) },

    //        // Chevrolet
    //        new LookupValues { Id = 50, NameEn = "Silverado", NameAr = "سيلفرادو", Code = "CHEVROLET_SILVERADO", ParentCode = "CHE", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 51, NameEn = "Malibu", NameAr = "ماليبو", Code = "CHEVROLET_MALIBU", ParentCode = "CHE", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 52, NameEn = "Equinox", NameAr = "إيكوينوكس", Code = "CHEVROLET_EQUINOX", ParentCode = "CHE", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 53, NameEn = "Cruze", NameAr = "كروز", Code = "CHEVROLET_CRUZE", ParentCode = "CHE", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 54, NameEn = "Traverse", NameAr = "ترافيرس", Code = "CHEVROLET_TRAVERSE", ParentCode = "CHE", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 55, NameEn = "Suburban", NameAr = "سوبربان", Code = "CHEVROLET_SUBURBAN", ParentCode = "CHE", CreationDate = new DateTime(2024, 1, 1) },

    //        // BMW
    //        new LookupValues { Id = 56, NameEn = "3 Series", NameAr = "سلسلة 3", Code = "BMW_3SERIES", ParentCode = "BMW", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 57, NameEn = "5 Series", NameAr = "سلسلة 5", Code = "BMW_5SERIES", ParentCode = "BMW", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 58, NameEn = "X3", NameAr = "إكس 3", Code = "BMW_X3", ParentCode = "BMW", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 59, NameEn = "X5", NameAr = "إكس 5", Code = "BMW_X5", ParentCode = "BMW", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 60, NameEn = "7 Series", NameAr = "سلسلة 7", Code = "BMW_7SERIES", ParentCode = "BMW", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 61, NameEn = "X1", NameAr = "إكس 1", Code = "BMW_X1", ParentCode = "BMW", CreationDate = new DateTime(2024, 1, 1) },

    //        // MERCEDES
    //        new LookupValues { Id = 62, NameEn = "C-Class", NameAr = "سي-كلاس", Code = "MERCEDES_C_CLASS", ParentCode = "MB", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 63, NameEn = "E-Class", NameAr = "إي-كلاس", Code = "MERCEDES_E_CLASS", ParentCode = "MB", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 64, NameEn = "S-Class", NameAr = "إس-كلاس", Code = "MERCEDES_S_CLASS", ParentCode = "MB", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 65, NameEn = "GLC", NameAr = "جي-إل-سي", Code = "MERCEDES_GLC", ParentCode = "MB", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 66, NameEn = "GLE", NameAr = "جي-إل-إي", Code = "MERCEDES_GLE", ParentCode = "MB", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 67, NameEn = "GLS", NameAr = "جي-إل-إس", Code = "MERCEDES_GLS", ParentCode = "MB", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 68, NameEn = "AMG GT", NameAr = "أي-إم-جي جي تي", Code = "MERCEDES_AMG_GT", ParentCode = "MB", CreationDate = new DateTime(2024, 1, 1) },

    //        //Volkswagen
    //        new LookupValues { Id = 69, NameEn = "Golf", NameAr = "جولف", Code = "VW_GOLF", ParentCode = "VW", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 70, NameEn = "Passat", NameAr = "باسات", Code = "VW_PASSAT", ParentCode = "VW", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 71, NameEn = "Jetta", NameAr = "جيتا", Code = "VW_JETTA", ParentCode = "VW", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 72, NameEn = "Tiguan", NameAr = "تيجوان", Code = "VW_TIGUAN", ParentCode = "VW", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 73, NameEn = "Atlas", NameAr = "أطلس", Code = "VW_ATLAS", ParentCode = "VW", CreationDate = new DateTime(2024, 1, 1) },

    //        //HYUNDAI
    //        new LookupValues { Id = 74, NameEn = "Sonata", NameAr = "سوناتا", Code = "HYUNDAI_SONATA", ParentCode = "HYU", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 75, NameEn = "Elantra", NameAr = "إلانترا", Code = "HYUNDAI_ELANTRA", ParentCode = "HYU", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 76, NameEn = "Tucson", NameAr = "توسان", Code = "HYUNDAI_TUCSON", ParentCode = "HYU", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 77, NameEn = "Santa Fe", NameAr = "سانتا في", Code = "HYUNDAI_SANTA_FE", ParentCode = "HYU", CreationDate = new DateTime(2024, 1, 1) },

    //        //KIA
    //        new LookupValues { Id = 78, NameEn = "Optima", NameAr = "أوبتيما", Code = "KIA_OPTIMA", ParentCode = "KIA", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 79, NameEn = "Sportage", NameAr = "سبورتاج", Code = "KIA_SPORTAGE", ParentCode = "KIA", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 80, NameEn = "Sorento", NameAr = "سورينتو", Code = "KIA_SORENTO", ParentCode = "KIA", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 81, NameEn = "Telluride", NameAr = "تيليورايد", Code = "KIA_TELLURIDE", ParentCode = "KIA", CreationDate = new DateTime(2024, 1, 1) },

    //        //Mazda
    //        new LookupValues { Id = 82, NameEn = "Mazda3", NameAr = "مازدا 3", Code = "MAZDA_3", ParentCode = "MAZ", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 83, NameEn = "Mazda6", NameAr = "مازدا 6", Code = "MAZDA_6", ParentCode = "MAZ", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 84, NameEn = "CX-5", NameAr = "سي إكس-5", Code = "MAZDA_CX5", ParentCode = "MAZ", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 85, NameEn = "CX-9", NameAr = "سي إكس-9", Code = "MAZDA_CX9", ParentCode = "MAZ", CreationDate = new DateTime(2024, 1, 1) },

    //        // Subaru
    //        new LookupValues { Id = 86, NameEn = "Impreza", NameAr = "إمبريزا", Code = "SUBARU_IMPREZA", ParentCode = "SUB", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 87, NameEn = "Legacy", NameAr = "ليجاسي", Code = "SUBARU_LEGACY", ParentCode = "SUB", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 88, NameEn = "Outback", NameAr = "أوتباك", Code = "SUBARU_OUTBACK", ParentCode = "SUB", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 89, NameEn = "Forester", NameAr = "فورستر", Code = "SUBARU_FORESTER", ParentCode = "SUB", CreationDate = new DateTime(2024, 1, 1) },

    //        // Porsche
    //        new LookupValues { Id = 90, NameEn = "911", NameAr = "911", Code = "PORSCHE_911", ParentCode = "POR", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 91, NameEn = "Cayenne", NameAr = "كايين", Code = "PORSCHE_CAYENNE", ParentCode = "POR", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 92, NameEn = "Panamera", NameAr = "باناميرا", Code = "PORSCHE_PANAMERA", ParentCode = "POR", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 93, NameEn = "Macan", NameAr = "ماكان", Code = "PORSCHE_MACAN", ParentCode = "POR", CreationDate = new DateTime(2024, 1, 1) },

    //        // Audi
    //        new LookupValues { Id = 94, NameEn = "A3", NameAr = "أيه 3", Code = "AUDI_A3", ParentCode = "AUD", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 95, NameEn = "A4", NameAr = "أيه 4", Code = "AUDI_A4", ParentCode = "AUD", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 96, NameEn = "A6", NameAr = "أيه 6", Code = "AUDI_A6", ParentCode = "AUD", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 97, NameEn = "Q3", NameAr = "كيو 3", Code = "AUDI_Q3", ParentCode = "AUD", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 98, NameEn = "Q5", NameAr = "كيو 5", Code = "AUDI_Q5", ParentCode = "AUD", CreationDate = new DateTime(2024, 1, 1) },

    //        // Tesla
    //        new LookupValues { Id = 99, NameEn = "Model S", NameAr = "موديل اس", Code = "TESLA_MODEL_S", ParentCode = "TES", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 100, NameEn = "Model 3", NameAr = "موديل 3", Code = "TESLA_MODEL_3", ParentCode = "TES", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 101, NameEn = "Model X", NameAr = "موديل اكس", Code = "TESLA_MODEL_X", ParentCode = "TES", CreationDate = new DateTime(2024, 1, 1) },
    //        new LookupValues { Id = 102, NameEn = "Model Y", NameAr = "موديل واي", Code = "TESLA_MODEL_Y", ParentCode = "TES", CreationDate = new DateTime(2024, 1, 1) }

    //);

            builder.HasData(
  new LookupValues
  {
      Id = 1689,
      NameEn = "Seat",
      NameAr = "Seat",
      Code = "Seat",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },
  new LookupValues
  {
      Id = 1690,
      NameEn = "Acura",
      NameAr = "Acura",
      Code = "Acura",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },
  new LookupValues
  {
      Id = 1691,
      NameEn = "Alfa Romeo",
      NameAr = "Alfa Romeo",
      Code = "Alfa Romeo",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },
  new LookupValues
  {
      Id = 1692,
      NameEn = "AMC",
      NameAr = "AMC",
      Code = "AMC",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },
  new LookupValues
  {
      Id = 1693,
      NameEn = "Aston Martin",
      NameAr = "Aston Martin",
      Code = "Aston Martin",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },
  new LookupValues
  {
      Id = 1694,
      NameEn = "Audi",
      NameAr = "Audi",
      Code = "Audi",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },
  new LookupValues
  {
      Id = 1695,
      NameEn = "Avanti",
      NameAr = "Avanti",
      Code = "Avanti",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },
  new LookupValues
  {
      Id = 1696,
      NameEn = "Bentley",
      NameAr = "Bentley",
      Code = "Bentley",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },
  new LookupValues
  {
      Id = 1697,
      NameEn = "BMW",
      NameAr = "BMW",
      Code = "BMW",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },
  new LookupValues
  {
      Id = 1698,
      NameEn = "Buick",
      NameAr = "Buick",
      Code = "Buick",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },
  new LookupValues
  {
      Id = 1699,
      NameEn = "Cadillac",
      NameAr = "Cadillac",
      Code = "Cadillac",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },
  new LookupValues
  {
      Id = 1700,
      NameEn = "Haval",
      NameAr = "Haval",
      Code = "Haval",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },
  new LookupValues
  {
      Id = 1701,
      NameEn = "Chevrolet",
      NameAr = "Chevrolet",
      Code = "Chevrolet",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },
  new LookupValues
  {
      Id = 1702,
      NameEn = "MG",
      NameAr = "MG",
      Code = "MG",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },
  new LookupValues
  {
      Id = 1703,
      NameEn = "Chery",
      NameAr = "Chery",
      Code = "Chery",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },
  new LookupValues
  {
      Id = 1704,
      NameEn = "Exeed",
      NameAr = "Exeed",
      Code = "Exeed",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },
  new LookupValues
  {
      Id = 1705,
      NameEn = "Jetour",
      NameAr = "Jetour",
      Code = "Jetour",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },
  new LookupValues
  {
      Id = 1706,
      NameEn = "Chrysler",
      NameAr = "Chrysler",
      Code = "Chrysler",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },
  new LookupValues
  {
      Id = 1707,
      NameEn = "Daewoo",
      NameAr = "Daewoo",
      Code = "Daewoo",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },
  new LookupValues
  {
      Id = 1708,
      NameEn = "Daihatsu",
      NameAr = "Daihatsu",
      Code = "Daihatsu",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },
  new LookupValues
  {
      Id = 1709,
      NameEn = "Datsun",
      NameAr = "Datsun",
      Code = "Datsun",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },
  new LookupValues
  {
      Id = 1710,
      NameEn = "DeLorean",
      NameAr = "DeLorean",
      Code = "DeLorean",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },
  new LookupValues
  {
      Id = 1711,
      NameEn = "Dodge",
      NameAr = "Dodge",
      Code = "Dodge",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },
  new LookupValues
  {
      Id = 1712,
      NameEn = "Eagle",
      NameAr = "Eagle",
      Code = "Eagle",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },
  new LookupValues
  {
      Id = 1713,
      NameEn = "Ferrari",
      NameAr = "Ferrari",
      Code = "Ferrari",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },
  new LookupValues
  {
      Id = 1714,
      NameEn = "FIAT",
      NameAr = "FIAT",
      Code = "FIAT",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },
  new LookupValues
  {
      Id = 1715,
      NameEn = "Rover",
      NameAr = "Rover",
      Code = "Rover",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },
  new LookupValues
  {
      Id = 1716,
      NameEn = "Fisker",
      NameAr = "Fisker",
      Code = "Fisker",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },
  new LookupValues
  {
      Id = 1717,
      NameEn = "Ford",
      NameAr = "Ford",
      Code = "Ford",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1718,
      NameEn = "Freightliner",
      NameAr = "Freightliner",
      Code = "Freightliner",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1719,
      NameEn = "Geo",
      NameAr = "Geo",
      Code = "Geo",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1720,
      NameEn = "GMC",
      NameAr = "GMC",
      Code = "GMC",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1721,
      NameEn = "Honda",
      NameAr = "Honda",
      Code = "Honda",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1722,
      NameEn = "HUMMER",
      NameAr = "HUMMER",
      Code = "HUMMER",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1723,
      NameEn = "Hyundai",
      NameAr = "Hyundai",
      Code = "Hyundai",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1724,
      NameEn = "Infiniti",
      NameAr = "Infiniti",
      Code = "Infiniti",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1725,
      NameEn = "Isuzu",
      NameAr = "Isuzu",
      Code = "Isuzu",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1726,
      NameEn = "Jaguar",
      NameAr = "Jaguar",
      Code = "Jaguar",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1727,
      NameEn = "Jeep",
      NameAr = "Jeep",
      Code = "Jeep",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1728,
      NameEn = "Kia",
      NameAr = "Kia",
      Code = "Kia",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1729,
      NameEn = "Lamborghini",
      NameAr = "Lamborghini",
      Code = "Lamborghini",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1730,
      NameEn = "Lancia",
      NameAr = "Lancia",
      Code = "Lancia",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1731,
      NameEn = "Land Rover",
      NameAr = "Land Rover",
      Code = "Land Rover",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1732,
      NameEn = "Lexus",
      NameAr = "Lexus",
      Code = "Lexus",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1733,
      NameEn = "Lincoln",
      NameAr = "Lincoln",
      Code = "Lincoln",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1734,
      NameEn = "Lotus",
      NameAr = "Lotus",
      Code = "Lotus",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1735,
      NameEn = "Maserati",
      NameAr = "Maserati",
      Code = "Maserati",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1736,
      NameEn = "Maybach",
      NameAr = "Maybach",
      Code = "Maybach",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1737,
      NameEn = "Mazda",
      NameAr = "Mazda",
      Code = "Mazda",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1738,
      NameEn = "McLaren",
      NameAr = "McLaren",
      Code = "McLaren",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1739,
      NameEn = "Mercedes-Benz",
      NameAr = "Mercedes-Benz",
      Code = "Mercedes-Benz",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1740,
      NameEn = "Mercury",
      NameAr = "Mercury",
      Code = "Mercury",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1741,
      NameEn = "Merkur",
      NameAr = "Merkur",
      Code = "Merkur",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1742,
      NameEn = "MINI",
      NameAr = "MINI",
      Code = "MINI",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1743,
      NameEn = "Mitsubishi",
      NameAr = "Mitsubishi",
      Code = "Mitsubishi",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1744,
      NameEn = "Nissan",
      NameAr = "Nissan",
      Code = "Nissan",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1745,
      NameEn = "Oldsmobile",
      NameAr = "Oldsmobile",
      Code = "Oldsmobile",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1746,
      NameEn = "Peugeot",
      NameAr = "Peugeot",
      Code = "Peugeot",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1747,
      NameEn = "Plymouth",
      NameAr = "Plymouth",
      Code = "Plymouth",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1748,
      NameEn = "Pontiac",
      NameAr = "Pontiac",
      Code = "Pontiac",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1749,
      NameEn = "Porsche",
      NameAr = "Porsche",
      Code = "Porsche",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1750,
      NameEn = "RAM",
      NameAr = "RAM",
      Code = "RAM",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1751,
      NameEn = "Opel",
      NameAr = "Opel",
      Code = "Opel",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1752,
      NameEn = "Citroën",
      NameAr = "Citroën",
      Code = "Citroën",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1753,
      NameEn = "Renault",
      NameAr = "Renault",
      Code = "Renault",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1754,
      NameEn = "Rolls-Royce",
      NameAr = "Rolls-Royce",
      Code = "Rolls-Royce",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1755,
      NameEn = "Saab",
      NameAr = "Saab",
      Code = "Saab",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1756,
      NameEn = "Saturn",
      NameAr = "Saturn",
      Code = "Saturn",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1757,
      NameEn = "Scion",
      NameAr = "Scion",
      Code = "Scion",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1758,
      NameEn = "smart",
      NameAr = "smart",
      Code = "smart",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1759,
      NameEn = "SRT",
      NameAr = "SRT",
      Code = "SRT",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1760,
      NameEn = "Sterling",
      NameAr = "Sterling",
      Code = "Sterling",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1761,
      NameEn = "Subaru",
      NameAr = "Subaru",
      Code = "Subaru",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1762,
      NameEn = "Suzuki",
      NameAr = "Suzuki",
      Code = "Suzuki",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1763,
      NameEn = "Tesla",
      NameAr = "Tesla",
      Code = "Tesla",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1764,
      NameEn = "Toyota",
      NameAr = "Toyota",
      Code = "Toyota",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1765,
      NameEn = "Triumph",
      NameAr = "Triumph",
      Code = "Triumph",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1766,
      NameEn = "Volkswagen",
      NameAr = "Volkswagen",
      Code = "Volkswagen",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1767,
      NameEn = "Volvo",
      NameAr = "Volvo",
      Code = "Volvo",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1768,
      NameEn = "Yugo",
      NameAr = "Yugo",
      Code = "Yugo",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1770,
      NameEn = "Geely",
      NameAr = "Geely",
      Code = "Geely",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1771,
      NameEn = "JAC",
      NameAr = "JAC",
      Code = "JAC",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1772,
      NameEn = "GAC",
      NameAr = "GAC",
      Code = "GAC",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1773,
      NameEn = "CHANGAN",
      NameAr = "CHANGAN",
      Code = "CHANGAN",
      LookupId = 1,
      CreationDate = new DateTime(2024, 6, 23)
  },


  new LookupValues
  {
      Id = 150,
      NameEn = "Alhambra",
      NameAr = "Alhambra",
      Code = "Alhambra",
      ParentCode = "Seat",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 151,
      NameEn = "Altea",
      NameAr = "Altea",
      Code = "Altea",
      ParentCode = "Seat",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 152,
      NameEn = "Altea XL",
      NameAr = "Altea XL",
      Code = "Altea XL",
      ParentCode = "Seat",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 153,
      NameEn = "Arosa",
      NameAr = "Arosa",
      Code = "Arosa",
      ParentCode = "Seat",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 154,
      NameEn = "Cordoba",
      NameAr = "Cordoba",
      Code = "Cordoba",
      ParentCode = "Seat",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 155,
      NameEn = "Cordoba Vario",
      NameAr = "Cordoba Vario",
      Code = "Cordoba Vario",
      ParentCode = "Seat",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 156,
      NameEn = "Exeo",
      NameAr = "Exeo",
      Code = "Exeo",
      ParentCode = "Seat",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 157,
      NameEn = "Ibiza",
      NameAr = "Ibiza",
      Code = "Ibiza",
      ParentCode = "Seat",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 158,
      NameEn = "Ibiza ST",
      NameAr = "Ibiza ST",
      Code = "Ibiza ST",
      ParentCode = "Seat",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 159,
      NameEn = "Exeo ST",
      NameAr = "Exeo ST",
      Code = "Exeo ST",
      ParentCode = "Seat",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 160,
      NameEn = "Leon",
      NameAr = "Leon",
      Code = "Leon",
      ParentCode = "Seat",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 161,
      NameEn = "Leon ST",
      NameAr = "Leon ST",
      Code = "Leon ST",
      ParentCode = "Seat",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 162,
      NameEn = "Inca",
      NameAr = "Inca",
      Code = "Inca",
      ParentCode = "Seat",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 163,
      NameEn = "Mii",
      NameAr = "Mii",
      Code = "Mii",
      ParentCode = "Seat",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 164,
      NameEn = "Toledo",
      NameAr = "Toledo",
      Code = "Toledo",
      ParentCode = "Seat",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 165,
      NameEn = "2.2CL",
      NameAr = "2.2CL",
      Code = "2.2CL",
      ParentCode = "Acura",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 166,
      NameEn = "2.3CL",
      NameAr = "2.3CL",
      Code = "2.3CL",
      ParentCode = "Acura",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 167,
      NameEn = "3.0CL",
      NameAr = "3.0CL",
      Code = "3.0CL",
      ParentCode = "Acura",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 168,
      NameEn = "3.2CL",
      NameAr = "3.2CL",
      Code = "3.2CL",
      ParentCode = "Acura",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 169,
      NameEn = "ILX",
      NameAr = "ILX",
      Code = "ILX",
      ParentCode = "Acura",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 170,
      NameEn = "Integra",
      NameAr = "Integra",
      Code = "Integra",
      ParentCode = "Acura",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 171,
      NameEn = "Legend",
      NameAr = "Legend",
      Code = "Legend",
      ParentCode = "Acura",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 172,
      NameEn = "MDX",
      NameAr = "MDX",
      Code = "MDX",
      ParentCode = "Acura",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 173,
      NameEn = "NSX",
      NameAr = "NSX",
      Code = "NSX",
      ParentCode = "Acura",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 174,
      NameEn = "RDX",
      NameAr = "RDX",
      Code = "RDX",
      ParentCode = "Acura",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 175,
      NameEn = "3.5 RL",
      NameAr = "3.5 RL",
      Code = "3.5 RL",
      ParentCode = "Acura",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 176,
      NameEn = "RL",
      NameAr = "RL",
      Code = "RL",
      ParentCode = "Acura",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 177,
      NameEn = "RSX",
      NameAr = "RSX",
      Code = "RSX",
      ParentCode = "Acura",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 178,
      NameEn = "SLX",
      NameAr = "SLX",
      Code = "SLX",
      ParentCode = "Acura",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 179,
      NameEn = "2.5TL",
      NameAr = "2.5TL",
      Code = "2.5TL",
      ParentCode = "Acura",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 180,
      NameEn = "3.2TL",
      NameAr = "3.2TL",
      Code = "3.2TL",
      ParentCode = "Acura",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 181,
      NameEn = "TL",
      NameAr = "TL",
      Code = "TL",
      ParentCode = "Acura",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 182,
      NameEn = "TSX",
      NameAr = "TSX",
      Code = "TSX",
      ParentCode = "Acura",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 183,
      NameEn = "Vigor",
      NameAr = "Vigor",
      Code = "Vigor",
      ParentCode = "Acura",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 184,
      NameEn = "ZDX",
      NameAr = "ZDX",
      Code = "ZDX",
      ParentCode = "Acura",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 185,
      NameEn = "164",
      NameAr = "164",
      Code = "164",
      ParentCode = "Alfa Romeo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 186,
      NameEn = "8C Competizione",
      NameAr = "8C Competizione",
      Code = "8C Competizione",
      ParentCode = "Alfa Romeo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 187,
      NameEn = "GTV-6",
      NameAr = "GTV-6",
      Code = "GTV-6",
      ParentCode = "Alfa Romeo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 188,
      NameEn = "Milano",
      NameAr = "Milano",
      Code = "Milano",
      ParentCode = "Alfa Romeo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 189,
      NameEn = "Spider",
      NameAr = "Spider",
      Code = "Spider",
      ParentCode = "Alfa Romeo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 190,
      NameEn = "Alliance",
      NameAr = "Alliance",
      Code = "Alliance",
      ParentCode = "AMC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 191,
      NameEn = "Concord",
      NameAr = "Concord",
      Code = "Concord",
      ParentCode = "AMC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 192,
      NameEn = "Eagle",
      NameAr = "Eagle",
      Code = "Eagle",
      ParentCode = "AMC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 193,
      NameEn = "Encore",
      NameAr = "Encore",
      Code = "Encore",
      ParentCode = "AMC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 194,
      NameEn = "Spirit",
      NameAr = "Spirit",
      Code = "Spirit",
      ParentCode = "AMC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 195,
      NameEn = "DB7",
      NameAr = "DB7",
      Code = "DB7",
      ParentCode = "Aston Martin",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 196,
      NameEn = "DB9",
      NameAr = "DB9",
      Code = "DB9",
      ParentCode = "Aston Martin",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 197,
      NameEn = "DBS",
      NameAr = "DBS",
      Code = "DBS",
      ParentCode = "Aston Martin",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 198,
      NameEn = "Lagonda",
      NameAr = "Lagonda",
      Code = "Lagonda",
      ParentCode = "Aston Martin",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 199,
      NameEn = "Rapide",
      NameAr = "Rapide",
      Code = "Rapide",
      ParentCode = "Aston Martin",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 200,
      NameEn = "V12 Vantage",
      NameAr = "V12 Vantage",
      Code = "V12 Vantage",
      ParentCode = "Aston Martin",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 201,
      NameEn = "V8 Vantage",
      NameAr = "V8 Vantage",
      Code = "V8 Vantage",
      ParentCode = "Aston Martin",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 202,
      NameEn = "Vanquish",
      NameAr = "Vanquish",
      Code = "Vanquish",
      ParentCode = "Aston Martin",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 203,
      NameEn = "Virage",
      NameAr = "Virage",
      Code = "Virage",
      ParentCode = "Aston Martin",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 204,
      NameEn = "100",
      NameAr = "100",
      Code = "100",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 205,
      NameEn = "200",
      NameAr = "200",
      Code = "200",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 206,
      NameEn = "4000",
      NameAr = "4000",
      Code = "4000",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 207,
      NameEn = "5000",
      NameAr = "5000",
      Code = "5000",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 208,
      NameEn = "80",
      NameAr = "80",
      Code = "80",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 209,
      NameEn = "90",
      NameAr = "90",
      Code = "90",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 210,
      NameEn = "A3",
      NameAr = "A3",
      Code = "A3",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 211,
      NameEn = "A4",
      NameAr = "A4",
      Code = "A4",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 212,
      NameEn = "A5",
      NameAr = "A5",
      Code = "A5",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 213,
      NameEn = "A6",
      NameAr = "A6",
      Code = "A6",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 214,
      NameEn = "A7",
      NameAr = "A7",
      Code = "A7",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 215,
      NameEn = "A8",
      NameAr = "A8",
      Code = "A8",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 216,
      NameEn = "allroad",
      NameAr = "allroad",
      Code = "allroad",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 217,
      NameEn = "Cabriolet",
      NameAr = "Cabriolet",
      Code = "Cabriolet",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 218,
      NameEn = "Coupe",
      NameAr = "Coupe",
      Code = "Coupe",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 219,
      NameEn = "Q3",
      NameAr = "Q3",
      Code = "Q3",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 220,
      NameEn = "Q5",
      NameAr = "Q5",
      Code = "Q5",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 221,
      NameEn = "Q7",
      NameAr = "Q7",
      Code = "Q7",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 222,
      NameEn = "Quattro",
      NameAr = "Quattro",
      Code = "Quattro",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 223,
      NameEn = "R8",
      NameAr = "R8",
      Code = "R8",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 224,
      NameEn = "RS 4",
      NameAr = "RS 4",
      Code = "RS 4",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 225,
      NameEn = "RS 5",
      NameAr = "RS 5",
      Code = "RS 5",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 226,
      NameEn = "RS 6",
      NameAr = "RS 6",
      Code = "RS 6",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 227,
      NameEn = "S4",
      NameAr = "S4",
      Code = "S4",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 228,
      NameEn = "S5",
      NameAr = "S5",
      Code = "S5",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 229,
      NameEn = "S6",
      NameAr = "S6",
      Code = "S6",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 230,
      NameEn = "S7",
      NameAr = "S7",
      Code = "S7",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 231,
      NameEn = "S8",
      NameAr = "S8",
      Code = "S8",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 232,
      NameEn = "TT",
      NameAr = "TT",
      Code = "TT",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 233,
      NameEn = "TT RS",
      NameAr = "TT RS",
      Code = "TT RS",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 234,
      NameEn = "TTS",
      NameAr = "TTS",
      Code = "TTS",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 235,
      NameEn = "V8 Quattro",
      NameAr = "V8 Quattro",
      Code = "V8 Quattro",
      ParentCode = "Audi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 236,
      NameEn = "Convertible",
      NameAr = "Convertible",
      Code = "Convertible",
      ParentCode = "Avanti",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 237,
      NameEn = "Coupe",
      NameAr = "Coupe",
      Code = "Coupe",
      ParentCode = "Avanti",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 238,
      NameEn = "Sedan",
      NameAr = "Sedan",
      Code = "Sedan",
      ParentCode = "Avanti",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 239,
      NameEn = "Arnage",
      NameAr = "Arnage",
      Code = "Arnage",
      ParentCode = "Bentley",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 240,
      NameEn = "Azure",
      NameAr = "Azure",
      Code = "Azure",
      ParentCode = "Bentley",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 241,
      NameEn = "Brooklands",
      NameAr = "Brooklands",
      Code = "Brooklands",
      ParentCode = "Bentley",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 242,
      NameEn = "Continental",
      NameAr = "Continental",
      Code = "Continental",
      ParentCode = "Bentley",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 243,
      NameEn = "Corniche",
      NameAr = "Corniche",
      Code = "Corniche",
      ParentCode = "Bentley",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 244,
      NameEn = "Eight",
      NameAr = "Eight",
      Code = "Eight",
      ParentCode = "Bentley",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 245,
      NameEn = "Mulsanne",
      NameAr = "Mulsanne",
      Code = "Mulsanne",
      ParentCode = "Bentley",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 246,
      NameEn = "Turbo R",
      NameAr = "Turbo R",
      Code = "Turbo R",
      ParentCode = "Bentley",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 247,
      NameEn = "128i",
      NameAr = "128i",
      Code = "128i",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 248,
      NameEn = "135i",
      NameAr = "135i",
      Code = "135i",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 249,
      NameEn = "135is",
      NameAr = "135is",
      Code = "135is",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 250,
      NameEn = "318i",
      NameAr = "318i",
      Code = "318i",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 251,
      NameEn = "318iC",
      NameAr = "318iC",
      Code = "318iC",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 252,
      NameEn = "318iS",
      NameAr = "318iS",
      Code = "318iS",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 253,
      NameEn = "318ti",
      NameAr = "318ti",
      Code = "318ti",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 254,
      NameEn = "320i",
      NameAr = "320i",
      Code = "320i",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 255,
      NameEn = "323ci",
      NameAr = "323ci",
      Code = "323ci",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 256,
      NameEn = "323i",
      NameAr = "323i",
      Code = "323i",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 257,
      NameEn = "323is",
      NameAr = "323is",
      Code = "323is",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 258,
      NameEn = "323iT",
      NameAr = "323iT",
      Code = "323iT",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 259,
      NameEn = "325Ci",
      NameAr = "325Ci",
      Code = "325Ci",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 260,
      NameEn = "325e",
      NameAr = "325e",
      Code = "325e",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 261,
      NameEn = "325es",
      NameAr = "325es",
      Code = "325es",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 262,
      NameEn = "325i",
      NameAr = "325i",
      Code = "325i",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 263,
      NameEn = "325is",
      NameAr = "325is",
      Code = "325is",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 264,
      NameEn = "325iX",
      NameAr = "325iX",
      Code = "325iX",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 265,
      NameEn = "325xi",
      NameAr = "325xi",
      Code = "325xi",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 266,
      NameEn = "328Ci",
      NameAr = "328Ci",
      Code = "328Ci",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 267,
      NameEn = "328i",
      NameAr = "328i",
      Code = "328i",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 268,
      NameEn = "328iS",
      NameAr = "328iS",
      Code = "328iS",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 269,
      NameEn = "328xi",
      NameAr = "328xi",
      Code = "328xi",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 270,
      NameEn = "330Ci",
      NameAr = "330Ci",
      Code = "330Ci",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 271,
      NameEn = "330i",
      NameAr = "330i",
      Code = "330i",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 272,
      NameEn = "330xi",
      NameAr = "330xi",
      Code = "330xi",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 273,
      NameEn = "335d",
      NameAr = "335d",
      Code = "335d",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 274,
      NameEn = "335i",
      NameAr = "335i",
      Code = "335i",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 275,
      NameEn = "335is",
      NameAr = "335is",
      Code = "335is",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 276,
      NameEn = "335xi",
      NameAr = "335xi",
      Code = "335xi",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 277,
      NameEn = "ActiveHybrid 3",
      NameAr = "ActiveHybrid 3",
      Code = "ActiveHybrid 3",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 278,
      NameEn = "325",
      NameAr = "325",
      Code = "325",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 279,
      NameEn = "524td",
      NameAr = "524td",
      Code = "524td",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 280,
      NameEn = "525i",
      NameAr = "525i",
      Code = "525i",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 281,
      NameEn = "525xi",
      NameAr = "525xi",
      Code = "525xi",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 282,
      NameEn = "528e",
      NameAr = "528e",
      Code = "528e",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 283,
      NameEn = "528i",
      NameAr = "528i",
      Code = "528i",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 284,
      NameEn = "528iT",
      NameAr = "528iT",
      Code = "528iT",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 285,
      NameEn = "528xi",
      NameAr = "528xi",
      Code = "528xi",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 286,
      NameEn = "530i",
      NameAr = "530i",
      Code = "530i",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 287,
      NameEn = "530iT",
      NameAr = "530iT",
      Code = "530iT",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 288,
      NameEn = "530xi",
      NameAr = "530xi",
      Code = "530xi",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 289,
      NameEn = "533i",
      NameAr = "533i",
      Code = "533i",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 290,
      NameEn = "535i",
      NameAr = "535i",
      Code = "535i",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 291,
      NameEn = "535i Gran Turismo",
      NameAr = "535i Gran Turismo",
      Code = "535i Gran Turismo",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 292,
      NameEn = "535xi",
      NameAr = "535xi",
      Code = "535xi",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 293,
      NameEn = "540i",
      NameAr = "540i",
      Code = "540i",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 294,
      NameEn = "545i",
      NameAr = "545i",
      Code = "545i",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 295,
      NameEn = "550i",
      NameAr = "550i",
      Code = "550i",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 296,
      NameEn = "550i Gran Turismo",
      NameAr = "550i Gran Turismo",
      Code = "550i Gran Turismo",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 297,
      NameEn = "ActiveHybrid 5",
      NameAr = "ActiveHybrid 5",
      Code = "ActiveHybrid 5",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 298,
      NameEn = "633CSi",
      NameAr = "633CSi",
      Code = "633CSi",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 299,
      NameEn = "635CSi",
      NameAr = "635CSi",
      Code = "635CSi",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 300,
      NameEn = "640i",
      NameAr = "640i",
      Code = "640i",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 301,
      NameEn = "640i Gran Coupe",
      NameAr = "640i Gran Coupe",
      Code = "640i Gran Coupe",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 302,
      NameEn = "645Ci",
      NameAr = "645Ci",
      Code = "645Ci",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 303,
      NameEn = "650i",
      NameAr = "650i",
      Code = "650i",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 304,
      NameEn = "650i Gran Coupe",
      NameAr = "650i Gran Coupe",
      Code = "650i Gran Coupe",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 305,
      NameEn = "L6",
      NameAr = "L6",
      Code = "L6",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 306,
      NameEn = "733i",
      NameAr = "733i",
      Code = "733i",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 307,
      NameEn = "735i",
      NameAr = "735i",
      Code = "735i",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 308,
      NameEn = "735iL",
      NameAr = "735iL",
      Code = "735iL",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 309,
      NameEn = "740i",
      NameAr = "740i",
      Code = "740i",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 310,
      NameEn = "740iL",
      NameAr = "740iL",
      Code = "740iL",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 311,
      NameEn = "740Li",
      NameAr = "740Li",
      Code = "740Li",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 312,
      NameEn = "745i",
      NameAr = "745i",
      Code = "745i",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 313,
      NameEn = "745Li",
      NameAr = "745Li",
      Code = "745Li",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 314,
      NameEn = "750i",
      NameAr = "750i",
      Code = "750i",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 315,
      NameEn = "750iL",
      NameAr = "750iL",
      Code = "750iL",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 316,
      NameEn = "750Li",
      NameAr = "750Li",
      Code = "750Li",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 317,
      NameEn = "760i",
      NameAr = "760i",
      Code = "760i",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 318,
      NameEn = "760Li",
      NameAr = "760Li",
      Code = "760Li",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 319,
      NameEn = "ActiveHybrid 7",
      NameAr = "ActiveHybrid 7",
      Code = "ActiveHybrid 7",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 320,
      NameEn = "Alpina B7",
      NameAr = "Alpina B7",
      Code = "Alpina B7",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 321,
      NameEn = "840Ci",
      NameAr = "840Ci",
      Code = "840Ci",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 322,
      NameEn = "850Ci",
      NameAr = "850Ci",
      Code = "850Ci",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 323,
      NameEn = "850CSi",
      NameAr = "850CSi",
      Code = "850CSi",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 324,
      NameEn = "850i",
      NameAr = "850i",
      Code = "850i",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 325,
      NameEn = "L7",
      NameAr = "L7",
      Code = "L7",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 326,
      NameEn = "1 Series M",
      NameAr = "1 Series M",
      Code = "1 Series M",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 327,
      NameEn = "M Coupe",
      NameAr = "M Coupe",
      Code = "M Coupe",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 328,
      NameEn = "M Roadster",
      NameAr = "M Roadster",
      Code = "M Roadster",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 329,
      NameEn = "M3",
      NameAr = "M3",
      Code = "M3",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 330,
      NameEn = "M5",
      NameAr = "M5",
      Code = "M5",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 331,
      NameEn = "M6",
      NameAr = "M6",
      Code = "M6",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 332,
      NameEn = "X5 M",
      NameAr = "X5 M",
      Code = "X5 M",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 333,
      NameEn = "X6 M",
      NameAr = "X6 M",
      Code = "X6 M",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 334,
      NameEn = "ActiveHybrid X6",
      NameAr = "ActiveHybrid X6",
      Code = "ActiveHybrid X6",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 335,
      NameEn = "X1",
      NameAr = "X1",
      Code = "X1",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 336,
      NameEn = "X3",
      NameAr = "X3",
      Code = "X3",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 337,
      NameEn = "X5",
      NameAr = "X5",
      Code = "X5",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 338,
      NameEn = "X6",
      NameAr = "X6",
      Code = "X6",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 339,
      NameEn = "Z3",
      NameAr = "Z3",
      Code = "Z3",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 340,
      NameEn = "Z4",
      NameAr = "Z4",
      Code = "Z4",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 341,
      NameEn = "Z8",
      NameAr = "Z8",
      Code = "Z8",
      ParentCode = "BMW",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 342,
      NameEn = "Century",
      NameAr = "Century",
      Code = "Century",
      ParentCode = "Buick",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 343,
      NameEn = "Electra",
      NameAr = "Electra",
      Code = "Electra",
      ParentCode = "Buick",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 344,
      NameEn = "Enclave",
      NameAr = "Enclave",
      Code = "Enclave",
      ParentCode = "Buick",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 345,
      NameEn = "Encore",
      NameAr = "Encore",
      Code = "Encore",
      ParentCode = "Buick",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 346,
      NameEn = "LaCrosse",
      NameAr = "LaCrosse",
      Code = "LaCrosse",
      ParentCode = "Buick",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 347,
      NameEn = "Le Sabre",
      NameAr = "Le Sabre",
      Code = "Le Sabre",
      ParentCode = "Buick",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 348,
      NameEn = "Lucerne",
      NameAr = "Lucerne",
      Code = "Lucerne",
      ParentCode = "Buick",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 349,
      NameEn = "Park Avenue",
      NameAr = "Park Avenue",
      Code = "Park Avenue",
      ParentCode = "Buick",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 350,
      NameEn = "Rainier",
      NameAr = "Rainier",
      Code = "Rainier",
      ParentCode = "Buick",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 351,
      NameEn = "Reatta",
      NameAr = "Reatta",
      Code = "Reatta",
      ParentCode = "Buick",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 352,
      NameEn = "Regal",
      NameAr = "Regal",
      Code = "Regal",
      ParentCode = "Buick",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 353,
      NameEn = "Rendezvous",
      NameAr = "Rendezvous",
      Code = "Rendezvous",
      ParentCode = "Buick",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 354,
      NameEn = "Riviera",
      NameAr = "Riviera",
      Code = "Riviera",
      ParentCode = "Buick",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 355,
      NameEn = "Roadmaster",
      NameAr = "Roadmaster",
      Code = "Roadmaster",
      ParentCode = "Buick",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 356,
      NameEn = "Skyhawk",
      NameAr = "Skyhawk",
      Code = "Skyhawk",
      ParentCode = "Buick",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 357,
      NameEn = "Skylark",
      NameAr = "Skylark",
      Code = "Skylark",
      ParentCode = "Buick",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 358,
      NameEn = "Somerset",
      NameAr = "Somerset",
      Code = "Somerset",
      ParentCode = "Buick",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 359,
      NameEn = "Terraza",
      NameAr = "Terraza",
      Code = "Terraza",
      ParentCode = "Buick",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 360,
      NameEn = "Verano",
      NameAr = "Verano",
      Code = "Verano",
      ParentCode = "Buick",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 361,
      NameEn = "Allante",
      NameAr = "Allante",
      Code = "Allante",
      ParentCode = "Cadillac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 362,
      NameEn = "ATS",
      NameAr = "ATS",
      Code = "ATS",
      ParentCode = "Cadillac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 363,
      NameEn = "Brougham",
      NameAr = "Brougham",
      Code = "Brougham",
      ParentCode = "Cadillac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 364,
      NameEn = "Catera",
      NameAr = "Catera",
      Code = "Catera",
      ParentCode = "Cadillac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 365,
      NameEn = "Cimarron",
      NameAr = "Cimarron",
      Code = "Cimarron",
      ParentCode = "Cadillac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 366,
      NameEn = "CTS",
      NameAr = "CTS",
      Code = "CTS",
      ParentCode = "Cadillac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 367,
      NameEn = "De Ville",
      NameAr = "De Ville",
      Code = "De Ville",
      ParentCode = "Cadillac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 368,
      NameEn = "DTS",
      NameAr = "DTS",
      Code = "DTS",
      ParentCode = "Cadillac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 369,
      NameEn = "Eldorado",
      NameAr = "Eldorado",
      Code = "Eldorado",
      ParentCode = "Cadillac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 370,
      NameEn = "Escalade",
      NameAr = "Escalade",
      Code = "Escalade",
      ParentCode = "Cadillac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 371,
      NameEn = "Escalade ESV",
      NameAr = "Escalade ESV",
      Code = "Escalade ESV",
      ParentCode = "Cadillac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 372,
      NameEn = "Escalade EXT",
      NameAr = "Escalade EXT",
      Code = "Escalade EXT",
      ParentCode = "Cadillac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 373,
      NameEn = "Fleetwood",
      NameAr = "Fleetwood",
      Code = "Fleetwood",
      ParentCode = "Cadillac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 374,
      NameEn = "Seville",
      NameAr = "Seville",
      Code = "Seville",
      ParentCode = "Cadillac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 375,
      NameEn = "SRX",
      NameAr = "SRX",
      Code = "SRX",
      ParentCode = "Cadillac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 376,
      NameEn = "STS",
      NameAr = "STS",
      Code = "STS",
      ParentCode = "Cadillac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 377,
      NameEn = "XLR",
      NameAr = "XLR",
      Code = "XLR",
      ParentCode = "Cadillac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 378,
      NameEn = "XTS",
      NameAr = "XTS",
      Code = "XTS",
      ParentCode = "Cadillac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 379,
      NameEn = "Big Dog",
      NameAr = "Big Dog",
      Code = "Big Dog",
      ParentCode = "Haval",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 380,
      NameEn = "Chitu",
      NameAr = "Chitu",
      Code = "Chitu",
      ParentCode = "Haval",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 381,
      NameEn = "Cool Dog",
      NameAr = "Cool Dog",
      Code = "Cool Dog",
      ParentCode = "Haval",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 382,
      NameEn = "F5",
      NameAr = "F5",
      Code = "F5",
      ParentCode = "Haval",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 383,
      NameEn = "F7",
      NameAr = "F7",
      Code = "F7",
      ParentCode = "Haval",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 384,
      NameEn = "H1",
      NameAr = "H1",
      Code = "H1",
      ParentCode = "Haval",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 385,
      NameEn = "H2",
      NameAr = "H2",
      Code = "H2",
      ParentCode = "Haval",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 386,
      NameEn = "H2s",
      NameAr = "H2s",
      Code = "H2s",
      ParentCode = "Haval",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 387,
      NameEn = "H4",
      NameAr = "H4",
      Code = "H4",
      ParentCode = "Haval",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 388,
      NameEn = "H5",
      NameAr = "H5",
      Code = "H5",
      ParentCode = "Haval",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 389,
      NameEn = "H6",
      NameAr = "H6",
      Code = "H6",
      ParentCode = "Haval",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 390,
      NameEn = "H6 Coupe",
      NameAr = "H6 Coupe",
      Code = "H6 Coupe",
      ParentCode = "Haval",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 391,
      NameEn = "H7",
      NameAr = "H7",
      Code = "H7",
      ParentCode = "Haval",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 392,
      NameEn = "H8",
      NameAr = "H8",
      Code = "H8",
      ParentCode = "Haval",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 393,
      NameEn = "H9",
      NameAr = "H9",
      Code = "H9",
      ParentCode = "Haval",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 394,
      NameEn = "Jolion",
      NameAr = "Jolion",
      Code = "Jolion",
      ParentCode = "Haval",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 395,
      NameEn = "M6",
      NameAr = "M6",
      Code = "M6",
      ParentCode = "Haval",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 396,
      NameEn = "Raptor",
      NameAr = "Raptor",
      Code = "Raptor",
      ParentCode = "Haval",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 397,
      NameEn = "Shenshou",
      NameAr = "Shenshou",
      Code = "Shenshou",
      ParentCode = "Haval",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 398,
      NameEn = "Xiaolong Max",
      NameAr = "Xiaolong Max",
      Code = "Xiaolong Max",
      ParentCode = "Haval",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 399,
      NameEn = "Astro",
      NameAr = "Astro",
      Code = "Astro",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 400,
      NameEn = "Avalanche",
      NameAr = "Avalanche",
      Code = "Avalanche",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 401,
      NameEn = "Aveo",
      NameAr = "Aveo",
      Code = "Aveo",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 402,
      NameEn = "Aveo5",
      NameAr = "Aveo5",
      Code = "Aveo5",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 403,
      NameEn = "Beretta",
      NameAr = "Beretta",
      Code = "Beretta",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 404,
      NameEn = "Blazer",
      NameAr = "Blazer",
      Code = "Blazer",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 405,
      NameEn = "Camaro",
      NameAr = "Camaro",
      Code = "Camaro",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 406,
      NameEn = "Caprice",
      NameAr = "Caprice",
      Code = "Caprice",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 407,
      NameEn = "Captiva Sport",
      NameAr = "Captiva Sport",
      Code = "Captiva Sport",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 408,
      NameEn = "Cavalier",
      NameAr = "Cavalier",
      Code = "Cavalier",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 409,
      NameEn = "Celebrity",
      NameAr = "Celebrity",
      Code = "Celebrity",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 410,
      NameEn = "Chevette",
      NameAr = "Chevette",
      Code = "Chevette",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 411,
      NameEn = "Citation",
      NameAr = "Citation",
      Code = "Citation",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 412,
      NameEn = "Cobalt",
      NameAr = "Cobalt",
      Code = "Cobalt",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 413,
      NameEn = "Colorado",
      NameAr = "Colorado",
      Code = "Colorado",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 414,
      NameEn = "Corsica",
      NameAr = "Corsica",
      Code = "Corsica",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 415,
      NameEn = "Corvette",
      NameAr = "Corvette",
      Code = "Corvette",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 416,
      NameEn = "Cruze",
      NameAr = "Cruze",
      Code = "Cruze",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 417,
      NameEn = "El Camino",
      NameAr = "El Camino",
      Code = "El Camino",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 418,
      NameEn = "Equinox",
      NameAr = "Equinox",
      Code = "Equinox",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 419,
      NameEn = "Express Van",
      NameAr = "Express Van",
      Code = "Express Van",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 420,
      NameEn = "G Van",
      NameAr = "G Van",
      Code = "G Van",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 421,
      NameEn = "HHR",
      NameAr = "HHR",
      Code = "HHR",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 422,
      NameEn = "Impala",
      NameAr = "Impala",
      Code = "Impala",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 423,
      NameEn = "Kodiak C4500",
      NameAr = "Kodiak C4500",
      Code = "Kodiak C4500",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 424,
      NameEn = "Lumina",
      NameAr = "Lumina",
      Code = "Lumina",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 425,
      NameEn = "Lumina APV",
      NameAr = "Lumina APV",
      Code = "Lumina APV",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 426,
      NameEn = "LUV",
      NameAr = "LUV",
      Code = "LUV",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 427,
      NameEn = "Malibu",
      NameAr = "Malibu",
      Code = "Malibu",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 428,
      NameEn = "Metro",
      NameAr = "Metro",
      Code = "Metro",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 429,
      NameEn = "Monte Carlo",
      NameAr = "Monte Carlo",
      Code = "Monte Carlo",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 430,
      NameEn = "Nova",
      NameAr = "Nova",
      Code = "Nova",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 431,
      NameEn = "Prizm",
      NameAr = "Prizm",
      Code = "Prizm",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 432,
      NameEn = "S10 Blazer",
      NameAr = "S10 Blazer",
      Code = "S10 Blazer",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 433,
      NameEn = "S10 Pickup",
      NameAr = "S10 Pickup",
      Code = "S10 Pickup",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 434,
      NameEn = "Silverado and other C/K1500",
      NameAr = "Silverado and other C/K1500",
      Code = "Silverado and other C/K1500",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 435,
      NameEn = "Silverado and other C/K2500",
      NameAr = "Silverado and other C/K2500",
      Code = "Silverado and other C/K2500",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 436,
      NameEn = "Silverado and other C/K3500",
      NameAr = "Silverado and other C/K3500",
      Code = "Silverado and other C/K3500",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 437,
      NameEn = "Sonic",
      NameAr = "Sonic",
      Code = "Sonic",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 438,
      NameEn = "Spark",
      NameAr = "Spark",
      Code = "Spark",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 439,
      NameEn = "Spectrum",
      NameAr = "Spectrum",
      Code = "Spectrum",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 440,
      NameEn = "Sprint",
      NameAr = "Sprint",
      Code = "Sprint",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 441,
      NameEn = "SSR",
      NameAr = "SSR",
      Code = "SSR",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 442,
      NameEn = "Suburban",
      NameAr = "Suburban",
      Code = "Suburban",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 443,
      NameEn = "Tahoe",
      NameAr = "Tahoe",
      Code = "Tahoe",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 444,
      NameEn = "Tracker",
      NameAr = "Tracker",
      Code = "Tracker",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 445,
      NameEn = "TrailBlazer",
      NameAr = "TrailBlazer",
      Code = "TrailBlazer",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 446,
      NameEn = "TrailBlazer EXT",
      NameAr = "TrailBlazer EXT",
      Code = "TrailBlazer EXT",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 447,
      NameEn = "Traverse",
      NameAr = "Traverse",
      Code = "Traverse",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 448,
      NameEn = "Uplander",
      NameAr = "Uplander",
      Code = "Uplander",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 449,
      NameEn = "Venture",
      NameAr = "Venture",
      Code = "Venture",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 450,
      NameEn = "Volt",
      NameAr = "Volt",
      Code = "Volt",
      ParentCode = "Chevrolet",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 451,
      NameEn = "MG One",
      NameAr = "MG One",
      Code = "MG One",
      ParentCode = "MG",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 452,
      NameEn = "MG3",
      NameAr = "MG3",
      Code = "MG3",
      ParentCode = "MG",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 453,
      NameEn = "MG5",
      NameAr = "MG5",
      Code = "MG5",
      ParentCode = "MG",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 454,
      NameEn = "MG6",
      NameAr = "MG6",
      Code = "MG6",
      ParentCode = "MG",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 455,
      NameEn = "MG7",
      NameAr = "MG7",
      Code = "MG7",
      ParentCode = "MG",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 456,
      NameEn = "MG Astor",
      NameAr = "MG Astor",
      Code = "MG Astor",
      ParentCode = "MG",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 457,
      NameEn = "MG Extender",
      NameAr = "MG Extender",
      Code = "MG Extender",
      ParentCode = "MG",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 458,
      NameEn = "MG GS",
      NameAr = "MG GS",
      Code = "MG GS",
      ParentCode = "MG",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 459,
      NameEn = "MG Hector",
      NameAr = "MG Hector",
      Code = "MG Hector",
      ParentCode = "MG",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 460,
      NameEn = "MG HS",
      NameAr = "MG HS",
      Code = "MG HS",
      ParentCode = "MG",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 461,
      NameEn = "MG GT",
      NameAr = "MG GT",
      Code = "MG GT",
      ParentCode = "MG",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 462,
      NameEn = "MG ZA",
      NameAr = "MG ZA",
      Code = "MG ZA",
      ParentCode = "MG",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 463,
      NameEn = "MG ZB",
      NameAr = "MG ZB",
      Code = "MG ZB",
      ParentCode = "MG",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 464,
      NameEn = "MG ZR",
      NameAr = "MG ZR",
      Code = "MG ZR",
      ParentCode = "MG",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 465,
      NameEn = "MG ZS",
      NameAr = "MG ZS",
      Code = "MG ZS",
      ParentCode = "MG",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 466,
      NameEn = "MG ZT",
      NameAr = "MG ZT",
      Code = "MG ZT",
      ParentCode = "MG",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 467,
      NameEn = "MG XPower SV",
      NameAr = "MG XPower SV",
      Code = "MG XPower SV",
      ParentCode = "MG",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 468,
      NameEn = "MG Pilot",
      NameAr = "MG Pilot",
      Code = "MG Pilot",
      ParentCode = "MG",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 469,
      NameEn = "MG RX5",
      NameAr = "MG RX5",
      Code = "MG RX5",
      ParentCode = "MG",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 470,
      NameEn = "MG RX5 Plus",
      NameAr = "MG RX5 Plus",
      Code = "MG RX5 Plus",
      ParentCode = "MG",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 471,
      NameEn = "MG RX",
      NameAr = "MG RX",
      Code = "MG RX",
      ParentCode = "MG",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 472,
      NameEn = "Arrizo 5",
      NameAr = "Arrizo 5",
      Code = "Arrizo 5",
      ParentCode = "Chery",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 473,
      NameEn = "Arrizo 5 Plus",
      NameAr = "Arrizo 5 Plus",
      Code = "Arrizo 5 Plus",
      ParentCode = "Chery",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 474,
      NameEn = "Arrizo 5 GT",
      NameAr = "Arrizo 5 GT",
      Code = "Arrizo 5 GT",
      ParentCode = "Chery",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 475,
      NameEn = "Arrizo 6",
      NameAr = "Arrizo 6",
      Code = "Arrizo 6",
      ParentCode = "Chery",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 476,
      NameEn = "Chery Arrizo 8",
      NameAr = "Chery Arrizo 8",
      Code = "Chery Arrizo 8",
      ParentCode = "Chery",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 477,
      NameEn = "Chery Tiggo 3",
      NameAr = "Chery Tiggo 3",
      Code = "Chery Tiggo 3",
      ParentCode = "Chery",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 478,
      NameEn = "Chery Tiggo 3x",
      NameAr = "Chery Tiggo 3x",
      Code = "Chery Tiggo 3x",
      ParentCode = "Chery",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 479,
      NameEn = "Chery Tiggo 5",
      NameAr = "Chery Tiggo 5",
      Code = "Chery Tiggo 5",
      ParentCode = "Chery",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 480,
      NameEn = "Chery Tiggo 7",
      NameAr = "Chery Tiggo 7",
      Code = "Chery Tiggo 7",
      ParentCode = "Chery",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 481,
      NameEn = "Chery Tiggo 8",
      NameAr = "Chery Tiggo 8",
      Code = "Chery Tiggo 8",
      ParentCode = "Chery",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 482,
      NameEn = "Chery Omoda 5",
      NameAr = "Chery Omoda 5",
      Code = "Chery Omoda 5",
      ParentCode = "Chery",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 483,
      NameEn = "Chery Explore 06",
      NameAr = "Chery Explore 06",
      Code = "Chery Explore 06",
      ParentCode = "Chery",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 484,
      NameEn = "Chery A13/Fulwin 2",
      NameAr = "Chery A13/Fulwin 2",
      Code = "Chery A13/Fulwin 2",
      ParentCode = "Chery",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 485,
      NameEn = "Chery A11/Fulwin",
      NameAr = "Chery A11/Fulwin",
      Code = "Chery A11/Fulwin",
      ParentCode = "Chery",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 486,
      NameEn = "Chery Arrizo GX",
      NameAr = "Chery Arrizo GX",
      Code = "Chery Arrizo GX",
      ParentCode = "Chery",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 487,
      NameEn = "Chery Arrizo M7",
      NameAr = "Chery Arrizo M7",
      Code = "Chery Arrizo M7",
      ParentCode = "Chery",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 488,
      NameEn = "Chery eQ5",
      NameAr = "Chery eQ5",
      Code = "Chery eQ5",
      ParentCode = "Chery",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 489,
      NameEn = "LX/Zhuifeng",
      NameAr = "LX/Zhuifeng",
      Code = "LX/Zhuifeng",
      ParentCode = "Exeed",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 490,
      NameEn = "Exeed Sterra ES",
      NameAr = "Exeed Sterra ES",
      Code = "Exeed Sterra ES",
      ParentCode = "Exeed",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 491,
      NameEn = "Exeed TXL",
      NameAr = "Exeed TXL",
      Code = "Exeed TXL",
      ParentCode = "Exeed",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 492,
      NameEn = "Exeed RX",
      NameAr = "Exeed RX",
      Code = "Exeed RX",
      ParentCode = "Exeed",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 493,
      NameEn = "Exeed VX",
      NameAr = "Exeed VX",
      Code = "Exeed VX",
      ParentCode = "Exeed",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 494,
      NameEn = "Exeed TX",
      NameAr = "Exeed TX",
      Code = "Exeed TX",
      ParentCode = "Exeed",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 495,
      NameEn = "Jetour Dashing",
      NameAr = "Jetour Dashing",
      Code = "Jetour Dashing",
      ParentCode = "Jetour",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 496,
      NameEn = "Jetour X95",
      NameAr = "Jetour X95",
      Code = "Jetour X95",
      ParentCode = "Jetour",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 497,
      NameEn = "Jetour X90/ X90 Plus",
      NameAr = "Jetour X90/ X90 Plus",
      Code = "Jetour X90/ X90 Plus",
      ParentCode = "Jetour",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 498,
      NameEn = "Jetour X70",
      NameAr = "Jetour X70",
      Code = "Jetour X70",
      ParentCode = "Jetour",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 499,
      NameEn = "200",
      NameAr = "200",
      Code = "200",
      ParentCode = "Chrysler",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 500,
      NameEn = "300",
      NameAr = "300",
      Code = "300",
      ParentCode = "Chrysler",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 501,
      NameEn = "300M",
      NameAr = "300M",
      Code = "300M",
      ParentCode = "Chrysler",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 502,
      NameEn = "Aspen",
      NameAr = "Aspen",
      Code = "Aspen",
      ParentCode = "Chrysler",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 503,
      NameEn = "Caravan",
      NameAr = "Caravan",
      Code = "Caravan",
      ParentCode = "Chrysler",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 504,
      NameEn = "Cirrus",
      NameAr = "Cirrus",
      Code = "Cirrus",
      ParentCode = "Chrysler",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 505,
      NameEn = "Concorde",
      NameAr = "Concorde",
      Code = "Concorde",
      ParentCode = "Chrysler",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 506,
      NameEn = "Conquest",
      NameAr = "Conquest",
      Code = "Conquest",
      ParentCode = "Chrysler",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 507,
      NameEn = "Cordoba",
      NameAr = "Cordoba",
      Code = "Cordoba",
      ParentCode = "Chrysler",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 508,
      NameEn = "Crossfire",
      NameAr = "Crossfire",
      Code = "Crossfire",
      ParentCode = "Chrysler",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 509,
      NameEn = "E Class",
      NameAr = "E Class",
      Code = "E Class",
      ParentCode = "Chrysler",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 510,
      NameEn = "Fifth Avenue",
      NameAr = "Fifth Avenue",
      Code = "Fifth Avenue",
      ParentCode = "Chrysler",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 511,
      NameEn = "Grand Voyager",
      NameAr = "Grand Voyager",
      Code = "Grand Voyager",
      ParentCode = "Chrysler",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 512,
      NameEn = "Imperial",
      NameAr = "Imperial",
      Code = "Imperial",
      ParentCode = "Chrysler",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 513,
      NameEn = "Intrepid",
      NameAr = "Intrepid",
      Code = "Intrepid",
      ParentCode = "Chrysler",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 514,
      NameEn = "Laser",
      NameAr = "Laser",
      Code = "Laser",
      ParentCode = "Chrysler",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 515,
      NameEn = "LeBaron",
      NameAr = "LeBaron",
      Code = "LeBaron",
      ParentCode = "Chrysler",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 516,
      NameEn = "LHS",
      NameAr = "LHS",
      Code = "LHS",
      ParentCode = "Chrysler",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 517,
      NameEn = "Neon",
      NameAr = "Neon",
      Code = "Neon",
      ParentCode = "Chrysler",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 518,
      NameEn = "new Yorker",
      NameAr = "new Yorker",
      Code = "new Yorker",
      ParentCode = "Chrysler",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 519,
      NameEn = "newport",
      NameAr = "newport",
      Code = "newport",
      ParentCode = "Chrysler",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 520,
      NameEn = "Pacifica",
      NameAr = "Pacifica",
      Code = "Pacifica",
      ParentCode = "Chrysler",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 521,
      NameEn = "Prowler",
      NameAr = "Prowler",
      Code = "Prowler",
      ParentCode = "Chrysler",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 522,
      NameEn = "PT Cruiser",
      NameAr = "PT Cruiser",
      Code = "PT Cruiser",
      ParentCode = "Chrysler",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 523,
      NameEn = "Sebring",
      NameAr = "Sebring",
      Code = "Sebring",
      ParentCode = "Chrysler",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 524,
      NameEn = "TC by Maserati",
      NameAr = "TC by Maserati",
      Code = "TC by Maserati",
      ParentCode = "Chrysler",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 525,
      NameEn = "Town &amp; Country",
      NameAr = "Town &amp; Country",
      Code = "Town &amp; Country",
      ParentCode = "Chrysler",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 526,
      NameEn = "Voyager",
      NameAr = "Voyager",
      Code = "Voyager",
      ParentCode = "Chrysler",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 527,
      NameEn = "Lanos",
      NameAr = "Lanos",
      Code = "Lanos",
      ParentCode = "Daewoo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 528,
      NameEn = "Leganza",
      NameAr = "Leganza",
      Code = "Leganza",
      ParentCode = "Daewoo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 529,
      NameEn = "Nubira",
      NameAr = "Nubira",
      Code = "Nubira",
      ParentCode = "Daewoo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 530,
      NameEn = "Charade",
      NameAr = "Charade",
      Code = "Charade",
      ParentCode = "Daihatsu",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 531,
      NameEn = "Rocky",
      NameAr = "Rocky",
      Code = "Rocky",
      ParentCode = "Daihatsu",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 532,
      NameEn = "200SX",
      NameAr = "200SX",
      Code = "200SX",
      ParentCode = "Datsun",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 533,
      NameEn = "210",
      NameAr = "210",
      Code = "210",
      ParentCode = "Datsun",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 534,
      NameEn = "280ZX",
      NameAr = "280ZX",
      Code = "280ZX",
      ParentCode = "Datsun",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 535,
      NameEn = "300ZX",
      NameAr = "300ZX",
      Code = "300ZX",
      ParentCode = "Datsun",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 536,
      NameEn = "310",
      NameAr = "310",
      Code = "310",
      ParentCode = "Datsun",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 537,
      NameEn = "510",
      NameAr = "510",
      Code = "510",
      ParentCode = "Datsun",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 538,
      NameEn = "720",
      NameAr = "720",
      Code = "720",
      ParentCode = "Datsun",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 539,
      NameEn = "810",
      NameAr = "810",
      Code = "810",
      ParentCode = "Datsun",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 540,
      NameEn = "Maxima",
      NameAr = "Maxima",
      Code = "Maxima",
      ParentCode = "Datsun",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 541,
      NameEn = "Pickup",
      NameAr = "Pickup",
      Code = "Pickup",
      ParentCode = "Datsun",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 542,
      NameEn = "Pulsar",
      NameAr = "Pulsar",
      Code = "Pulsar",
      ParentCode = "Datsun",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 543,
      NameEn = "Sentra",
      NameAr = "Sentra",
      Code = "Sentra",
      ParentCode = "Datsun",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 544,
      NameEn = "Stanza",
      NameAr = "Stanza",
      Code = "Stanza",
      ParentCode = "Datsun",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 545,
      NameEn = "DMC-12",
      NameAr = "DMC-12",
      Code = "DMC-12",
      ParentCode = "DeLorean",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 546,
      NameEn = "400",
      NameAr = "400",
      Code = "400",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 547,
      NameEn = "600",
      NameAr = "600",
      Code = "600",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 548,
      NameEn = "Aries",
      NameAr = "Aries",
      Code = "Aries",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 549,
      NameEn = "Avenger",
      NameAr = "Avenger",
      Code = "Avenger",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 550,
      NameEn = "Caliber",
      NameAr = "Caliber",
      Code = "Caliber",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 551,
      NameEn = "Caravan",
      NameAr = "Caravan",
      Code = "Caravan",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 552,
      NameEn = "Challenger",
      NameAr = "Challenger",
      Code = "Challenger",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 553,
      NameEn = "Charger",
      NameAr = "Charger",
      Code = "Charger",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 554,
      NameEn = "Colt",
      NameAr = "Colt",
      Code = "Colt",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 555,
      NameEn = "Conquest",
      NameAr = "Conquest",
      Code = "Conquest",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 556,
      NameEn = "D/W Truck",
      NameAr = "D/W Truck",
      Code = "D/W Truck",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 557,
      NameEn = "Dakota",
      NameAr = "Dakota",
      Code = "Dakota",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 558,
      NameEn = "Dart",
      NameAr = "Dart",
      Code = "Dart",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 559,
      NameEn = "Daytona",
      NameAr = "Daytona",
      Code = "Daytona",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 560,
      NameEn = "Diplomat",
      NameAr = "Diplomat",
      Code = "Diplomat",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 561,
      NameEn = "Durango",
      NameAr = "Durango",
      Code = "Durango",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 562,
      NameEn = "Dynasty",
      NameAr = "Dynasty",
      Code = "Dynasty",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 563,
      NameEn = "Grand Caravan",
      NameAr = "Grand Caravan",
      Code = "Grand Caravan",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 564,
      NameEn = "Intrepid",
      NameAr = "Intrepid",
      Code = "Intrepid",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 565,
      NameEn = "Journey",
      NameAr = "Journey",
      Code = "Journey",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 566,
      NameEn = "Lancer",
      NameAr = "Lancer",
      Code = "Lancer",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 567,
      NameEn = "Magnum",
      NameAr = "Magnum",
      Code = "Magnum",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 568,
      NameEn = "Mirada",
      NameAr = "Mirada",
      Code = "Mirada",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 569,
      NameEn = "Monaco",
      NameAr = "Monaco",
      Code = "Monaco",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 570,
      NameEn = "Neon",
      NameAr = "Neon",
      Code = "Neon",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 571,
      NameEn = "Nitro",
      NameAr = "Nitro",
      Code = "Nitro",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 572,
      NameEn = "Omni",
      NameAr = "Omni",
      Code = "Omni",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 573,
      NameEn = "Raider",
      NameAr = "Raider",
      Code = "Raider",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 574,
      NameEn = "Ram 1500 Truck",
      NameAr = "Ram 1500 Truck",
      Code = "Ram 1500 Truck",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 575,
      NameEn = "Ram 2500 Truck",
      NameAr = "Ram 2500 Truck",
      Code = "Ram 2500 Truck",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 576,
      NameEn = "Ram 3500 Truck",
      NameAr = "Ram 3500 Truck",
      Code = "Ram 3500 Truck",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 577,
      NameEn = "Ram 4500 Truck",
      NameAr = "Ram 4500 Truck",
      Code = "Ram 4500 Truck",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 578,
      NameEn = "Ram 50 Truck",
      NameAr = "Ram 50 Truck",
      Code = "Ram 50 Truck",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 579,
      NameEn = "RAM C/V",
      NameAr = "RAM C/V",
      Code = "RAM C/V",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 580,
      NameEn = "Ram SRT-10",
      NameAr = "Ram SRT-10",
      Code = "Ram SRT-10",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 581,
      NameEn = "Ram Van",
      NameAr = "Ram Van",
      Code = "Ram Van",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 582,
      NameEn = "Ram Wagon",
      NameAr = "Ram Wagon",
      Code = "Ram Wagon",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 583,
      NameEn = "Ramcharger",
      NameAr = "Ramcharger",
      Code = "Ramcharger",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 584,
      NameEn = "Rampage",
      NameAr = "Rampage",
      Code = "Rampage",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 585,
      NameEn = "Shadow",
      NameAr = "Shadow",
      Code = "Shadow",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 586,
      NameEn = "Spirit",
      NameAr = "Spirit",
      Code = "Spirit",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 587,
      NameEn = "Sprinter",
      NameAr = "Sprinter",
      Code = "Sprinter",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 588,
      NameEn = "SRT-4",
      NameAr = "SRT-4",
      Code = "SRT-4",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 589,
      NameEn = "St. Regis",
      NameAr = "St. Regis",
      Code = "St. Regis",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 590,
      NameEn = "Stealth",
      NameAr = "Stealth",
      Code = "Stealth",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 591,
      NameEn = "Stratus",
      NameAr = "Stratus",
      Code = "Stratus",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 592,
      NameEn = "Viper",
      NameAr = "Viper",
      Code = "Viper",
      ParentCode = "Dodge",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 593,
      NameEn = "Medallion",
      NameAr = "Medallion",
      Code = "Medallion",
      ParentCode = "Eagle",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 594,
      NameEn = "Premier",
      NameAr = "Premier",
      Code = "Premier",
      ParentCode = "Eagle",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 595,
      NameEn = "Summit",
      NameAr = "Summit",
      Code = "Summit",
      ParentCode = "Eagle",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 596,
      NameEn = "Talon",
      NameAr = "Talon",
      Code = "Talon",
      ParentCode = "Eagle",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 597,
      NameEn = "Vision",
      NameAr = "Vision",
      Code = "Vision",
      ParentCode = "Eagle",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 598,
      NameEn = "308 GTB Quattrovalvole",
      NameAr = "308 GTB Quattrovalvole",
      Code = "308 GTB Quattrovalvole",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 599,
      NameEn = "308 GTBI",
      NameAr = "308 GTBI",
      Code = "308 GTBI",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 600,
      NameEn = "308 GTS Quattrovalvole",
      NameAr = "308 GTS Quattrovalvole",
      Code = "308 GTS Quattrovalvole",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 601,
      NameEn = "308 GTSI",
      NameAr = "308 GTSI",
      Code = "308 GTSI",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 602,
      NameEn = "328 GTB",
      NameAr = "328 GTB",
      Code = "328 GTB",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 603,
      NameEn = "328 GTS",
      NameAr = "328 GTS",
      Code = "328 GTS",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 604,
      NameEn = "348 GTB",
      NameAr = "348 GTB",
      Code = "348 GTB",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 605,
      NameEn = "348 GTS",
      NameAr = "348 GTS",
      Code = "348 GTS",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 606,
      NameEn = "348 Spider",
      NameAr = "348 Spider",
      Code = "348 Spider",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 607,
      NameEn = "348 TB",
      NameAr = "348 TB",
      Code = "348 TB",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 608,
      NameEn = "348 TS",
      NameAr = "348 TS",
      Code = "348 TS",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 609,
      NameEn = "360",
      NameAr = "360",
      Code = "360",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 610,
      NameEn = "456 GT",
      NameAr = "456 GT",
      Code = "456 GT",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 611,
      NameEn = "456M GT",
      NameAr = "456M GT",
      Code = "456M GT",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 612,
      NameEn = "458 Italia",
      NameAr = "458 Italia",
      Code = "458 Italia",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 613,
      NameEn = "512 BBi",
      NameAr = "512 BBi",
      Code = "512 BBi",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 614,
      NameEn = "512M",
      NameAr = "512M",
      Code = "512M",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 615,
      NameEn = "512TR",
      NameAr = "512TR",
      Code = "512TR",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 616,
      NameEn = "550 Maranello",
      NameAr = "550 Maranello",
      Code = "550 Maranello",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 617,
      NameEn = "575M Maranello",
      NameAr = "575M Maranello",
      Code = "575M Maranello",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 618,
      NameEn = "599 GTB Fiorano",
      NameAr = "599 GTB Fiorano",
      Code = "599 GTB Fiorano",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 619,
      NameEn = "599 GTO",
      NameAr = "599 GTO",
      Code = "599 GTO",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 620,
      NameEn = "612 Scaglietti",
      NameAr = "612 Scaglietti",
      Code = "612 Scaglietti",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 621,
      NameEn = "California",
      NameAr = "California",
      Code = "California",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 622,
      NameEn = "Enzo",
      NameAr = "Enzo",
      Code = "Enzo",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 623,
      NameEn = "F355",
      NameAr = "F355",
      Code = "F355",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 624,
      NameEn = "F40",
      NameAr = "F40",
      Code = "F40",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 625,
      NameEn = "F430",
      NameAr = "F430",
      Code = "F430",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 626,
      NameEn = "F50",
      NameAr = "F50",
      Code = "F50",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 627,
      NameEn = "FF",
      NameAr = "FF",
      Code = "FF",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 628,
      NameEn = "Mondial",
      NameAr = "Mondial",
      Code = "Mondial",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 629,
      NameEn = "Testarossa",
      NameAr = "Testarossa",
      Code = "Testarossa",
      ParentCode = "Ferrari",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 630,
      NameEn = "2000 Spider",
      NameAr = "2000 Spider",
      Code = "2000 Spider",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 631,
      NameEn = "500",
      NameAr = "500",
      Code = "500",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 632,
      NameEn = "Bertone X1/9",
      NameAr = "Bertone X1/9",
      Code = "Bertone X1/9",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 633,
      NameEn = "Brava",
      NameAr = "Brava",
      Code = "Brava",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 634,
      NameEn = "Tipo",
      NameAr = "Tipo",
      Code = "Tipo",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 635,
      NameEn = "Florino",
      NameAr = "Florino",
      Code = "Florino",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 636,
      NameEn = "Florino Combi",
      NameAr = "Florino Combi",
      Code = "Florino Combi",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 637,
      NameEn = "Freemont",
      NameAr = "Freemont",
      Code = "Freemont",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 638,
      NameEn = "Grande Punto",
      NameAr = "Grande Punto",
      Code = "Grande Punto",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 639,
      NameEn = "Idea",
      NameAr = "Idea",
      Code = "Idea",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 640,
      NameEn = "Linea",
      NameAr = "Linea",
      Code = "Linea",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 641,
      NameEn = "Marea",
      NameAr = "Marea",
      Code = "Marea",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 642,
      NameEn = "Marea Weekend",
      NameAr = "Marea Weekend",
      Code = "Marea Weekend",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 643,
      NameEn = "Multipla",
      NameAr = "Multipla",
      Code = "Multipla",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 644,
      NameEn = "Palio Weekend",
      NameAr = "Palio Weekend",
      Code = "Palio Weekend",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 645,
      NameEn = "Panda",
      NameAr = "Panda",
      Code = "Panda",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 646,
      NameEn = "Panda Van",
      NameAr = "Panda Van",
      Code = "Panda Van",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 647,
      NameEn = "Punto",
      NameAr = "Punto",
      Code = "Punto",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 648,
      NameEn = "Punto Cabriolet",
      NameAr = "Punto Cabriolet",
      Code = "Punto Cabriolet",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 649,
      NameEn = "Punto Evo",
      NameAr = "Punto Evo",
      Code = "Punto Evo",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 650,
      NameEn = "Punto Van",
      NameAr = "Punto Van",
      Code = "Punto Van",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 651,
      NameEn = "Qubo",
      NameAr = "Qubo",
      Code = "Qubo",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 652,
      NameEn = "Scudo",
      NameAr = "Scudo",
      Code = "Scudo",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 653,
      NameEn = "Scudo Van",
      NameAr = "Scudo Van",
      Code = "Scudo Van",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 654,
      NameEn = "Scudo Kombi",
      NameAr = "Scudo Kombi",
      Code = "Scudo Kombi",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 655,
      NameEn = "Sedici",
      NameAr = "Sedici",
      Code = "Sedici",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 656,
      NameEn = "Seicento",
      NameAr = "Seicento",
      Code = "Seicento",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 657,
      NameEn = "Stilo",
      NameAr = "Stilo",
      Code = "Stilo",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 658,
      NameEn = "Stilo Multiwagon",
      NameAr = "Stilo Multiwagon",
      Code = "Stilo Multiwagon",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 659,
      NameEn = "Strada",
      NameAr = "Strada",
      Code = "Strada",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 660,
      NameEn = "Talento",
      NameAr = "Talento",
      Code = "Talento",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 662,
      NameEn = "Ulysse",
      NameAr = "Ulysse",
      Code = "Ulysse",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 663,
      NameEn = "Uno",
      NameAr = "Uno",
      Code = "Uno",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 664,
      NameEn = "Pininfarina Spider",
      NameAr = "Pininfarina Spider",
      Code = "Pininfarina Spider",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 666,
      NameEn = "X1/9",
      NameAr = "X1/9",
      Code = "X1/9",
      ParentCode = "FIAT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 667,
      NameEn = "200",
      NameAr = "200",
      Code = "200",
      ParentCode = "Rover",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 668,
      NameEn = "214",
      NameAr = "214",
      Code = "214",
      ParentCode = "Rover",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 669,
      NameEn = "218",
      NameAr = "218",
      Code = "218",
      ParentCode = "Rover",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 670,
      NameEn = "25",
      NameAr = "25",
      Code = "25",
      ParentCode = "Rover",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 671,
      NameEn = "400",
      NameAr = "400",
      Code = "400",
      ParentCode = "Rover",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 672,
      NameEn = "414",
      NameAr = "414",
      Code = "414",
      ParentCode = "Rover",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 673,
      NameEn = "416",
      NameAr = "416",
      Code = "416",
      ParentCode = "Rover",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 674,
      NameEn = "620",
      NameAr = "620",
      Code = "620",
      ParentCode = "Rover",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 675,
      NameEn = "75",
      NameAr = "75",
      Code = "75",
      ParentCode = "Rover",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 676,
      NameEn = "Karma",
      NameAr = "Karma",
      Code = "Karma",
      ParentCode = "Fisker",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 677,
      NameEn = "Aerostar",
      NameAr = "Aerostar",
      Code = "Aerostar",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 678,
      NameEn = "Aspire",
      NameAr = "Aspire",
      Code = "Aspire",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 679,
      NameEn = "Bronco",
      NameAr = "Bronco",
      Code = "Bronco",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 680,
      NameEn = "Bronco II",
      NameAr = "Bronco II",
      Code = "Bronco II",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 681,
      NameEn = "C-MAX",
      NameAr = "C-MAX",
      Code = "C-MAX",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 682,
      NameEn = "Club Wagon",
      NameAr = "Club Wagon",
      Code = "Club Wagon",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 683,
      NameEn = "Contour",
      NameAr = "Contour",
      Code = "Contour",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 684,
      NameEn = "Courier",
      NameAr = "Courier",
      Code = "Courier",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 685,
      NameEn = "Crown Victoria",
      NameAr = "Crown Victoria",
      Code = "Crown Victoria",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 686,
      NameEn = "E-150 and Econoline 150",
      NameAr = "E-150 and Econoline 150",
      Code = "E-150 and Econoline 150",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 687,
      NameEn = "E-250 and Econoline 250",
      NameAr = "E-250 and Econoline 250",
      Code = "E-250 and Econoline 250",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 688,
      NameEn = "E-350 and Econoline 350",
      NameAr = "E-350 and Econoline 350",
      Code = "E-350 and Econoline 350",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 689,
      NameEn = "Edge",
      NameAr = "Edge",
      Code = "Edge",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 690,
      NameEn = "Escape",
      NameAr = "Escape",
      Code = "Escape",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 691,
      NameEn = "Escort",
      NameAr = "Escort",
      Code = "Escort",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 692,
      NameEn = "Excursion",
      NameAr = "Excursion",
      Code = "Excursion",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 693,
      NameEn = "EXP",
      NameAr = "EXP",
      Code = "EXP",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 694,
      NameEn = "Expedition",
      NameAr = "Expedition",
      Code = "Expedition",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 695,
      NameEn = "Expedition EL",
      NameAr = "Expedition EL",
      Code = "Expedition EL",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 696,
      NameEn = "Explorer",
      NameAr = "Explorer",
      Code = "Explorer",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 697,
      NameEn = "Explorer Sport Trac",
      NameAr = "Explorer Sport Trac",
      Code = "Explorer Sport Trac",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 698,
      NameEn = "F100",
      NameAr = "F100",
      Code = "F100",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 699,
      NameEn = "F150",
      NameAr = "F150",
      Code = "F150",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 700,
      NameEn = "F250",
      NameAr = "F250",
      Code = "F250",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 701,
      NameEn = "F350",
      NameAr = "F350",
      Code = "F350",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 702,
      NameEn = "F450",
      NameAr = "F450",
      Code = "F450",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 703,
      NameEn = "Fairmont",
      NameAr = "Fairmont",
      Code = "Fairmont",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 704,
      NameEn = "Festiva",
      NameAr = "Festiva",
      Code = "Festiva",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 705,
      NameEn = "Fiesta",
      NameAr = "Fiesta",
      Code = "Fiesta",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 706,
      NameEn = "Five Hundred",
      NameAr = "Five Hundred",
      Code = "Five Hundred",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 707,
      NameEn = "Flex",
      NameAr = "Flex",
      Code = "Flex",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 708,
      NameEn = "Focus",
      NameAr = "Focus",
      Code = "Focus",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 709,
      NameEn = "Freestar",
      NameAr = "Freestar",
      Code = "Freestar",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 710,
      NameEn = "Freestyle",
      NameAr = "Freestyle",
      Code = "Freestyle",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 711,
      NameEn = "Fusion",
      NameAr = "Fusion",
      Code = "Fusion",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 712,
      NameEn = "Granada",
      NameAr = "Granada",
      Code = "Granada",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 713,
      NameEn = "GT",
      NameAr = "GT",
      Code = "GT",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 714,
      NameEn = "LTD",
      NameAr = "LTD",
      Code = "LTD",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 715,
      NameEn = "Mustang",
      NameAr = "Mustang",
      Code = "Mustang",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 716,
      NameEn = "Probe",
      NameAr = "Probe",
      Code = "Probe",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 717,
      NameEn = "Ranger",
      NameAr = "Ranger",
      Code = "Ranger",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 718,
      NameEn = "Taurus",
      NameAr = "Taurus",
      Code = "Taurus",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 719,
      NameEn = "Taurus X",
      NameAr = "Taurus X",
      Code = "Taurus X",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 720,
      NameEn = "Tempo",
      NameAr = "Tempo",
      Code = "Tempo",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 721,
      NameEn = "Thunderbird",
      NameAr = "Thunderbird",
      Code = "Thunderbird",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 722,
      NameEn = "Transit Connect",
      NameAr = "Transit Connect",
      Code = "Transit Connect",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 723,
      NameEn = "Windstar",
      NameAr = "Windstar",
      Code = "Windstar",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 724,
      NameEn = "ZX2 Escort",
      NameAr = "ZX2 Escort",
      Code = "ZX2 Escort",
      ParentCode = "Ford",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 725,
      NameEn = "Sprinter",
      NameAr = "Sprinter",
      Code = "Sprinter",
      ParentCode = "Freightliner",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 726,
      NameEn = "Metro",
      NameAr = "Metro",
      Code = "Metro",
      ParentCode = "Geo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 727,
      NameEn = "Prizm",
      NameAr = "Prizm",
      Code = "Prizm",
      ParentCode = "Geo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 728,
      NameEn = "Spectrum",
      NameAr = "Spectrum",
      Code = "Spectrum",
      ParentCode = "Geo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 729,
      NameEn = "Storm",
      NameAr = "Storm",
      Code = "Storm",
      ParentCode = "Geo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 730,
      NameEn = "Tracker",
      NameAr = "Tracker",
      Code = "Tracker",
      ParentCode = "Geo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 731,
      NameEn = "Acadia",
      NameAr = "Acadia",
      Code = "Acadia",
      ParentCode = "GMC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 732,
      NameEn = "Caballero",
      NameAr = "Caballero",
      Code = "Caballero",
      ParentCode = "GMC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 733,
      NameEn = "Canyon",
      NameAr = "Canyon",
      Code = "Canyon",
      ParentCode = "GMC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 734,
      NameEn = "Envoy",
      NameAr = "Envoy",
      Code = "Envoy",
      ParentCode = "GMC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 735,
      NameEn = "Envoy XL",
      NameAr = "Envoy XL",
      Code = "Envoy XL",
      ParentCode = "GMC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 736,
      NameEn = "Envoy XUV",
      NameAr = "Envoy XUV",
      Code = "Envoy XUV",
      ParentCode = "GMC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 737,
      NameEn = "Jimmy",
      NameAr = "Jimmy",
      Code = "Jimmy",
      ParentCode = "GMC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 738,
      NameEn = "Rally Wagon",
      NameAr = "Rally Wagon",
      Code = "Rally Wagon",
      ParentCode = "GMC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 739,
      NameEn = "S15 Jimmy",
      NameAr = "S15 Jimmy",
      Code = "S15 Jimmy",
      ParentCode = "GMC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 740,
      NameEn = "S15 Pickup",
      NameAr = "S15 Pickup",
      Code = "S15 Pickup",
      ParentCode = "GMC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 741,
      NameEn = "Safari",
      NameAr = "Safari",
      Code = "Safari",
      ParentCode = "GMC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 742,
      NameEn = "Savana",
      NameAr = "Savana",
      Code = "Savana",
      ParentCode = "GMC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 743,
      NameEn = "Sierra C/K1500",
      NameAr = "Sierra C/K1500",
      Code = "Sierra C/K1500",
      ParentCode = "GMC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 744,
      NameEn = "Sierra C/K2500",
      NameAr = "Sierra C/K2500",
      Code = "Sierra C/K2500",
      ParentCode = "GMC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 745,
      NameEn = "Sierra C/K3500",
      NameAr = "Sierra C/K3500",
      Code = "Sierra C/K3500",
      ParentCode = "GMC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 746,
      NameEn = "Sonoma",
      NameAr = "Sonoma",
      Code = "Sonoma",
      ParentCode = "GMC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 747,
      NameEn = "Suburban",
      NameAr = "Suburban",
      Code = "Suburban",
      ParentCode = "GMC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 748,
      NameEn = "Syclone",
      NameAr = "Syclone",
      Code = "Syclone",
      ParentCode = "GMC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 749,
      NameEn = "Terrain",
      NameAr = "Terrain",
      Code = "Terrain",
      ParentCode = "GMC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 750,
      NameEn = "TopKick C4500",
      NameAr = "TopKick C4500",
      Code = "TopKick C4500",
      ParentCode = "GMC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 751,
      NameEn = "Typhoon",
      NameAr = "Typhoon",
      Code = "Typhoon",
      ParentCode = "GMC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 752,
      NameEn = "Vandura",
      NameAr = "Vandura",
      Code = "Vandura",
      ParentCode = "GMC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 753,
      NameEn = "Yukon",
      NameAr = "Yukon",
      Code = "Yukon",
      ParentCode = "GMC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 754,
      NameEn = "Yukon XL",
      NameAr = "Yukon XL",
      Code = "Yukon XL",
      ParentCode = "GMC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 755,
      NameEn = "Accord",
      NameAr = "Accord",
      Code = "Accord",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 756,
      NameEn = "Civic",
      NameAr = "Civic",
      Code = "Civic",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 757,
      NameEn = "CR-V",
      NameAr = "CR-V",
      Code = "CR-V",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 758,
      NameEn = "CR-Z",
      NameAr = "CR-Z",
      Code = "CR-Z",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 759,
      NameEn = "CRX",
      NameAr = "CRX",
      Code = "CRX",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 760,
      NameEn = "Accord Crosstour",
      NameAr = "Accord Crosstour",
      Code = "Accord Crosstour",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 761,
      NameEn = "Crosstour",
      NameAr = "Crosstour",
      Code = "Crosstour",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 762,
      NameEn = "Del Sol",
      NameAr = "Del Sol",
      Code = "Del Sol",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 763,
      NameEn = "Element",
      NameAr = "Element",
      Code = "Element",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 764,
      NameEn = "Fit",
      NameAr = "Fit",
      Code = "Fit",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 765,
      NameEn = "Insight",
      NameAr = "Insight",
      Code = "Insight",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 766,
      NameEn = "Odyssey",
      NameAr = "Odyssey",
      Code = "Odyssey",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 767,
      NameEn = "Passport",
      NameAr = "Passport",
      Code = "Passport",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 768,
      NameEn = "Pilot",
      NameAr = "Pilot",
      Code = "Pilot",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 769,
      NameEn = "Prelude",
      NameAr = "Prelude",
      Code = "Prelude",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 770,
      NameEn = "Ridgeline",
      NameAr = "Ridgeline",
      Code = "Ridgeline",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 771,
      NameEn = "S2000",
      NameAr = "S2000",
      Code = "S2000",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 772,
      NameEn = "100",
      NameAr = "100",
      Code = "100",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 773,
      NameEn = "100 Avant",
      NameAr = "100 Avant",
      Code = "100 Avant",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 774,
      NameEn = "80",
      NameAr = "80",
      Code = "80",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 775,
      NameEn = "80 Avant",
      NameAr = "80 Avant",
      Code = "80 Avant",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 776,
      NameEn = "80 Cabrio",
      NameAr = "80 Cabrio",
      Code = "80 Cabrio",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 777,
      NameEn = "90",
      NameAr = "90",
      Code = "90",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 778,
      NameEn = "A1",
      NameAr = "A1",
      Code = "A1",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 779,
      NameEn = "A2",
      NameAr = "A2",
      Code = "A2",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 780,
      NameEn = "A3",
      NameAr = "A3",
      Code = "A3",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 781,
      NameEn = "A3 Cabriolet",
      NameAr = "A3 Cabriolet",
      Code = "A3 Cabriolet",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 782,
      NameEn = "A3 Limuzina",
      NameAr = "A3 Limuzina",
      Code = "A3 Limuzina",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 783,
      NameEn = "A3 Sportback",
      NameAr = "A3 Sportback",
      Code = "A3 Sportback",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 784,
      NameEn = "A4",
      NameAr = "A4",
      Code = "A4",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 785,
      NameEn = "A4 Allroad",
      NameAr = "A4 Allroad",
      Code = "A4 Allroad",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 786,
      NameEn = "A4 Avant",
      NameAr = "A4 Avant",
      Code = "A4 Avant",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 787,
      NameEn = "A4 Cabriolet",
      NameAr = "A4 Cabriolet",
      Code = "A4 Cabriolet",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 788,
      NameEn = "A5",
      NameAr = "A5",
      Code = "A5",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 789,
      NameEn = "A5 Cabriolet",
      NameAr = "A5 Cabriolet",
      Code = "A5 Cabriolet",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 790,
      NameEn = "A5 Sportback",
      NameAr = "A5 Sportback",
      Code = "A5 Sportback",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 791,
      NameEn = "A6",
      NameAr = "A6",
      Code = "A6",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 792,
      NameEn = "A6 Allroad",
      NameAr = "A6 Allroad",
      Code = "A6 Allroad",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 793,
      NameEn = "A6 Avant",
      NameAr = "A6 Avant",
      Code = "A6 Avant",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 794,
      NameEn = "A7",
      NameAr = "A7",
      Code = "A7",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 795,
      NameEn = "A8",
      NameAr = "A8",
      Code = "A8",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 796,
      NameEn = "A8 Long",
      NameAr = "A8 Long",
      Code = "A8 Long",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 797,
      NameEn = "Q3",
      NameAr = "Q3",
      Code = "Q3",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 798,
      NameEn = "Q5",
      NameAr = "Q5",
      Code = "Q5",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 799,
      NameEn = "Q7",
      NameAr = "Q7",
      Code = "Q7",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 800,
      NameEn = "R8",
      NameAr = "R8",
      Code = "R8",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 801,
      NameEn = "RS4 Cabriolet",
      NameAr = "RS4 Cabriolet",
      Code = "RS4 Cabriolet",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 802,
      NameEn = "RS4/RS4 Avant",
      NameAr = "RS4/RS4 Avant",
      Code = "RS4/RS4 Avant",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 803,
      NameEn = "RS5",
      NameAr = "RS5",
      Code = "RS5",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 804,
      NameEn = "RS6 Avant",
      NameAr = "RS6 Avant",
      Code = "RS6 Avant",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 805,
      NameEn = "RS7",
      NameAr = "RS7",
      Code = "RS7",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 806,
      NameEn = "S3/S3 Sportback",
      NameAr = "S3/S3 Sportback",
      Code = "S3/S3 Sportback",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 807,
      NameEn = "S4 Cabriolet",
      NameAr = "S4 Cabriolet",
      Code = "S4 Cabriolet",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 808,
      NameEn = "S4/S4 Avant",
      NameAr = "S4/S4 Avant",
      Code = "S4/S4 Avant",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 809,
      NameEn = "S5/S5 Cabriolet",
      NameAr = "S5/S5 Cabriolet",
      Code = "S5/S5 Cabriolet",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 810,
      NameEn = "S6/RS6",
      NameAr = "S6/RS6",
      Code = "S6/RS6",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 811,
      NameEn = "S7",
      NameAr = "S7",
      Code = "S7",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 812,
      NameEn = "S8",
      NameAr = "S8",
      Code = "S8",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 813,
      NameEn = "SQ5",
      NameAr = "SQ5",
      Code = "SQ5",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 814,
      NameEn = "TT Coupé",
      NameAr = "TT Coupé",
      Code = "TT Coupé",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 815,
      NameEn = "TT Roadster",
      NameAr = "TT Roadster",
      Code = "TT Roadster",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 816,
      NameEn = "TTS",
      NameAr = "TTS",
      Code = "TTS",
      ParentCode = "Honda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 817,
      NameEn = "H1",
      NameAr = "H1",
      Code = "H1",
      ParentCode = "HUMMER",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 818,
      NameEn = "H2",
      NameAr = "H2",
      Code = "H2",
      ParentCode = "HUMMER",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 819,
      NameEn = "H3",
      NameAr = "H3",
      Code = "H3",
      ParentCode = "HUMMER",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 820,
      NameEn = "H3T",
      NameAr = "H3T",
      Code = "H3T",
      ParentCode = "HUMMER",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 821,
      NameEn = "Accent",
      NameAr = "Accent",
      Code = "Accent",
      ParentCode = "Hyundai",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 822,
      NameEn = "Azera",
      NameAr = "Azera",
      Code = "Azera",
      ParentCode = "Hyundai",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 823,
      NameEn = "Elantra",
      NameAr = "Elantra",
      Code = "Elantra",
      ParentCode = "Hyundai",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 824,
      NameEn = "Elantra Coupe",
      NameAr = "Elantra Coupe",
      Code = "Elantra Coupe",
      ParentCode = "Hyundai",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 825,
      NameEn = "Elantra Touring",
      NameAr = "Elantra Touring",
      Code = "Elantra Touring",
      ParentCode = "Hyundai",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 826,
      NameEn = "Entourage",
      NameAr = "Entourage",
      Code = "Entourage",
      ParentCode = "Hyundai",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 827,
      NameEn = "Equus",
      NameAr = "Equus",
      Code = "Equus",
      ParentCode = "Hyundai",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 828,
      NameEn = "Excel",
      NameAr = "Excel",
      Code = "Excel",
      ParentCode = "Hyundai",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 829,
      NameEn = "Genesis",
      NameAr = "Genesis",
      Code = "Genesis",
      ParentCode = "Hyundai",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 830,
      NameEn = "Genesis Coupe",
      NameAr = "Genesis Coupe",
      Code = "Genesis Coupe",
      ParentCode = "Hyundai",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 831,
      NameEn = "Santa Fe",
      NameAr = "Santa Fe",
      Code = "Santa Fe",
      ParentCode = "Hyundai",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 832,
      NameEn = "Scoupe",
      NameAr = "Scoupe",
      Code = "Scoupe",
      ParentCode = "Hyundai",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 833,
      NameEn = "Sonata",
      NameAr = "Sonata",
      Code = "Sonata",
      ParentCode = "Hyundai",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 834,
      NameEn = "Tiburon",
      NameAr = "Tiburon",
      Code = "Tiburon",
      ParentCode = "Hyundai",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 835,
      NameEn = "Tucson",
      NameAr = "Tucson",
      Code = "Tucson",
      ParentCode = "Hyundai",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 836,
      NameEn = "Veloster",
      NameAr = "Veloster",
      Code = "Veloster",
      ParentCode = "Hyundai",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 837,
      NameEn = "Veracruz",
      NameAr = "Veracruz",
      Code = "Veracruz",
      ParentCode = "Hyundai",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 838,
      NameEn = "XG300",
      NameAr = "XG300",
      Code = "XG300",
      ParentCode = "Hyundai",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 839,
      NameEn = "XG350",
      NameAr = "XG350",
      Code = "XG350",
      ParentCode = "Hyundai",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 840,
      NameEn = "EX35",
      NameAr = "EX35",
      Code = "EX35",
      ParentCode = "Infiniti",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 841,
      NameEn = "EX37",
      NameAr = "EX37",
      Code = "EX37",
      ParentCode = "Infiniti",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 842,
      NameEn = "FX35",
      NameAr = "FX35",
      Code = "FX35",
      ParentCode = "Infiniti",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 843,
      NameEn = "FX37",
      NameAr = "FX37",
      Code = "FX37",
      ParentCode = "Infiniti",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 844,
      NameEn = "FX45",
      NameAr = "FX45",
      Code = "FX45",
      ParentCode = "Infiniti",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 845,
      NameEn = "FX50",
      NameAr = "FX50",
      Code = "FX50",
      ParentCode = "Infiniti",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 846,
      NameEn = "G20",
      NameAr = "G20",
      Code = "G20",
      ParentCode = "Infiniti",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 847,
      NameEn = "G25",
      NameAr = "G25",
      Code = "G25",
      ParentCode = "Infiniti",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 848,
      NameEn = "G35",
      NameAr = "G35",
      Code = "G35",
      ParentCode = "Infiniti",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 849,
      NameEn = "G37",
      NameAr = "G37",
      Code = "G37",
      ParentCode = "Infiniti",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 850,
      NameEn = "I30",
      NameAr = "I30",
      Code = "I30",
      ParentCode = "Infiniti",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 851,
      NameEn = "I35",
      NameAr = "I35",
      Code = "I35",
      ParentCode = "Infiniti",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 852,
      NameEn = "J30",
      NameAr = "J30",
      Code = "J30",
      ParentCode = "Infiniti",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 853,
      NameEn = "JX35",
      NameAr = "JX35",
      Code = "JX35",
      ParentCode = "Infiniti",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 854,
      NameEn = "M30",
      NameAr = "M30",
      Code = "M30",
      ParentCode = "Infiniti",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 855,
      NameEn = "M35",
      NameAr = "M35",
      Code = "M35",
      ParentCode = "Infiniti",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 856,
      NameEn = "M35h",
      NameAr = "M35h",
      Code = "M35h",
      ParentCode = "Infiniti",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 857,
      NameEn = "M37",
      NameAr = "M37",
      Code = "M37",
      ParentCode = "Infiniti",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 858,
      NameEn = "M45",
      NameAr = "M45",
      Code = "M45",
      ParentCode = "Infiniti",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 859,
      NameEn = "M56",
      NameAr = "M56",
      Code = "M56",
      ParentCode = "Infiniti",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 860,
      NameEn = "Q45",
      NameAr = "Q45",
      Code = "Q45",
      ParentCode = "Infiniti",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 861,
      NameEn = "Q50",
      NameAr = "Q50",
      Code = "Q50",
      ParentCode = "Infiniti",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 862,
      NameEn = "QX4",
      NameAr = "QX4",
      Code = "QX4",
      ParentCode = "Infiniti",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 863,
      NameEn = "QX56",
      NameAr = "QX56",
      Code = "QX56",
      ParentCode = "Infiniti",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 864,
      NameEn = "Amigo",
      NameAr = "Amigo",
      Code = "Amigo",
      ParentCode = "Isuzu",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 865,
      NameEn = "Ascender",
      NameAr = "Ascender",
      Code = "Ascender",
      ParentCode = "Isuzu",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 866,
      NameEn = "Axiom",
      NameAr = "Axiom",
      Code = "Axiom",
      ParentCode = "Isuzu",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 867,
      NameEn = "Hombre",
      NameAr = "Hombre",
      Code = "Hombre",
      ParentCode = "Isuzu",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 868,
      NameEn = "i-280",
      NameAr = "i-280",
      Code = "i-280",
      ParentCode = "Isuzu",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 869,
      NameEn = "i-290",
      NameAr = "i-290",
      Code = "i-290",
      ParentCode = "Isuzu",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 870,
      NameEn = "i-350",
      NameAr = "i-350",
      Code = "i-350",
      ParentCode = "Isuzu",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 871,
      NameEn = "i-370",
      NameAr = "i-370",
      Code = "i-370",
      ParentCode = "Isuzu",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 872,
      NameEn = "I-Mark",
      NameAr = "I-Mark",
      Code = "I-Mark",
      ParentCode = "Isuzu",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 873,
      NameEn = "Impulse",
      NameAr = "Impulse",
      Code = "Impulse",
      ParentCode = "Isuzu",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 874,
      NameEn = "Oasis",
      NameAr = "Oasis",
      Code = "Oasis",
      ParentCode = "Isuzu",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 875,
      NameEn = "Pickup",
      NameAr = "Pickup",
      Code = "Pickup",
      ParentCode = "Isuzu",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 876,
      NameEn = "Rodeo",
      NameAr = "Rodeo",
      Code = "Rodeo",
      ParentCode = "Isuzu",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 877,
      NameEn = "Stylus",
      NameAr = "Stylus",
      Code = "Stylus",
      ParentCode = "Isuzu",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 878,
      NameEn = "Trooper",
      NameAr = "Trooper",
      Code = "Trooper",
      ParentCode = "Isuzu",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 879,
      NameEn = "Trooper II",
      NameAr = "Trooper II",
      Code = "Trooper II",
      ParentCode = "Isuzu",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 880,
      NameEn = "VehiCROSS",
      NameAr = "VehiCROSS",
      Code = "VehiCROSS",
      ParentCode = "Isuzu",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 881,
      NameEn = "S-Type",
      NameAr = "S-Type",
      Code = "S-Type",
      ParentCode = "Jaguar",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 882,
      NameEn = "X-Type",
      NameAr = "X-Type",
      Code = "X-Type",
      ParentCode = "Jaguar",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 883,
      NameEn = "XF",
      NameAr = "XF",
      Code = "XF",
      ParentCode = "Jaguar",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 884,
      NameEn = "XJ12",
      NameAr = "XJ12",
      Code = "XJ12",
      ParentCode = "Jaguar",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 885,
      NameEn = "XJ6",
      NameAr = "XJ6",
      Code = "XJ6",
      ParentCode = "Jaguar",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 886,
      NameEn = "XJR",
      NameAr = "XJR",
      Code = "XJR",
      ParentCode = "Jaguar",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 887,
      NameEn = "XJR-S",
      NameAr = "XJR-S",
      Code = "XJR-S",
      ParentCode = "Jaguar",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 888,
      NameEn = "XJS",
      NameAr = "XJS",
      Code = "XJS",
      ParentCode = "Jaguar",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 889,
      NameEn = "XJ Vanden Plas",
      NameAr = "XJ Vanden Plas",
      Code = "XJ Vanden Plas",
      ParentCode = "Jaguar",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 890,
      NameEn = "XJ",
      NameAr = "XJ",
      Code = "XJ",
      ParentCode = "Jaguar",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 891,
      NameEn = "XJ8",
      NameAr = "XJ8",
      Code = "XJ8",
      ParentCode = "Jaguar",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 892,
      NameEn = "XJ8 L",
      NameAr = "XJ8 L",
      Code = "XJ8 L",
      ParentCode = "Jaguar",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 893,
      NameEn = "XJ Sport",
      NameAr = "XJ Sport",
      Code = "XJ Sport",
      ParentCode = "Jaguar",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 894,
      NameEn = "XK8",
      NameAr = "XK8",
      Code = "XK8",
      ParentCode = "Jaguar",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 895,
      NameEn = "XK",
      NameAr = "XK",
      Code = "XK",
      ParentCode = "Jaguar",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 896,
      NameEn = "XKR",
      NameAr = "XKR",
      Code = "XKR",
      ParentCode = "Jaguar",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 897,
      NameEn = "Cherokee",
      NameAr = "Cherokee",
      Code = "Cherokee",
      ParentCode = "Jeep",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 898,
      NameEn = "CJ",
      NameAr = "CJ",
      Code = "CJ",
      ParentCode = "Jeep",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 899,
      NameEn = "Comanche",
      NameAr = "Comanche",
      Code = "Comanche",
      ParentCode = "Jeep",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 900,
      NameEn = "Commander",
      NameAr = "Commander",
      Code = "Commander",
      ParentCode = "Jeep",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 901,
      NameEn = "Compass",
      NameAr = "Compass",
      Code = "Compass",
      ParentCode = "Jeep",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 902,
      NameEn = "Grand Cherokee",
      NameAr = "Grand Cherokee",
      Code = "Grand Cherokee",
      ParentCode = "Jeep",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 903,
      NameEn = "Grand Wagoneer",
      NameAr = "Grand Wagoneer",
      Code = "Grand Wagoneer",
      ParentCode = "Jeep",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 904,
      NameEn = "Liberty",
      NameAr = "Liberty",
      Code = "Liberty",
      ParentCode = "Jeep",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 905,
      NameEn = "Patriot",
      NameAr = "Patriot",
      Code = "Patriot",
      ParentCode = "Jeep",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 906,
      NameEn = "Pickup",
      NameAr = "Pickup",
      Code = "Pickup",
      ParentCode = "Jeep",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 907,
      NameEn = "Scrambler",
      NameAr = "Scrambler",
      Code = "Scrambler",
      ParentCode = "Jeep",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 908,
      NameEn = "Wagoneer",
      NameAr = "Wagoneer",
      Code = "Wagoneer",
      ParentCode = "Jeep",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 909,
      NameEn = "Wrangler",
      NameAr = "Wrangler",
      Code = "Wrangler",
      ParentCode = "Jeep",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 910,
      NameEn = "Cerato",
      NameAr = "Cerato",
      Code = "Cerato",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 911,
      NameEn = "Amanti",
      NameAr = "Amanti",
      Code = "Amanti",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 912,
      NameEn = "Borrego",
      NameAr = "Borrego",
      Code = "Borrego",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 913,
      NameEn = "Forte",
      NameAr = "Forte",
      Code = "Forte",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 914,
      NameEn = "Forte Koup",
      NameAr = "Forte Koup",
      Code = "Forte Koup",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 915,
      NameEn = "Rio",
      NameAr = "Rio",
      Code = "Rio",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 916,
      NameEn = "Rio5",
      NameAr = "Rio5",
      Code = "Rio5",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 917,
      NameEn = "Rio Combi",
      NameAr = "Rio Combi",
      Code = "Rio Combi",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 918,
      NameEn = "Rio sedan",
      NameAr = "Rio sedan",
      Code = "Rio sedan",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 919,
      NameEn = "Rondo",
      NameAr = "Rondo",
      Code = "Rondo",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 920,
      NameEn = "Sedona",
      NameAr = "Sedona",
      Code = "Sedona",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 921,
      NameEn = "Soul",
      NameAr = "Soul",
      Code = "Soul",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 922,
      NameEn = "Spectra",
      NameAr = "Spectra",
      Code = "Spectra",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 923,
      NameEn = "Spectra5",
      NameAr = "Spectra5",
      Code = "Spectra5",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 924,
      NameEn = "Sportage",
      NameAr = "Sportage",
      Code = "Sportage",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 925,
      NameEn = "Avella",
      NameAr = "Avella",
      Code = "Avella",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 926,
      NameEn = "Besta",
      NameAr = "Besta",
      Code = "Besta",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 927,
      NameEn = "Carens",
      NameAr = "Carens",
      Code = "Carens",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 928,
      NameEn = "Carnival",
      NameAr = "Carnival",
      Code = "Carnival",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 929,
      NameEn = "Cee`d",
      NameAr = "Cee`d",
      Code = "Cee`d",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 930,
      NameEn = "Cee`d SW",
      NameAr = "Cee`d SW",
      Code = "Cee`d SW",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 932,
      NameEn = "K 2500",
      NameAr = "K 2500",
      Code = "K 2500",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 933,
      NameEn = "Magentis",
      NameAr = "Magentis",
      Code = "Magentis",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 934,
      NameEn = "Opirus",
      NameAr = "Opirus",
      Code = "Opirus",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 935,
      NameEn = "Optima",
      NameAr = "Optima",
      Code = "Optima",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 936,
      NameEn = "Picanto",
      NameAr = "Picanto",
      Code = "Picanto",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 937,
      NameEn = "Pregio",
      NameAr = "Pregio",
      Code = "Pregio",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 938,
      NameEn = "Pride",
      NameAr = "Pride",
      Code = "Pride",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 939,
      NameEn = "Pro Cee`d",
      NameAr = "Pro Cee`d",
      Code = "Pro Cee`d",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 940,
      NameEn = "Sephia",
      NameAr = "Sephia",
      Code = "Sephia",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 941,
      NameEn = "Shuma",
      NameAr = "Shuma",
      Code = "Shuma",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 942,
      NameEn = "Sorento",
      NameAr = "Sorento",
      Code = "Sorento",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 943,
      NameEn = "Venga",
      NameAr = "Venga",
      Code = "Venga",
      ParentCode = "Kia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 944,
      NameEn = "Aventador",
      NameAr = "Aventador",
      Code = "Aventador",
      ParentCode = "Lamborghini",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 945,
      NameEn = "Countach",
      NameAr = "Countach",
      Code = "Countach",
      ParentCode = "Lamborghini",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 946,
      NameEn = "Diablo",
      NameAr = "Diablo",
      Code = "Diablo",
      ParentCode = "Lamborghini",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 947,
      NameEn = "Gallardo",
      NameAr = "Gallardo",
      Code = "Gallardo",
      ParentCode = "Lamborghini",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 948,
      NameEn = "Jalpa",
      NameAr = "Jalpa",
      Code = "Jalpa",
      ParentCode = "Lamborghini",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 949,
      NameEn = "LM002",
      NameAr = "LM002",
      Code = "LM002",
      ParentCode = "Lamborghini",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 950,
      NameEn = "Murcielago",
      NameAr = "Murcielago",
      Code = "Murcielago",
      ParentCode = "Lamborghini",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 951,
      NameEn = "Beta",
      NameAr = "Beta",
      Code = "Beta",
      ParentCode = "Lancia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 952,
      NameEn = "Zagato",
      NameAr = "Zagato",
      Code = "Zagato",
      ParentCode = "Lancia",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 953,
      NameEn = "Defender",
      NameAr = "Defender",
      Code = "Defender",
      ParentCode = "Land Rover",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 954,
      NameEn = "Discovery",
      NameAr = "Discovery",
      Code = "Discovery",
      ParentCode = "Land Rover",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 955,
      NameEn = "Freelander",
      NameAr = "Freelander",
      Code = "Freelander",
      ParentCode = "Land Rover",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 956,
      NameEn = "LR2",
      NameAr = "LR2",
      Code = "LR2",
      ParentCode = "Land Rover",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 957,
      NameEn = "LR3",
      NameAr = "LR3",
      Code = "LR3",
      ParentCode = "Land Rover",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 958,
      NameEn = "LR4",
      NameAr = "LR4",
      Code = "LR4",
      ParentCode = "Land Rover",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 959,
      NameEn = "Range Rover",
      NameAr = "Range Rover",
      Code = "Range Rover",
      ParentCode = "Land Rover",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 960,
      NameEn = "Range Rover Evoque",
      NameAr = "Range Rover Evoque",
      Code = "Range Rover Evoque",
      ParentCode = "Land Rover",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 961,
      NameEn = "Range Rover Sport",
      NameAr = "Range Rover Sport",
      Code = "Range Rover Sport",
      ParentCode = "Land Rover",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 962,
      NameEn = "CT 200h",
      NameAr = "CT 200h",
      Code = "CT 200h",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 963,
      NameEn = "ES 250",
      NameAr = "ES 250",
      Code = "ES 250",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 964,
      NameEn = "ES 300",
      NameAr = "ES 300",
      Code = "ES 300",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 965,
      NameEn = "ES 300h",
      NameAr = "ES 300h",
      Code = "ES 300h",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 966,
      NameEn = "ES 330",
      NameAr = "ES 330",
      Code = "ES 330",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 967,
      NameEn = "ES 350",
      NameAr = "ES 350",
      Code = "ES 350",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 968,
      NameEn = "GS 300",
      NameAr = "GS 300",
      Code = "GS 300",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 969,
      NameEn = "GS 350",
      NameAr = "GS 350",
      Code = "GS 350",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 970,
      NameEn = "GS 400",
      NameAr = "GS 400",
      Code = "GS 400",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 971,
      NameEn = "GS 430",
      NameAr = "GS 430",
      Code = "GS 430",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 972,
      NameEn = "GS 450h",
      NameAr = "GS 450h",
      Code = "GS 450h",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 973,
      NameEn = "GS 460",
      NameAr = "GS 460",
      Code = "GS 460",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 974,
      NameEn = "GX 460",
      NameAr = "GX 460",
      Code = "GX 460",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 975,
      NameEn = "GX 470",
      NameAr = "GX 470",
      Code = "GX 470",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 976,
      NameEn = "HS 250h",
      NameAr = "HS 250h",
      Code = "HS 250h",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 977,
      NameEn = "IS 250",
      NameAr = "IS 250",
      Code = "IS 250",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 978,
      NameEn = "IS 250C",
      NameAr = "IS 250C",
      Code = "IS 250C",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 979,
      NameEn = "IS 300",
      NameAr = "IS 300",
      Code = "IS 300",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 980,
      NameEn = "IS 350",
      NameAr = "IS 350",
      Code = "IS 350",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 981,
      NameEn = "IS 350C",
      NameAr = "IS 350C",
      Code = "IS 350C",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 982,
      NameEn = "IS F",
      NameAr = "IS F",
      Code = "IS F",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 983,
      NameEn = "LFA",
      NameAr = "LFA",
      Code = "LFA",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 984,
      NameEn = "LS 400",
      NameAr = "LS 400",
      Code = "LS 400",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 985,
      NameEn = "LS 430",
      NameAr = "LS 430",
      Code = "LS 430",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 986,
      NameEn = "LS 460",
      NameAr = "LS 460",
      Code = "LS 460",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 987,
      NameEn = "LS 600h",
      NameAr = "LS 600h",
      Code = "LS 600h",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 988,
      NameEn = "LX 450",
      NameAr = "LX 450",
      Code = "LX 450",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 989,
      NameEn = "LX 470",
      NameAr = "LX 470",
      Code = "LX 470",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 990,
      NameEn = "LX 570",
      NameAr = "LX 570",
      Code = "LX 570",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 991,
      NameEn = "RX 300",
      NameAr = "RX 300",
      Code = "RX 300",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 992,
      NameEn = "RX 330",
      NameAr = "RX 330",
      Code = "RX 330",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 993,
      NameEn = "RX 350",
      NameAr = "RX 350",
      Code = "RX 350",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 994,
      NameEn = "RX 400h",
      NameAr = "RX 400h",
      Code = "RX 400h",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 995,
      NameEn = "RX 450h",
      NameAr = "RX 450h",
      Code = "RX 450h",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 996,
      NameEn = "SC 300",
      NameAr = "SC 300",
      Code = "SC 300",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 997,
      NameEn = "SC 400",
      NameAr = "SC 400",
      Code = "SC 400",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 998,
      NameEn = "SC 430",
      NameAr = "SC 430",
      Code = "SC 430",
      ParentCode = "Lexus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 999,
      NameEn = "Aviator",
      NameAr = "Aviator",
      Code = "Aviator",
      ParentCode = "Lincoln",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1000,
      NameEn = "Blackwood",
      NameAr = "Blackwood",
      Code = "Blackwood",
      ParentCode = "Lincoln",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1001,
      NameEn = "Continental",
      NameAr = "Continental",
      Code = "Continental",
      ParentCode = "Lincoln",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1002,
      NameEn = "LS",
      NameAr = "LS",
      Code = "LS",
      ParentCode = "Lincoln",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1003,
      NameEn = "Mark LT",
      NameAr = "Mark LT",
      Code = "Mark LT",
      ParentCode = "Lincoln",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1004,
      NameEn = "Mark VI",
      NameAr = "Mark VI",
      Code = "Mark VI",
      ParentCode = "Lincoln",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1005,
      NameEn = "Mark VII",
      NameAr = "Mark VII",
      Code = "Mark VII",
      ParentCode = "Lincoln",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1006,
      NameEn = "Mark VIII",
      NameAr = "Mark VIII",
      Code = "Mark VIII",
      ParentCode = "Lincoln",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1007,
      NameEn = "MKS",
      NameAr = "MKS",
      Code = "MKS",
      ParentCode = "Lincoln",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1008,
      NameEn = "MKT",
      NameAr = "MKT",
      Code = "MKT",
      ParentCode = "Lincoln",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1009,
      NameEn = "MKX",
      NameAr = "MKX",
      Code = "MKX",
      ParentCode = "Lincoln",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1010,
      NameEn = "MKZ",
      NameAr = "MKZ",
      Code = "MKZ",
      ParentCode = "Lincoln",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1011,
      NameEn = "Navigator",
      NameAr = "Navigator",
      Code = "Navigator",
      ParentCode = "Lincoln",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1012,
      NameEn = "Navigator L",
      NameAr = "Navigator L",
      Code = "Navigator L",
      ParentCode = "Lincoln",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1013,
      NameEn = "Town Car",
      NameAr = "Town Car",
      Code = "Town Car",
      ParentCode = "Lincoln",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1014,
      NameEn = "Zephyr",
      NameAr = "Zephyr",
      Code = "Zephyr",
      ParentCode = "Lincoln",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1015,
      NameEn = "Elan",
      NameAr = "Elan",
      Code = "Elan",
      ParentCode = "Lotus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1016,
      NameEn = "Elise",
      NameAr = "Elise",
      Code = "Elise",
      ParentCode = "Lotus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1017,
      NameEn = "Esprit",
      NameAr = "Esprit",
      Code = "Esprit",
      ParentCode = "Lotus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1018,
      NameEn = "Evora",
      NameAr = "Evora",
      Code = "Evora",
      ParentCode = "Lotus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1019,
      NameEn = "Exige",
      NameAr = "Exige",
      Code = "Exige",
      ParentCode = "Lotus",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1020,
      NameEn = "430",
      NameAr = "430",
      Code = "430",
      ParentCode = "Maserati",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1021,
      NameEn = "Biturbo",
      NameAr = "Biturbo",
      Code = "Biturbo",
      ParentCode = "Maserati",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1022,
      NameEn = "Coupe",
      NameAr = "Coupe",
      Code = "Coupe",
      ParentCode = "Maserati",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1023,
      NameEn = "GranSport",
      NameAr = "GranSport",
      Code = "GranSport",
      ParentCode = "Maserati",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1024,
      NameEn = "GranTurismo",
      NameAr = "GranTurismo",
      Code = "GranTurismo",
      ParentCode = "Maserati",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1025,
      NameEn = "Quattroporte",
      NameAr = "Quattroporte",
      Code = "Quattroporte",
      ParentCode = "Maserati",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1026,
      NameEn = "Spyder",
      NameAr = "Spyder",
      Code = "Spyder",
      ParentCode = "Maserati",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1027,
      NameEn = "57",
      NameAr = "57",
      Code = "57",
      ParentCode = "Maybach",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1028,
      NameEn = "62",
      NameAr = "62",
      Code = "62",
      ParentCode = "Maybach",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1029,
      NameEn = "323",
      NameAr = "323",
      Code = "323",
      ParentCode = "Mazda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1030,
      NameEn = "626",
      NameAr = "626",
      Code = "626",
      ParentCode = "Mazda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1031,
      NameEn = "929",
      NameAr = "929",
      Code = "929",
      ParentCode = "Mazda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1032,
      NameEn = "B-Series Pickup",
      NameAr = "B-Series Pickup",
      Code = "B-Series Pickup",
      ParentCode = "Mazda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1033,
      NameEn = "CX-5",
      NameAr = "CX-5",
      Code = "CX-5",
      ParentCode = "Mazda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1034,
      NameEn = "CX-7",
      NameAr = "CX-7",
      Code = "CX-7",
      ParentCode = "Mazda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1035,
      NameEn = "CX-9",
      NameAr = "CX-9",
      Code = "CX-9",
      ParentCode = "Mazda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1036,
      NameEn = "GLC",
      NameAr = "GLC",
      Code = "GLC",
      ParentCode = "Mazda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1037,
      NameEn = "MAZDA2",
      NameAr = "MAZDA2",
      Code = "MAZDA2",
      ParentCode = "Mazda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1038,
      NameEn = "MAZDA3",
      NameAr = "MAZDA3",
      Code = "MAZDA3",
      ParentCode = "Mazda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1039,
      NameEn = "MAZDA5",
      NameAr = "MAZDA5",
      Code = "MAZDA5",
      ParentCode = "Mazda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1040,
      NameEn = "MAZDA6",
      NameAr = "MAZDA6",
      Code = "MAZDA6",
      ParentCode = "Mazda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1041,
      NameEn = "MAZDASPEED3",
      NameAr = "MAZDASPEED3",
      Code = "MAZDASPEED3",
      ParentCode = "Mazda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1042,
      NameEn = "MAZDASPEED6",
      NameAr = "MAZDASPEED6",
      Code = "MAZDASPEED6",
      ParentCode = "Mazda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1043,
      NameEn = "Miata MX5",
      NameAr = "Miata MX5",
      Code = "Miata MX5",
      ParentCode = "Mazda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1044,
      NameEn = "Millenia",
      NameAr = "Millenia",
      Code = "Millenia",
      ParentCode = "Mazda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1045,
      NameEn = "MPV",
      NameAr = "MPV",
      Code = "MPV",
      ParentCode = "Mazda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1046,
      NameEn = "MX3",
      NameAr = "MX3",
      Code = "MX3",
      ParentCode = "Mazda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1047,
      NameEn = "MX6",
      NameAr = "MX6",
      Code = "MX6",
      ParentCode = "Mazda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1048,
      NameEn = "Navajo",
      NameAr = "Navajo",
      Code = "Navajo",
      ParentCode = "Mazda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1049,
      NameEn = "Protege",
      NameAr = "Protege",
      Code = "Protege",
      ParentCode = "Mazda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1050,
      NameEn = "Protege5",
      NameAr = "Protege5",
      Code = "Protege5",
      ParentCode = "Mazda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1051,
      NameEn = "RX-7",
      NameAr = "RX-7",
      Code = "RX-7",
      ParentCode = "Mazda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1052,
      NameEn = "RX-8",
      NameAr = "RX-8",
      Code = "RX-8",
      ParentCode = "Mazda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1053,
      NameEn = "Tribute",
      NameAr = "Tribute",
      Code = "Tribute",
      ParentCode = "Mazda",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1054,
      NameEn = "MP4-12C",
      NameAr = "MP4-12C",
      Code = "MP4-12C",
      ParentCode = "McLaren",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1055,
      NameEn = "190D",
      NameAr = "190D",
      Code = "190D",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1056,
      NameEn = "190E",
      NameAr = "190E",
      Code = "190E",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1057,
      NameEn = "240D",
      NameAr = "240D",
      Code = "240D",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1058,
      NameEn = "300CD",
      NameAr = "300CD",
      Code = "300CD",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1059,
      NameEn = "300CE",
      NameAr = "300CE",
      Code = "300CE",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1060,
      NameEn = "300D",
      NameAr = "300D",
      Code = "300D",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1061,
      NameEn = "300E",
      NameAr = "300E",
      Code = "300E",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1062,
      NameEn = "300TD",
      NameAr = "300TD",
      Code = "300TD",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1063,
      NameEn = "300TE",
      NameAr = "300TE",
      Code = "300TE",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1064,
      NameEn = "C220",
      NameAr = "C220",
      Code = "C220",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1065,
      NameEn = "C230",
      NameAr = "C230",
      Code = "C230",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1066,
      NameEn = "C240",
      NameAr = "C240",
      Code = "C240",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1067,
      NameEn = "C250",
      NameAr = "C250",
      Code = "C250",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1068,
      NameEn = "C280",
      NameAr = "C280",
      Code = "C280",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1069,
      NameEn = "C300",
      NameAr = "C300",
      Code = "C300",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1070,
      NameEn = "C320",
      NameAr = "C320",
      Code = "C320",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1071,
      NameEn = "C32 AMG",
      NameAr = "C32 AMG",
      Code = "C32 AMG",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1072,
      NameEn = "C350",
      NameAr = "C350",
      Code = "C350",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1073,
      NameEn = "C36 AMG",
      NameAr = "C36 AMG",
      Code = "C36 AMG",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1074,
      NameEn = "C43 AMG",
      NameAr = "C43 AMG",
      Code = "C43 AMG",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1075,
      NameEn = "C55 AMG",
      NameAr = "C55 AMG",
      Code = "C55 AMG",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1076,
      NameEn = "C63 AMG",
      NameAr = "C63 AMG",
      Code = "C63 AMG",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1077,
      NameEn = "CL500",
      NameAr = "CL500",
      Code = "CL500",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1078,
      NameEn = "CL550",
      NameAr = "CL550",
      Code = "CL550",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1079,
      NameEn = "CL55 AMG",
      NameAr = "CL55 AMG",
      Code = "CL55 AMG",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1080,
      NameEn = "CL600",
      NameAr = "CL600",
      Code = "CL600",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1081,
      NameEn = "CL63 AMG",
      NameAr = "CL63 AMG",
      Code = "CL63 AMG",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1082,
      NameEn = "CL65 AMG",
      NameAr = "CL65 AMG",
      Code = "CL65 AMG",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1083,
      NameEn = "CLK320",
      NameAr = "CLK320",
      Code = "CLK320",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1084,
      NameEn = "CLK350",
      NameAr = "CLK350",
      Code = "CLK350",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1085,
      NameEn = "CLK430",
      NameAr = "CLK430",
      Code = "CLK430",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1086,
      NameEn = "CLK500",
      NameAr = "CLK500",
      Code = "CLK500",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1087,
      NameEn = "CLK550",
      NameAr = "CLK550",
      Code = "CLK550",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1088,
      NameEn = "CLK55 AMG",
      NameAr = "CLK55 AMG",
      Code = "CLK55 AMG",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1089,
      NameEn = "CLK63 AMG",
      NameAr = "CLK63 AMG",
      Code = "CLK63 AMG",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1090,
      NameEn = "CLS500",
      NameAr = "CLS500",
      Code = "CLS500",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1091,
      NameEn = "CLS550",
      NameAr = "CLS550",
      Code = "CLS550",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1092,
      NameEn = "CLS55 AMG",
      NameAr = "CLS55 AMG",
      Code = "CLS55 AMG",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1093,
      NameEn = "CLS63 AMG",
      NameAr = "CLS63 AMG",
      Code = "CLS63 AMG",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1094,
      NameEn = "260E",
      NameAr = "260E",
      Code = "260E",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1095,
      NameEn = "280CE",
      NameAr = "280CE",
      Code = "280CE",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1096,
      NameEn = "280E",
      NameAr = "280E",
      Code = "280E",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1097,
      NameEn = "400E",
      NameAr = "400E",
      Code = "400E",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1098,
      NameEn = "500E",
      NameAr = "500E",
      Code = "500E",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1099,
      NameEn = "E300",
      NameAr = "E300",
      Code = "E300",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1100,
      NameEn = "E320",
      NameAr = "E320",
      Code = "E320",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1101,
      NameEn = "E320 Bluetec",
      NameAr = "E320 Bluetec",
      Code = "E320 Bluetec",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1102,
      NameEn = "E320 CDI",
      NameAr = "E320 CDI",
      Code = "E320 CDI",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1103,
      NameEn = "E350",
      NameAr = "E350",
      Code = "E350",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1104,
      NameEn = "E350 Bluetec",
      NameAr = "E350 Bluetec",
      Code = "E350 Bluetec",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1105,
      NameEn = "E400 Hybrid",
      NameAr = "E400 Hybrid",
      Code = "E400 Hybrid",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1106,
      NameEn = "E420",
      NameAr = "E420",
      Code = "E420",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1107,
      NameEn = "E430",
      NameAr = "E430",
      Code = "E430",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1108,
      NameEn = "E500",
      NameAr = "E500",
      Code = "E500",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1109,
      NameEn = "E550",
      NameAr = "E550",
      Code = "E550",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1110,
      NameEn = "E55 AMG",
      NameAr = "E55 AMG",
      Code = "E55 AMG",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1111,
      NameEn = "E63 AMG",
      NameAr = "E63 AMG",
      Code = "E63 AMG",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1112,
      NameEn = "G500",
      NameAr = "G500",
      Code = "G500",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1113,
      NameEn = "G550",
      NameAr = "G550",
      Code = "G550",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1114,
      NameEn = "G55 AMG",
      NameAr = "G55 AMG",
      Code = "G55 AMG",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1115,
      NameEn = "G63 AMG",
      NameAr = "G63 AMG",
      Code = "G63 AMG",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1116,
      NameEn = "GL320 Bluetec",
      NameAr = "GL320 Bluetec",
      Code = "GL320 Bluetec",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1117,
      NameEn = "GL320 CDI",
      NameAr = "GL320 CDI",
      Code = "GL320 CDI",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1118,
      NameEn = "GL350 Bluetec",
      NameAr = "GL350 Bluetec",
      Code = "GL350 Bluetec",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1119,
      NameEn = "GL450",
      NameAr = "GL450",
      Code = "GL450",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1120,
      NameEn = "GL550",
      NameAr = "GL550",
      Code = "GL550",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1121,
      NameEn = "GLK350",
      NameAr = "GLK350",
      Code = "GLK350",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1122,
      NameEn = "ML320",
      NameAr = "ML320",
      Code = "ML320",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1123,
      NameEn = "ML320 Bluetec",
      NameAr = "ML320 Bluetec",
      Code = "ML320 Bluetec",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1124,
      NameEn = "ML320 CDI",
      NameAr = "ML320 CDI",
      Code = "ML320 CDI",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1125,
      NameEn = "ML350",
      NameAr = "ML350",
      Code = "ML350",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1126,
      NameEn = "ML350 Bluetec",
      NameAr = "ML350 Bluetec",
      Code = "ML350 Bluetec",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1127,
      NameEn = "ML430",
      NameAr = "ML430",
      Code = "ML430",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1128,
      NameEn = "ML450 Hybrid",
      NameAr = "ML450 Hybrid",
      Code = "ML450 Hybrid",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1129,
      NameEn = "ML500",
      NameAr = "ML500",
      Code = "ML500",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1130,
      NameEn = "ML550",
      NameAr = "ML550",
      Code = "ML550",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1131,
      NameEn = "ML55 AMG",
      NameAr = "ML55 AMG",
      Code = "ML55 AMG",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1132,
      NameEn = "ML63 AMG",
      NameAr = "ML63 AMG",
      Code = "ML63 AMG",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1133,
      NameEn = "R320 Bluetec",
      NameAr = "R320 Bluetec",
      Code = "R320 Bluetec",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1134,
      NameEn = "R320 CDI",
      NameAr = "R320 CDI",
      Code = "R320 CDI",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1135,
      NameEn = "R350",
      NameAr = "R350",
      Code = "R350",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1136,
      NameEn = "R350 Bluetec",
      NameAr = "R350 Bluetec",
      Code = "R350 Bluetec",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1137,
      NameEn = "R500",
      NameAr = "R500",
      Code = "R500",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1138,
      NameEn = "R63 AMG",
      NameAr = "R63 AMG",
      Code = "R63 AMG",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1139,
      NameEn = "300SD",
      NameAr = "300SD",
      Code = "300SD",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1140,
      NameEn = "300SDL",
      NameAr = "300SDL",
      Code = "300SDL",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1141,
      NameEn = "300SE",
      NameAr = "300SE",
      Code = "300SE",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1142,
      NameEn = "300SEL",
      NameAr = "300SEL",
      Code = "300SEL",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1143,
      NameEn = "350SD",
      NameAr = "350SD",
      Code = "350SD",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1144,
      NameEn = "350SDL",
      NameAr = "350SDL",
      Code = "350SDL",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1145,
      NameEn = "380SE",
      NameAr = "380SE",
      Code = "380SE",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1146,
      NameEn = "380SEC",
      NameAr = "380SEC",
      Code = "380SEC",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1147,
      NameEn = "380SEL",
      NameAr = "380SEL",
      Code = "380SEL",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1148,
      NameEn = "400SE",
      NameAr = "400SE",
      Code = "400SE",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1149,
      NameEn = "400SEL",
      NameAr = "400SEL",
      Code = "400SEL",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1150,
      NameEn = "420SEL",
      NameAr = "420SEL",
      Code = "420SEL",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1151,
      NameEn = "500SEC",
      NameAr = "500SEC",
      Code = "500SEC",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1152,
      NameEn = "500SEL",
      NameAr = "500SEL",
      Code = "500SEL",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1153,
      NameEn = "560SEC",
      NameAr = "560SEC",
      Code = "560SEC",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1154,
      NameEn = "560SEL",
      NameAr = "560SEL",
      Code = "560SEL",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1155,
      NameEn = "600SEC",
      NameAr = "600SEC",
      Code = "600SEC",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1156,
      NameEn = "600SEL",
      NameAr = "600SEL",
      Code = "600SEL",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1157,
      NameEn = "S320",
      NameAr = "S320",
      Code = "S320",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1158,
      NameEn = "S350",
      NameAr = "S350",
      Code = "S350",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1159,
      NameEn = "S350 Bluetec",
      NameAr = "S350 Bluetec",
      Code = "S350 Bluetec",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1160,
      NameEn = "S400 Hybrid",
      NameAr = "S400 Hybrid",
      Code = "S400 Hybrid",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1161,
      NameEn = "S420",
      NameAr = "S420",
      Code = "S420",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1162,
      NameEn = "S430",
      NameAr = "S430",
      Code = "S430",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1163,
      NameEn = "S500",
      NameAr = "S500",
      Code = "S500",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1164,
      NameEn = "S550",
      NameAr = "S550",
      Code = "S550",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1165,
      NameEn = "S55 AMG",
      NameAr = "S55 AMG",
      Code = "S55 AMG",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1166,
      NameEn = "S600",
      NameAr = "S600",
      Code = "S600",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1167,
      NameEn = "S63 AMG",
      NameAr = "S63 AMG",
      Code = "S63 AMG",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1168,
      NameEn = "S65 AMG",
      NameAr = "S65 AMG",
      Code = "S65 AMG",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1169,
      NameEn = "300SL",
      NameAr = "300SL",
      Code = "300SL",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1170,
      NameEn = "380SL",
      NameAr = "380SL",
      Code = "380SL",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1171,
      NameEn = "380SLC",
      NameAr = "380SLC",
      Code = "380SLC",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1172,
      NameEn = "500SL",
      NameAr = "500SL",
      Code = "500SL",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1173,
      NameEn = "560SL",
      NameAr = "560SL",
      Code = "560SL",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1174,
      NameEn = "600SL",
      NameAr = "600SL",
      Code = "600SL",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1175,
      NameEn = "SL320",
      NameAr = "SL320",
      Code = "SL320",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1176,
      NameEn = "SL500",
      NameAr = "SL500",
      Code = "SL500",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1177,
      NameEn = "SL550",
      NameAr = "SL550",
      Code = "SL550",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1178,
      NameEn = "SL55 AMG",
      NameAr = "SL55 AMG",
      Code = "SL55 AMG",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1179,
      NameEn = "SL600",
      NameAr = "SL600",
      Code = "SL600",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1180,
      NameEn = "SL63 AMG",
      NameAr = "SL63 AMG",
      Code = "SL63 AMG",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1181,
      NameEn = "SL65 AMG",
      NameAr = "SL65 AMG",
      Code = "SL65 AMG",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1182,
      NameEn = "SLK230",
      NameAr = "SLK230",
      Code = "SLK230",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1183,
      NameEn = "SLK250",
      NameAr = "SLK250",
      Code = "SLK250",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1184,
      NameEn = "SLK280",
      NameAr = "SLK280",
      Code = "SLK280",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1185,
      NameEn = "SLK300",
      NameAr = "SLK300",
      Code = "SLK300",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1186,
      NameEn = "SLK320",
      NameAr = "SLK320",
      Code = "SLK320",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1187,
      NameEn = "SLK32 AMG",
      NameAr = "SLK32 AMG",
      Code = "SLK32 AMG",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1188,
      NameEn = "SLK350",
      NameAr = "SLK350",
      Code = "SLK350",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1189,
      NameEn = "SLK55 AMG",
      NameAr = "SLK55 AMG",
      Code = "SLK55 AMG",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1190,
      NameEn = "SLR",
      NameAr = "SLR",
      Code = "SLR",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1191,
      NameEn = "SLS AMG",
      NameAr = "SLS AMG",
      Code = "SLS AMG",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1192,
      NameEn = "Sprinter",
      NameAr = "Sprinter",
      Code = "Sprinter",
      ParentCode = "Mercedes-Benz",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1193,
      NameEn = "Capri",
      NameAr = "Capri",
      Code = "Capri",
      ParentCode = "Mercury",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1194,
      NameEn = "Cougar",
      NameAr = "Cougar",
      Code = "Cougar",
      ParentCode = "Mercury",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1195,
      NameEn = "Grand Marquis",
      NameAr = "Grand Marquis",
      Code = "Grand Marquis",
      ParentCode = "Mercury",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1196,
      NameEn = "Lynx",
      NameAr = "Lynx",
      Code = "Lynx",
      ParentCode = "Mercury",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1197,
      NameEn = "Marauder",
      NameAr = "Marauder",
      Code = "Marauder",
      ParentCode = "Mercury",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1198,
      NameEn = "Mariner",
      NameAr = "Mariner",
      Code = "Mariner",
      ParentCode = "Mercury",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1199,
      NameEn = "Marquis",
      NameAr = "Marquis",
      Code = "Marquis",
      ParentCode = "Mercury",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1200,
      NameEn = "Milan",
      NameAr = "Milan",
      Code = "Milan",
      ParentCode = "Mercury",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1201,
      NameEn = "Montego",
      NameAr = "Montego",
      Code = "Montego",
      ParentCode = "Mercury",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1202,
      NameEn = "Monterey",
      NameAr = "Monterey",
      Code = "Monterey",
      ParentCode = "Mercury",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1203,
      NameEn = "Mountaineer",
      NameAr = "Mountaineer",
      Code = "Mountaineer",
      ParentCode = "Mercury",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1204,
      NameEn = "Mystique",
      NameAr = "Mystique",
      Code = "Mystique",
      ParentCode = "Mercury",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1205,
      NameEn = "Sable",
      NameAr = "Sable",
      Code = "Sable",
      ParentCode = "Mercury",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1206,
      NameEn = "Topaz",
      NameAr = "Topaz",
      Code = "Topaz",
      ParentCode = "Mercury",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1207,
      NameEn = "Tracer",
      NameAr = "Tracer",
      Code = "Tracer",
      ParentCode = "Mercury",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1208,
      NameEn = "Villager",
      NameAr = "Villager",
      Code = "Villager",
      ParentCode = "Mercury",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1209,
      NameEn = "Zephyr",
      NameAr = "Zephyr",
      Code = "Zephyr",
      ParentCode = "Mercury",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1210,
      NameEn = "Scorpio",
      NameAr = "Scorpio",
      Code = "Scorpio",
      ParentCode = "Merkur",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1211,
      NameEn = "XR4Ti",
      NameAr = "XR4Ti",
      Code = "XR4Ti",
      ParentCode = "Merkur",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1212,
      NameEn = "Cooper Clubman",
      NameAr = "Cooper Clubman",
      Code = "Cooper Clubman",
      ParentCode = "MINI",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1213,
      NameEn = "Cooper S Clubman",
      NameAr = "Cooper S Clubman",
      Code = "Cooper S Clubman",
      ParentCode = "MINI",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1214,
      NameEn = "Cooper Countryman",
      NameAr = "Cooper Countryman",
      Code = "Cooper Countryman",
      ParentCode = "MINI",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1215,
      NameEn = "Cooper S Countryman",
      NameAr = "Cooper S Countryman",
      Code = "Cooper S Countryman",
      ParentCode = "MINI",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1216,
      NameEn = "Cooper Coupe",
      NameAr = "Cooper Coupe",
      Code = "Cooper Coupe",
      ParentCode = "MINI",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1217,
      NameEn = "Cooper S Coupe",
      NameAr = "Cooper S Coupe",
      Code = "Cooper S Coupe",
      ParentCode = "MINI",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1218,
      NameEn = "Cooper",
      NameAr = "Cooper",
      Code = "Cooper",
      ParentCode = "MINI",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1219,
      NameEn = "Cooper S",
      NameAr = "Cooper S",
      Code = "Cooper S",
      ParentCode = "MINI",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1220,
      NameEn = "Cooper Roadster",
      NameAr = "Cooper Roadster",
      Code = "Cooper Roadster",
      ParentCode = "MINI",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1221,
      NameEn = "Cooper S Roadster",
      NameAr = "Cooper S Roadster",
      Code = "Cooper S Roadster",
      ParentCode = "MINI",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1222,
      NameEn = "3000GT",
      NameAr = "3000GT",
      Code = "3000GT",
      ParentCode = "Mitsubishi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1223,
      NameEn = "Cordia",
      NameAr = "Cordia",
      Code = "Cordia",
      ParentCode = "Mitsubishi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1224,
      NameEn = "Diamante",
      NameAr = "Diamante",
      Code = "Diamante",
      ParentCode = "Mitsubishi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1225,
      NameEn = "Eclipse",
      NameAr = "Eclipse",
      Code = "Eclipse",
      ParentCode = "Mitsubishi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1226,
      NameEn = "Endeavor",
      NameAr = "Endeavor",
      Code = "Endeavor",
      ParentCode = "Mitsubishi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1227,
      NameEn = "Expo",
      NameAr = "Expo",
      Code = "Expo",
      ParentCode = "Mitsubishi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1228,
      NameEn = "Galant",
      NameAr = "Galant",
      Code = "Galant",
      ParentCode = "Mitsubishi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1229,
      NameEn = "i",
      NameAr = "i",
      Code = "i",
      ParentCode = "Mitsubishi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1230,
      NameEn = "Lancer",
      NameAr = "Lancer",
      Code = "Lancer",
      ParentCode = "Mitsubishi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1231,
      NameEn = "Lancer Evolution",
      NameAr = "Lancer Evolution",
      Code = "Lancer Evolution",
      ParentCode = "Mitsubishi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1232,
      NameEn = "Mighty Max",
      NameAr = "Mighty Max",
      Code = "Mighty Max",
      ParentCode = "Mitsubishi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1233,
      NameEn = "Mirage",
      NameAr = "Mirage",
      Code = "Mirage",
      ParentCode = "Mitsubishi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1234,
      NameEn = "Montero",
      NameAr = "Montero",
      Code = "Montero",
      ParentCode = "Mitsubishi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1235,
      NameEn = "Montero Sport",
      NameAr = "Montero Sport",
      Code = "Montero Sport",
      ParentCode = "Mitsubishi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1236,
      NameEn = "Outlander",
      NameAr = "Outlander",
      Code = "Outlander",
      ParentCode = "Mitsubishi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1237,
      NameEn = "Outlander Sport",
      NameAr = "Outlander Sport",
      Code = "Outlander Sport",
      ParentCode = "Mitsubishi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1238,
      NameEn = "Precis",
      NameAr = "Precis",
      Code = "Precis",
      ParentCode = "Mitsubishi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1239,
      NameEn = "Raider",
      NameAr = "Raider",
      Code = "Raider",
      ParentCode = "Mitsubishi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1240,
      NameEn = "Sigma",
      NameAr = "Sigma",
      Code = "Sigma",
      ParentCode = "Mitsubishi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1241,
      NameEn = "Starion",
      NameAr = "Starion",
      Code = "Starion",
      ParentCode = "Mitsubishi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1242,
      NameEn = "Tredia",
      NameAr = "Tredia",
      Code = "Tredia",
      ParentCode = "Mitsubishi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1243,
      NameEn = "Van",
      NameAr = "Van",
      Code = "Van",
      ParentCode = "Mitsubishi",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1244,
      NameEn = "200SX",
      NameAr = "200SX",
      Code = "200SX",
      ParentCode = "Nissan",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1245,
      NameEn = "240SX",
      NameAr = "240SX",
      Code = "240SX",
      ParentCode = "Nissan",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1246,
      NameEn = "300ZX",
      NameAr = "300ZX",
      Code = "300ZX",
      ParentCode = "Nissan",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1247,
      NameEn = "350Z",
      NameAr = "350Z",
      Code = "350Z",
      ParentCode = "Nissan",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1248,
      NameEn = "370Z",
      NameAr = "370Z",
      Code = "370Z",
      ParentCode = "Nissan",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1249,
      NameEn = "Altima",
      NameAr = "Altima",
      Code = "Altima",
      ParentCode = "Nissan",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1250,
      NameEn = "sunny",
      NameAr = "sunny",
      Code = "sunny",
      ParentCode = "Nissan",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1251,
      NameEn = "Armada",
      NameAr = "Armada",
      Code = "Armada",
      ParentCode = "Nissan",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1252,
      NameEn = "Axxess",
      NameAr = "Axxess",
      Code = "Axxess",
      ParentCode = "Nissan",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1253,
      NameEn = "Cube",
      NameAr = "Cube",
      Code = "Cube",
      ParentCode = "Nissan",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1254,
      NameEn = "Frontier",
      NameAr = "Frontier",
      Code = "Frontier",
      ParentCode = "Nissan",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1255,
      NameEn = "GT-R",
      NameAr = "GT-R",
      Code = "GT-R",
      ParentCode = "Nissan",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1256,
      NameEn = "Juke",
      NameAr = "Juke",
      Code = "Juke",
      ParentCode = "Nissan",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1257,
      NameEn = "Leaf",
      NameAr = "Leaf",
      Code = "Leaf",
      ParentCode = "Nissan",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1258,
      NameEn = "Maxima",
      NameAr = "Maxima",
      Code = "Maxima",
      ParentCode = "Nissan",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1259,
      NameEn = "Murano",
      NameAr = "Murano",
      Code = "Murano",
      ParentCode = "Nissan",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1260,
      NameEn = "Murano CrossCabriolet",
      NameAr = "Murano CrossCabriolet",
      Code = "Murano CrossCabriolet",
      ParentCode = "Nissan",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1261,
      NameEn = "NV",
      NameAr = "NV",
      Code = "NV",
      ParentCode = "Nissan",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1262,
      NameEn = "NX",
      NameAr = "NX",
      Code = "NX",
      ParentCode = "Nissan",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1263,
      NameEn = "Pathfinder",
      NameAr = "Pathfinder",
      Code = "Pathfinder",
      ParentCode = "Nissan",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1264,
      NameEn = "Pickup",
      NameAr = "Pickup",
      Code = "Pickup",
      ParentCode = "Nissan",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1265,
      NameEn = "Pulsar",
      NameAr = "Pulsar",
      Code = "Pulsar",
      ParentCode = "Nissan",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1266,
      NameEn = "Quest",
      NameAr = "Quest",
      Code = "Quest",
      ParentCode = "Nissan",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1267,
      NameEn = "Rogue",
      NameAr = "Rogue",
      Code = "Rogue",
      ParentCode = "Nissan",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1268,
      NameEn = "Sentra",
      NameAr = "Sentra",
      Code = "Sentra",
      ParentCode = "Nissan",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1269,
      NameEn = "Stanza",
      NameAr = "Stanza",
      Code = "Stanza",
      ParentCode = "Nissan",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1270,
      NameEn = "Titan",
      NameAr = "Titan",
      Code = "Titan",
      ParentCode = "Nissan",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1271,
      NameEn = "Van",
      NameAr = "Van",
      Code = "Van",
      ParentCode = "Nissan",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1272,
      NameEn = "Versa",
      NameAr = "Versa",
      Code = "Versa",
      ParentCode = "Nissan",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1273,
      NameEn = "Xterra",
      NameAr = "Xterra",
      Code = "Xterra",
      ParentCode = "Nissan",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1274,
      NameEn = "88",
      NameAr = "88",
      Code = "88",
      ParentCode = "Oldsmobile",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1275,
      NameEn = "Achieva",
      NameAr = "Achieva",
      Code = "Achieva",
      ParentCode = "Oldsmobile",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1276,
      NameEn = "Alero",
      NameAr = "Alero",
      Code = "Alero",
      ParentCode = "Oldsmobile",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1277,
      NameEn = "Aurora",
      NameAr = "Aurora",
      Code = "Aurora",
      ParentCode = "Oldsmobile",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1278,
      NameEn = "Bravada",
      NameAr = "Bravada",
      Code = "Bravada",
      ParentCode = "Oldsmobile",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1279,
      NameEn = "Custom Cruiser",
      NameAr = "Custom Cruiser",
      Code = "Custom Cruiser",
      ParentCode = "Oldsmobile",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1280,
      NameEn = "Cutlass",
      NameAr = "Cutlass",
      Code = "Cutlass",
      ParentCode = "Oldsmobile",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1281,
      NameEn = "Cutlass Calais",
      NameAr = "Cutlass Calais",
      Code = "Cutlass Calais",
      ParentCode = "Oldsmobile",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1282,
      NameEn = "Cutlass Ciera",
      NameAr = "Cutlass Ciera",
      Code = "Cutlass Ciera",
      ParentCode = "Oldsmobile",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1283,
      NameEn = "Cutlass Supreme",
      NameAr = "Cutlass Supreme",
      Code = "Cutlass Supreme",
      ParentCode = "Oldsmobile",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1284,
      NameEn = "Firenza",
      NameAr = "Firenza",
      Code = "Firenza",
      ParentCode = "Oldsmobile",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1285,
      NameEn = "Intrigue",
      NameAr = "Intrigue",
      Code = "Intrigue",
      ParentCode = "Oldsmobile",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1286,
      NameEn = "Ninety-Eight",
      NameAr = "Ninety-Eight",
      Code = "Ninety-Eight",
      ParentCode = "Oldsmobile",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1287,
      NameEn = "Omega",
      NameAr = "Omega",
      Code = "Omega",
      ParentCode = "Oldsmobile",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1288,
      NameEn = "Regency",
      NameAr = "Regency",
      Code = "Regency",
      ParentCode = "Oldsmobile",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1289,
      NameEn = "Silhouette",
      NameAr = "Silhouette",
      Code = "Silhouette",
      ParentCode = "Oldsmobile",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1290,
      NameEn = "Toronado",
      NameAr = "Toronado",
      Code = "Toronado",
      ParentCode = "Oldsmobile",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1291,
      NameEn = "405",
      NameAr = "405",
      Code = "405",
      ParentCode = "Peugeot",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1292,
      NameEn = "504",
      NameAr = "504",
      Code = "504",
      ParentCode = "Peugeot",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1293,
      NameEn = "505",
      NameAr = "505",
      Code = "505",
      ParentCode = "Peugeot",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1294,
      NameEn = "604",
      NameAr = "604",
      Code = "604",
      ParentCode = "Peugeot",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1295,
      NameEn = "Acclaim",
      NameAr = "Acclaim",
      Code = "Acclaim",
      ParentCode = "Plymouth",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1296,
      NameEn = "Arrow",
      NameAr = "Arrow",
      Code = "Arrow",
      ParentCode = "Plymouth",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1297,
      NameEn = "Breeze",
      NameAr = "Breeze",
      Code = "Breeze",
      ParentCode = "Plymouth",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1298,
      NameEn = "Caravelle",
      NameAr = "Caravelle",
      Code = "Caravelle",
      ParentCode = "Plymouth",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1299,
      NameEn = "Champ",
      NameAr = "Champ",
      Code = "Champ",
      ParentCode = "Plymouth",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1300,
      NameEn = "Colt",
      NameAr = "Colt",
      Code = "Colt",
      ParentCode = "Plymouth",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1301,
      NameEn = "Conquest",
      NameAr = "Conquest",
      Code = "Conquest",
      ParentCode = "Plymouth",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1302,
      NameEn = "Gran Fury",
      NameAr = "Gran Fury",
      Code = "Gran Fury",
      ParentCode = "Plymouth",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1303,
      NameEn = "Grand Voyager",
      NameAr = "Grand Voyager",
      Code = "Grand Voyager",
      ParentCode = "Plymouth",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1304,
      NameEn = "Horizon",
      NameAr = "Horizon",
      Code = "Horizon",
      ParentCode = "Plymouth",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1305,
      NameEn = "Laser",
      NameAr = "Laser",
      Code = "Laser",
      ParentCode = "Plymouth",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1306,
      NameEn = "Neon",
      NameAr = "Neon",
      Code = "Neon",
      ParentCode = "Plymouth",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1307,
      NameEn = "Prowler",
      NameAr = "Prowler",
      Code = "Prowler",
      ParentCode = "Plymouth",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1308,
      NameEn = "Reliant",
      NameAr = "Reliant",
      Code = "Reliant",
      ParentCode = "Plymouth",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1309,
      NameEn = "Sapporo",
      NameAr = "Sapporo",
      Code = "Sapporo",
      ParentCode = "Plymouth",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1310,
      NameEn = "Scamp",
      NameAr = "Scamp",
      Code = "Scamp",
      ParentCode = "Plymouth",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1311,
      NameEn = "Sundance",
      NameAr = "Sundance",
      Code = "Sundance",
      ParentCode = "Plymouth",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1312,
      NameEn = "Trailduster",
      NameAr = "Trailduster",
      Code = "Trailduster",
      ParentCode = "Plymouth",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1313,
      NameEn = "Voyager",
      NameAr = "Voyager",
      Code = "Voyager",
      ParentCode = "Plymouth",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1314,
      NameEn = "1000",
      NameAr = "1000",
      Code = "1000",
      ParentCode = "Pontiac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1315,
      NameEn = "6000",
      NameAr = "6000",
      Code = "6000",
      ParentCode = "Pontiac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1316,
      NameEn = "Aztek",
      NameAr = "Aztek",
      Code = "Aztek",
      ParentCode = "Pontiac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1317,
      NameEn = "Bonneville",
      NameAr = "Bonneville",
      Code = "Bonneville",
      ParentCode = "Pontiac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1318,
      NameEn = "Catalina",
      NameAr = "Catalina",
      Code = "Catalina",
      ParentCode = "Pontiac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1319,
      NameEn = "Fiero",
      NameAr = "Fiero",
      Code = "Fiero",
      ParentCode = "Pontiac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1320,
      NameEn = "Firebird",
      NameAr = "Firebird",
      Code = "Firebird",
      ParentCode = "Pontiac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1321,
      NameEn = "G3",
      NameAr = "G3",
      Code = "G3",
      ParentCode = "Pontiac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1322,
      NameEn = "G5",
      NameAr = "G5",
      Code = "G5",
      ParentCode = "Pontiac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1323,
      NameEn = "G6",
      NameAr = "G6",
      Code = "G6",
      ParentCode = "Pontiac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1324,
      NameEn = "G8",
      NameAr = "G8",
      Code = "G8",
      ParentCode = "Pontiac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1325,
      NameEn = "Grand Am",
      NameAr = "Grand Am",
      Code = "Grand Am",
      ParentCode = "Pontiac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1326,
      NameEn = "Grand Prix",
      NameAr = "Grand Prix",
      Code = "Grand Prix",
      ParentCode = "Pontiac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1327,
      NameEn = "GTO",
      NameAr = "GTO",
      Code = "GTO",
      ParentCode = "Pontiac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1328,
      NameEn = "J2000",
      NameAr = "J2000",
      Code = "J2000",
      ParentCode = "Pontiac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1329,
      NameEn = "Le Mans",
      NameAr = "Le Mans",
      Code = "Le Mans",
      ParentCode = "Pontiac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1330,
      NameEn = "Montana",
      NameAr = "Montana",
      Code = "Montana",
      ParentCode = "Pontiac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1331,
      NameEn = "Parisienne",
      NameAr = "Parisienne",
      Code = "Parisienne",
      ParentCode = "Pontiac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1332,
      NameEn = "Phoenix",
      NameAr = "Phoenix",
      Code = "Phoenix",
      ParentCode = "Pontiac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1333,
      NameEn = "Safari",
      NameAr = "Safari",
      Code = "Safari",
      ParentCode = "Pontiac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1334,
      NameEn = "Solstice",
      NameAr = "Solstice",
      Code = "Solstice",
      ParentCode = "Pontiac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1335,
      NameEn = "Sunbird",
      NameAr = "Sunbird",
      Code = "Sunbird",
      ParentCode = "Pontiac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1336,
      NameEn = "Sunfire",
      NameAr = "Sunfire",
      Code = "Sunfire",
      ParentCode = "Pontiac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1337,
      NameEn = "Torrent",
      NameAr = "Torrent",
      Code = "Torrent",
      ParentCode = "Pontiac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1338,
      NameEn = "Trans Sport",
      NameAr = "Trans Sport",
      Code = "Trans Sport",
      ParentCode = "Pontiac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1339,
      NameEn = "Vibe",
      NameAr = "Vibe",
      Code = "Vibe",
      ParentCode = "Pontiac",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1340,
      NameEn = "911",
      NameAr = "911",
      Code = "911",
      ParentCode = "Porsche",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1341,
      NameEn = "924",
      NameAr = "924",
      Code = "924",
      ParentCode = "Porsche",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1342,
      NameEn = "928",
      NameAr = "928",
      Code = "928",
      ParentCode = "Porsche",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1343,
      NameEn = "944",
      NameAr = "944",
      Code = "944",
      ParentCode = "Porsche",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1344,
      NameEn = "968",
      NameAr = "968",
      Code = "968",
      ParentCode = "Porsche",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1345,
      NameEn = "Boxster",
      NameAr = "Boxster",
      Code = "Boxster",
      ParentCode = "Porsche",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1346,
      NameEn = "Carrera GT",
      NameAr = "Carrera GT",
      Code = "Carrera GT",
      ParentCode = "Porsche",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1347,
      NameEn = "Cayenne",
      NameAr = "Cayenne",
      Code = "Cayenne",
      ParentCode = "Porsche",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1348,
      NameEn = "Cayman",
      NameAr = "Cayman",
      Code = "Cayman",
      ParentCode = "Porsche",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1349,
      NameEn = "Panamera",
      NameAr = "Panamera",
      Code = "Panamera",
      ParentCode = "Porsche",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1350,
      NameEn = "1500",
      NameAr = "1500",
      Code = "1500",
      ParentCode = "RAM",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1351,
      NameEn = "2500",
      NameAr = "2500",
      Code = "2500",
      ParentCode = "RAM",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1352,
      NameEn = "3500",
      NameAr = "3500",
      Code = "3500",
      ParentCode = "RAM",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1353,
      NameEn = "4500",
      NameAr = "4500",
      Code = "4500",
      ParentCode = "RAM",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1354,
      NameEn = "Agila",
      NameAr = "Agila",
      Code = "Agila",
      ParentCode = "Opel",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1355,
      NameEn = "Ampera",
      NameAr = "Ampera",
      Code = "Ampera",
      ParentCode = "Opel",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1356,
      NameEn = "Antara",
      NameAr = "Antara",
      Code = "Antara",
      ParentCode = "Opel",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1357,
      NameEn = "Astra",
      NameAr = "Astra",
      Code = "Astra",
      ParentCode = "Opel",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1358,
      NameEn = "Astra cabrio",
      NameAr = "Astra cabrio",
      Code = "Astra cabrio",
      ParentCode = "Opel",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1359,
      NameEn = "Astra caravan",
      NameAr = "Astra caravan",
      Code = "Astra caravan",
      ParentCode = "Opel",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1360,
      NameEn = "Astra coupé",
      NameAr = "Astra coupé",
      Code = "Astra coupé",
      ParentCode = "Opel",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1361,
      NameEn = "Calibra",
      NameAr = "Calibra",
      Code = "Calibra",
      ParentCode = "Opel",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1362,
      NameEn = "Campo",
      NameAr = "Campo",
      Code = "Campo",
      ParentCode = "Opel",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1363,
      NameEn = "Cascada",
      NameAr = "Cascada",
      Code = "Cascada",
      ParentCode = "Opel",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1364,
      NameEn = "Corsa",
      NameAr = "Corsa",
      Code = "Corsa",
      ParentCode = "Opel",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1365,
      NameEn = "Frontera",
      NameAr = "Frontera",
      Code = "Frontera",
      ParentCode = "Opel",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1366,
      NameEn = "Insignia",
      NameAr = "Insignia",
      Code = "Insignia",
      ParentCode = "Opel",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1367,
      NameEn = "Insignia kombi",
      NameAr = "Insignia kombi",
      Code = "Insignia kombi",
      ParentCode = "Opel",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1368,
      NameEn = "Kadett",
      NameAr = "Kadett",
      Code = "Kadett",
      ParentCode = "Opel",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1369,
      NameEn = "Meriva",
      NameAr = "Meriva",
      Code = "Meriva",
      ParentCode = "Opel",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1370,
      NameEn = "Mokka",
      NameAr = "Mokka",
      Code = "Mokka",
      ParentCode = "Opel",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1371,
      NameEn = "Movano",
      NameAr = "Movano",
      Code = "Movano",
      ParentCode = "Opel",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1372,
      NameEn = "Omega",
      NameAr = "Omega",
      Code = "Omega",
      ParentCode = "Opel",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1373,
      NameEn = "Signum",
      NameAr = "Signum",
      Code = "Signum",
      ParentCode = "Opel",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1374,
      NameEn = "Vectra",
      NameAr = "Vectra",
      Code = "Vectra",
      ParentCode = "Opel",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1375,
      NameEn = "Vectra Caravan",
      NameAr = "Vectra Caravan",
      Code = "Vectra Caravan",
      ParentCode = "Opel",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1376,
      NameEn = "Vivaro",
      NameAr = "Vivaro",
      Code = "Vivaro",
      ParentCode = "Opel",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1377,
      NameEn = "Vivaro Kombi",
      NameAr = "Vivaro Kombi",
      Code = "Vivaro Kombi",
      ParentCode = "Opel",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1378,
      NameEn = "Zafira",
      NameAr = "Zafira",
      Code = "Zafira",
      ParentCode = "Opel",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1379,
      NameEn = "Berlingo",
      NameAr = "Berlingo",
      Code = "Berlingo",
      ParentCode = "Citroën",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1380,
      NameEn = "C-Crosser",
      NameAr = "C-Crosser",
      Code = "C-Crosser",
      ParentCode = "Citroën",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1381,
      NameEn = "C-Elissée",
      NameAr = "C-Elissée",
      Code = "C-Elissée",
      ParentCode = "Citroën",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1382,
      NameEn = "C-Zero",
      NameAr = "C-Zero",
      Code = "C-Zero",
      ParentCode = "Citroën",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1383,
      NameEn = "C1",
      NameAr = "C1",
      Code = "C1",
      ParentCode = "Citroën",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1384,
      NameEn = "C2",
      NameAr = "C2",
      Code = "C2",
      ParentCode = "Citroën",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1385,
      NameEn = "C3",
      NameAr = "C3",
      Code = "C3",
      ParentCode = "Citroën",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1386,
      NameEn = "C3 Picasso",
      NameAr = "C3 Picasso",
      Code = "C3 Picasso",
      ParentCode = "Citroën",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1387,
      NameEn = "C4",
      NameAr = "C4",
      Code = "C4",
      ParentCode = "Citroën",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1388,
      NameEn = "C4 Aircross",
      NameAr = "C4 Aircross",
      Code = "C4 Aircross",
      ParentCode = "Citroën",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1389,
      NameEn = "C4 Cactus",
      NameAr = "C4 Cactus",
      Code = "C4 Cactus",
      ParentCode = "Citroën",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1390,
      NameEn = "C4 Coupé",
      NameAr = "C4 Coupé",
      Code = "C4 Coupé",
      ParentCode = "Citroën",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1391,
      NameEn = "C4 Grand Picasso",
      NameAr = "C4 Grand Picasso",
      Code = "C4 Grand Picasso",
      ParentCode = "Citroën",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1392,
      NameEn = "C4 Sedan",
      NameAr = "C4 Sedan",
      Code = "C4 Sedan",
      ParentCode = "Citroën",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1393,
      NameEn = "C5",
      NameAr = "C5",
      Code = "C5",
      ParentCode = "Citroën",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1394,
      NameEn = "C5 Break",
      NameAr = "C5 Break",
      Code = "C5 Break",
      ParentCode = "Citroën",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1395,
      NameEn = "C5 Tourer",
      NameAr = "C5 Tourer",
      Code = "C5 Tourer",
      ParentCode = "Citroën",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1396,
      NameEn = "C6",
      NameAr = "C6",
      Code = "C6",
      ParentCode = "Citroën",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1397,
      NameEn = "C8",
      NameAr = "C8",
      Code = "C8",
      ParentCode = "Citroën",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1398,
      NameEn = "DS3",
      NameAr = "DS3",
      Code = "DS3",
      ParentCode = "Citroën",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1399,
      NameEn = "DS4",
      NameAr = "DS4",
      Code = "DS4",
      ParentCode = "Citroën",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1400,
      NameEn = "DS5",
      NameAr = "DS5",
      Code = "DS5",
      ParentCode = "Citroën",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1401,
      NameEn = "Evasion",
      NameAr = "Evasion",
      Code = "Evasion",
      ParentCode = "Citroën",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1402,
      NameEn = "Jumper",
      NameAr = "Jumper",
      Code = "Jumper",
      ParentCode = "Citroën",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1403,
      NameEn = "Jumpy",
      NameAr = "Jumpy",
      Code = "Jumpy",
      ParentCode = "Citroën",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1404,
      NameEn = "Saxo",
      NameAr = "Saxo",
      Code = "Saxo",
      ParentCode = "Citroën",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1405,
      NameEn = "Nemo",
      NameAr = "Nemo",
      Code = "Nemo",
      ParentCode = "Citroën",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1406,
      NameEn = "Xantia",
      NameAr = "Xantia",
      Code = "Xantia",
      ParentCode = "Citroën",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1407,
      NameEn = "Xsara",
      NameAr = "Xsara",
      Code = "Xsara",
      ParentCode = "Citroën",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1408,
      NameEn = "18i",
      NameAr = "18i",
      Code = "18i",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1409,
      NameEn = "Fuego",
      NameAr = "Fuego",
      Code = "Fuego",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1410,
      NameEn = "Le Car",
      NameAr = "Le Car",
      Code = "Le Car",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1411,
      NameEn = "R18",
      NameAr = "R18",
      Code = "R18",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1412,
      NameEn = "Sportwagon",
      NameAr = "Sportwagon",
      Code = "Sportwagon",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1413,
      NameEn = "Captur",
      NameAr = "Captur",
      Code = "Captur",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1414,
      NameEn = "Clio",
      NameAr = "Clio",
      Code = "Clio",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1415,
      NameEn = "Clio Grandtour",
      NameAr = "Clio Grandtour",
      Code = "Clio Grandtour",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1416,
      NameEn = "Espace",
      NameAr = "Espace",
      Code = "Espace",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1417,
      NameEn = "Express",
      NameAr = "Express",
      Code = "Express",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1418,
      NameEn = "Fluence",
      NameAr = "Fluence",
      Code = "Fluence",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1419,
      NameEn = "Grand Espace",
      NameAr = "Grand Espace",
      Code = "Grand Espace",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1420,
      NameEn = "Grand Modus",
      NameAr = "Grand Modus",
      Code = "Grand Modus",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1421,
      NameEn = "Grand Scenic",
      NameAr = "Grand Scenic",
      Code = "Grand Scenic",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1422,
      NameEn = "Kadjar",
      NameAr = "Kadjar",
      Code = "Kadjar",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1423,
      NameEn = "Kangoo",
      NameAr = "Kangoo",
      Code = "Kangoo",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1424,
      NameEn = "Kangoo Express",
      NameAr = "Kangoo Express",
      Code = "Kangoo Express",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1425,
      NameEn = "Koleos",
      NameAr = "Koleos",
      Code = "Koleos",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1426,
      NameEn = "Laguna",
      NameAr = "Laguna",
      Code = "Laguna",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1427,
      NameEn = "Laguna Grandtour",
      NameAr = "Laguna Grandtour",
      Code = "Laguna Grandtour",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1428,
      NameEn = "Latitude",
      NameAr = "Latitude",
      Code = "Latitude",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1429,
      NameEn = "Mascott",
      NameAr = "Mascott",
      Code = "Mascott",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1430,
      NameEn = "Mégane",
      NameAr = "Mégane",
      Code = "Mégane",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1431,
      NameEn = "Mégane CC",
      NameAr = "Mégane CC",
      Code = "Mégane CC",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1432,
      NameEn = "Mégane Combi",
      NameAr = "Mégane Combi",
      Code = "Mégane Combi",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1433,
      NameEn = "Mégane Grandtour",
      NameAr = "Mégane Grandtour",
      Code = "Mégane Grandtour",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1434,
      NameEn = "Mégane Coupé",
      NameAr = "Mégane Coupé",
      Code = "Mégane Coupé",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1435,
      NameEn = "Mégane Scénic",
      NameAr = "Mégane Scénic",
      Code = "Mégane Scénic",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1436,
      NameEn = "Scénic",
      NameAr = "Scénic",
      Code = "Scénic",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1437,
      NameEn = "Talisman",
      NameAr = "Talisman",
      Code = "Talisman",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1438,
      NameEn = "Talisman Grandtour",
      NameAr = "Talisman Grandtour",
      Code = "Talisman Grandtour",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1439,
      NameEn = "Thalia",
      NameAr = "Thalia",
      Code = "Thalia",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1440,
      NameEn = "Twingo",
      NameAr = "Twingo",
      Code = "Twingo",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1441,
      NameEn = "Wind",
      NameAr = "Wind",
      Code = "Wind",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1442,
      NameEn = "Zoé",
      NameAr = "Zoé",
      Code = "Zoé",
      ParentCode = "Renault",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1443,
      NameEn = "Camargue",
      NameAr = "Camargue",
      Code = "Camargue",
      ParentCode = "Rolls-Royce",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1444,
      NameEn = "Corniche",
      NameAr = "Corniche",
      Code = "Corniche",
      ParentCode = "Rolls-Royce",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1445,
      NameEn = "Ghost",
      NameAr = "Ghost",
      Code = "Ghost",
      ParentCode = "Rolls-Royce",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1446,
      NameEn = "Park Ward",
      NameAr = "Park Ward",
      Code = "Park Ward",
      ParentCode = "Rolls-Royce",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1447,
      NameEn = "Phantom",
      NameAr = "Phantom",
      Code = "Phantom",
      ParentCode = "Rolls-Royce",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1448,
      NameEn = "Silver Dawn",
      NameAr = "Silver Dawn",
      Code = "Silver Dawn",
      ParentCode = "Rolls-Royce",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1449,
      NameEn = "Silver Seraph",
      NameAr = "Silver Seraph",
      Code = "Silver Seraph",
      ParentCode = "Rolls-Royce",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1450,
      NameEn = "Silver Spirit",
      NameAr = "Silver Spirit",
      Code = "Silver Spirit",
      ParentCode = "Rolls-Royce",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1451,
      NameEn = "Silver Spur",
      NameAr = "Silver Spur",
      Code = "Silver Spur",
      ParentCode = "Rolls-Royce",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1452,
      NameEn = "9-2X",
      NameAr = "9-2X",
      Code = "9-2X",
      ParentCode = "Saab",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1453,
      NameEn = "9-3",
      NameAr = "9-3",
      Code = "9-3",
      ParentCode = "Saab",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1454,
      NameEn = "9-4X",
      NameAr = "9-4X",
      Code = "9-4X",
      ParentCode = "Saab",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1455,
      NameEn = "9-5",
      NameAr = "9-5",
      Code = "9-5",
      ParentCode = "Saab",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1456,
      NameEn = "9-7X",
      NameAr = "9-7X",
      Code = "9-7X",
      ParentCode = "Saab",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1457,
      NameEn = "900",
      NameAr = "900",
      Code = "900",
      ParentCode = "Saab",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1458,
      NameEn = "9000",
      NameAr = "9000",
      Code = "9000",
      ParentCode = "Saab",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1459,
      NameEn = "Astra",
      NameAr = "Astra",
      Code = "Astra",
      ParentCode = "Saturn",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1460,
      NameEn = "Aura",
      NameAr = "Aura",
      Code = "Aura",
      ParentCode = "Saturn",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1461,
      NameEn = "ION",
      NameAr = "ION",
      Code = "ION",
      ParentCode = "Saturn",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1462,
      NameEn = "L100",
      NameAr = "L100",
      Code = "L100",
      ParentCode = "Saturn",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1463,
      NameEn = "L200",
      NameAr = "L200",
      Code = "L200",
      ParentCode = "Saturn",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1464,
      NameEn = "L300",
      NameAr = "L300",
      Code = "L300",
      ParentCode = "Saturn",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1465,
      NameEn = "LS",
      NameAr = "LS",
      Code = "LS",
      ParentCode = "Saturn",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1466,
      NameEn = "LW1",
      NameAr = "LW1",
      Code = "LW1",
      ParentCode = "Saturn",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1467,
      NameEn = "LW2",
      NameAr = "LW2",
      Code = "LW2",
      ParentCode = "Saturn",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1468,
      NameEn = "LW200",
      NameAr = "LW200",
      Code = "LW200",
      ParentCode = "Saturn",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1469,
      NameEn = "LW300",
      NameAr = "LW300",
      Code = "LW300",
      ParentCode = "Saturn",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1470,
      NameEn = "Outlook",
      NameAr = "Outlook",
      Code = "Outlook",
      ParentCode = "Saturn",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1471,
      NameEn = "Relay",
      NameAr = "Relay",
      Code = "Relay",
      ParentCode = "Saturn",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1472,
      NameEn = "SC1",
      NameAr = "SC1",
      Code = "SC1",
      ParentCode = "Saturn",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1473,
      NameEn = "SC2",
      NameAr = "SC2",
      Code = "SC2",
      ParentCode = "Saturn",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1474,
      NameEn = "Sky",
      NameAr = "Sky",
      Code = "Sky",
      ParentCode = "Saturn",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1475,
      NameEn = "SL",
      NameAr = "SL",
      Code = "SL",
      ParentCode = "Saturn",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1476,
      NameEn = "SL1",
      NameAr = "SL1",
      Code = "SL1",
      ParentCode = "Saturn",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1477,
      NameEn = "SL2",
      NameAr = "SL2",
      Code = "SL2",
      ParentCode = "Saturn",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1478,
      NameEn = "SW1",
      NameAr = "SW1",
      Code = "SW1",
      ParentCode = "Saturn",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1479,
      NameEn = "SW2",
      NameAr = "SW2",
      Code = "SW2",
      ParentCode = "Saturn",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1480,
      NameEn = "Vue",
      NameAr = "Vue",
      Code = "Vue",
      ParentCode = "Saturn",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1481,
      NameEn = "FR-S",
      NameAr = "FR-S",
      Code = "FR-S",
      ParentCode = "Scion",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1482,
      NameEn = "iQ",
      NameAr = "iQ",
      Code = "iQ",
      ParentCode = "Scion",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1483,
      NameEn = "tC",
      NameAr = "tC",
      Code = "tC",
      ParentCode = "Scion",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1484,
      NameEn = "xA",
      NameAr = "xA",
      Code = "xA",
      ParentCode = "Scion",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1485,
      NameEn = "xB",
      NameAr = "xB",
      Code = "xB",
      ParentCode = "Scion",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1486,
      NameEn = "xD",
      NameAr = "xD",
      Code = "xD",
      ParentCode = "Scion",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1487,
      NameEn = "fortwo",
      NameAr = "fortwo",
      Code = "fortwo",
      ParentCode = "smart",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1488,
      NameEn = "Viper",
      NameAr = "Viper",
      Code = "Viper",
      ParentCode = "SRT",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1489,
      NameEn = "825",
      NameAr = "825",
      Code = "825",
      ParentCode = "Sterling",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1490,
      NameEn = "827",
      NameAr = "827",
      Code = "827",
      ParentCode = "Sterling",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1491,
      NameEn = "Baja",
      NameAr = "Baja",
      Code = "Baja",
      ParentCode = "Subaru",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1492,
      NameEn = "Brat",
      NameAr = "Brat",
      Code = "Brat",
      ParentCode = "Subaru",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1493,
      NameEn = "BRZ",
      NameAr = "BRZ",
      Code = "BRZ",
      ParentCode = "Subaru",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1494,
      NameEn = "Forester",
      NameAr = "Forester",
      Code = "Forester",
      ParentCode = "Subaru",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1495,
      NameEn = "Impreza",
      NameAr = "Impreza",
      Code = "Impreza",
      ParentCode = "Subaru",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1496,
      NameEn = "Impreza WRX",
      NameAr = "Impreza WRX",
      Code = "Impreza WRX",
      ParentCode = "Subaru",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1497,
      NameEn = "Justy",
      NameAr = "Justy",
      Code = "Justy",
      ParentCode = "Subaru",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1498,
      NameEn = "L Series",
      NameAr = "L Series",
      Code = "L Series",
      ParentCode = "Subaru",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1499,
      NameEn = "Legacy",
      NameAr = "Legacy",
      Code = "Legacy",
      ParentCode = "Subaru",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1500,
      NameEn = "Loyale",
      NameAr = "Loyale",
      Code = "Loyale",
      ParentCode = "Subaru",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1501,
      NameEn = "Outback",
      NameAr = "Outback",
      Code = "Outback",
      ParentCode = "Subaru",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1502,
      NameEn = "SVX",
      NameAr = "SVX",
      Code = "SVX",
      ParentCode = "Subaru",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1503,
      NameEn = "Tribeca",
      NameAr = "Tribeca",
      Code = "Tribeca",
      ParentCode = "Subaru",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1504,
      NameEn = "XT",
      NameAr = "XT",
      Code = "XT",
      ParentCode = "Subaru",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1505,
      NameEn = "XV Crosstrek",
      NameAr = "XV Crosstrek",
      Code = "XV Crosstrek",
      ParentCode = "Subaru",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1506,
      NameEn = "Aerio",
      NameAr = "Aerio",
      Code = "Aerio",
      ParentCode = "Suzuki",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1507,
      NameEn = "Equator",
      NameAr = "Equator",
      Code = "Equator",
      ParentCode = "Suzuki",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1508,
      NameEn = "Esteem",
      NameAr = "Esteem",
      Code = "Esteem",
      ParentCode = "Suzuki",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1509,
      NameEn = "Forenza",
      NameAr = "Forenza",
      Code = "Forenza",
      ParentCode = "Suzuki",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1510,
      NameEn = "Grand Vitara",
      NameAr = "Grand Vitara",
      Code = "Grand Vitara",
      ParentCode = "Suzuki",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1511,
      NameEn = "Kizashi",
      NameAr = "Kizashi",
      Code = "Kizashi",
      ParentCode = "Suzuki",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1512,
      NameEn = "Reno",
      NameAr = "Reno",
      Code = "Reno",
      ParentCode = "Suzuki",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1513,
      NameEn = "Samurai",
      NameAr = "Samurai",
      Code = "Samurai",
      ParentCode = "Suzuki",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1514,
      NameEn = "Sidekick",
      NameAr = "Sidekick",
      Code = "Sidekick",
      ParentCode = "Suzuki",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1515,
      NameEn = "Swift",
      NameAr = "Swift",
      Code = "Swift",
      ParentCode = "Suzuki",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1516,
      NameEn = "SX4",
      NameAr = "SX4",
      Code = "SX4",
      ParentCode = "Suzuki",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1517,
      NameEn = "Verona",
      NameAr = "Verona",
      Code = "Verona",
      ParentCode = "Suzuki",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1518,
      NameEn = "Vitara",
      NameAr = "Vitara",
      Code = "Vitara",
      ParentCode = "Suzuki",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1519,
      NameEn = "X-90",
      NameAr = "X-90",
      Code = "X-90",
      ParentCode = "Suzuki",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1520,
      NameEn = "XL7",
      NameAr = "XL7",
      Code = "XL7",
      ParentCode = "Suzuki",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1521,
      NameEn = "Roadster",
      NameAr = "Roadster",
      Code = "Roadster",
      ParentCode = "Tesla",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1522,
      NameEn = "Model S",
      NameAr = "Model S",
      Code = "Model S",
      ParentCode = "Tesla",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1523,
      NameEn = "4Runner",
      NameAr = "4Runner",
      Code = "4Runner",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1524,
      NameEn = "Avalon",
      NameAr = "Avalon",
      Code = "Avalon",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1525,
      NameEn = "Camry",
      NameAr = "Camry",
      Code = "Camry",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1526,
      NameEn = "Celica",
      NameAr = "Celica",
      Code = "Celica",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1527,
      NameEn = "Corolla",
      NameAr = "Corolla",
      Code = "Corolla",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1528,
      NameEn = "Corona",
      NameAr = "Corona",
      Code = "Corona",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1529,
      NameEn = "Cressida",
      NameAr = "Cressida",
      Code = "Cressida",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1530,
      NameEn = "Echo",
      NameAr = "Echo",
      Code = "Echo",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1531,
      NameEn = "FJ Cruiser",
      NameAr = "FJ Cruiser",
      Code = "FJ Cruiser",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1532,
      NameEn = "Highlander",
      NameAr = "Highlander",
      Code = "Highlander",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1533,
      NameEn = "Land Cruiser",
      NameAr = "Land Cruiser",
      Code = "Land Cruiser",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1534,
      NameEn = "Matrix",
      NameAr = "Matrix",
      Code = "Matrix",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1535,
      NameEn = "MR2",
      NameAr = "MR2",
      Code = "MR2",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1536,
      NameEn = "MR2 Spyder",
      NameAr = "MR2 Spyder",
      Code = "MR2 Spyder",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1537,
      NameEn = "Paseo",
      NameAr = "Paseo",
      Code = "Paseo",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1538,
      NameEn = "Pickup",
      NameAr = "Pickup",
      Code = "Pickup",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1539,
      NameEn = "Previa",
      NameAr = "Previa",
      Code = "Previa",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1540,
      NameEn = "Prius",
      NameAr = "Prius",
      Code = "Prius",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1541,
      NameEn = "Prius C",
      NameAr = "Prius C",
      Code = "Prius C",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1542,
      NameEn = "Prius V",
      NameAr = "Prius V",
      Code = "Prius V",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1543,
      NameEn = "RAV4",
      NameAr = "RAV4",
      Code = "RAV4",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1544,
      NameEn = "Sequoia",
      NameAr = "Sequoia",
      Code = "Sequoia",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1545,
      NameEn = "Sienna",
      NameAr = "Sienna",
      Code = "Sienna",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1546,
      NameEn = "Solara",
      NameAr = "Solara",
      Code = "Solara",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1547,
      NameEn = "Starlet",
      NameAr = "Starlet",
      Code = "Starlet",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1548,
      NameEn = "Supra",
      NameAr = "Supra",
      Code = "Supra",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1549,
      NameEn = "T100",
      NameAr = "T100",
      Code = "T100",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1550,
      NameEn = "Tacoma",
      NameAr = "Tacoma",
      Code = "Tacoma",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1551,
      NameEn = "Tercel",
      NameAr = "Tercel",
      Code = "Tercel",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1552,
      NameEn = "Tundra",
      NameAr = "Tundra",
      Code = "Tundra",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1553,
      NameEn = "Van",
      NameAr = "Van",
      Code = "Van",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1554,
      NameEn = "Venza",
      NameAr = "Venza",
      Code = "Venza",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1555,
      NameEn = "Yaris",
      NameAr = "Yaris",
      Code = "Yaris",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1556,
      NameEn = "Belta",
      NameAr = "Belta",
      Code = "Belta",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1557,
      NameEn = "Allion",
      NameAr = "Allion",
      Code = "Allion",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1558,
      NameEn = "Fortuner",
      NameAr = "Fortuner",
      Code = "Fortuner",
      ParentCode = "Toyota",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1559,
      NameEn = "TR7",
      NameAr = "TR7",
      Code = "TR7",
      ParentCode = "Triumph",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1560,
      NameEn = "TR8",
      NameAr = "TR8",
      Code = "TR8",
      ParentCode = "Triumph",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1561,
      NameEn = "Beetle",
      NameAr = "Beetle",
      Code = "Beetle",
      ParentCode = "Volkswagen",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1562,
      NameEn = "Cabrio",
      NameAr = "Cabrio",
      Code = "Cabrio",
      ParentCode = "Volkswagen",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1563,
      NameEn = "Cabriolet",
      NameAr = "Cabriolet",
      Code = "Cabriolet",
      ParentCode = "Volkswagen",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1564,
      NameEn = "CC",
      NameAr = "CC",
      Code = "CC",
      ParentCode = "Volkswagen",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1565,
      NameEn = "Corrado",
      NameAr = "Corrado",
      Code = "Corrado",
      ParentCode = "Volkswagen",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1566,
      NameEn = "Dasher",
      NameAr = "Dasher",
      Code = "Dasher",
      ParentCode = "Volkswagen",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1567,
      NameEn = "Eos",
      NameAr = "Eos",
      Code = "Eos",
      ParentCode = "Volkswagen",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1568,
      NameEn = "Eurovan",
      NameAr = "Eurovan",
      Code = "Eurovan",
      ParentCode = "Volkswagen",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1569,
      NameEn = "Fox",
      NameAr = "Fox",
      Code = "Fox",
      ParentCode = "Volkswagen",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1570,
      NameEn = "GLI",
      NameAr = "GLI",
      Code = "GLI",
      ParentCode = "Volkswagen",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1571,
      NameEn = "Golf R",
      NameAr = "Golf R",
      Code = "Golf R",
      ParentCode = "Volkswagen",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1572,
      NameEn = "GTI",
      NameAr = "GTI",
      Code = "GTI",
      ParentCode = "Volkswagen",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1573,
      NameEn = "Golf",
      NameAr = "Golf",
      Code = "Golf",
      ParentCode = "Volkswagen",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1574,
      NameEn = "Rabbit",
      NameAr = "Rabbit",
      Code = "Rabbit",
      ParentCode = "Volkswagen",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1575,
      NameEn = "Jetta",
      NameAr = "Jetta",
      Code = "Jetta",
      ParentCode = "Volkswagen",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1576,
      NameEn = "Passat",
      NameAr = "Passat",
      Code = "Passat",
      ParentCode = "Volkswagen",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1577,
      NameEn = "Phaeton",
      NameAr = "Phaeton",
      Code = "Phaeton",
      ParentCode = "Volkswagen",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1578,
      NameEn = "Pickup",
      NameAr = "Pickup",
      Code = "Pickup",
      ParentCode = "Volkswagen",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1579,
      NameEn = "Quantum",
      NameAr = "Quantum",
      Code = "Quantum",
      ParentCode = "Volkswagen",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1580,
      NameEn = "R32",
      NameAr = "R32",
      Code = "R32",
      ParentCode = "Volkswagen",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1581,
      NameEn = "Routan",
      NameAr = "Routan",
      Code = "Routan",
      ParentCode = "Volkswagen",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1582,
      NameEn = "Scirocco",
      NameAr = "Scirocco",
      Code = "Scirocco",
      ParentCode = "Volkswagen",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1583,
      NameEn = "Tiguan",
      NameAr = "Tiguan",
      Code = "Tiguan",
      ParentCode = "Volkswagen",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1584,
      NameEn = "Touareg",
      NameAr = "Touareg",
      Code = "Touareg",
      ParentCode = "Volkswagen",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1585,
      NameEn = "Vanagon",
      NameAr = "Vanagon",
      Code = "Vanagon",
      ParentCode = "Volkswagen",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1586,
      NameEn = "240",
      NameAr = "240",
      Code = "240",
      ParentCode = "Volvo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1587,
      NameEn = "260",
      NameAr = "260",
      Code = "260",
      ParentCode = "Volvo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1588,
      NameEn = "740",
      NameAr = "740",
      Code = "740",
      ParentCode = "Volvo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1589,
      NameEn = "760",
      NameAr = "760",
      Code = "760",
      ParentCode = "Volvo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1590,
      NameEn = "780",
      NameAr = "780",
      Code = "780",
      ParentCode = "Volvo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1591,
      NameEn = "850",
      NameAr = "850",
      Code = "850",
      ParentCode = "Volvo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1592,
      NameEn = "940",
      NameAr = "940",
      Code = "940",
      ParentCode = "Volvo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1593,
      NameEn = "960",
      NameAr = "960",
      Code = "960",
      ParentCode = "Volvo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1594,
      NameEn = "C30",
      NameAr = "C30",
      Code = "C30",
      ParentCode = "Volvo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1595,
      NameEn = "C70",
      NameAr = "C70",
      Code = "C70",
      ParentCode = "Volvo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1596,
      NameEn = "S40",
      NameAr = "S40",
      Code = "S40",
      ParentCode = "Volvo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1597,
      NameEn = "S60",
      NameAr = "S60",
      Code = "S60",
      ParentCode = "Volvo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1598,
      NameEn = "S70",
      NameAr = "S70",
      Code = "S70",
      ParentCode = "Volvo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1599,
      NameEn = "S80",
      NameAr = "S80",
      Code = "S80",
      ParentCode = "Volvo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1600,
      NameEn = "S90",
      NameAr = "S90",
      Code = "S90",
      ParentCode = "Volvo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1601,
      NameEn = "V40",
      NameAr = "V40",
      Code = "V40",
      ParentCode = "Volvo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1602,
      NameEn = "V50",
      NameAr = "V50",
      Code = "V50",
      ParentCode = "Volvo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1603,
      NameEn = "V70",
      NameAr = "V70",
      Code = "V70",
      ParentCode = "Volvo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1604,
      NameEn = "V90",
      NameAr = "V90",
      Code = "V90",
      ParentCode = "Volvo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1605,
      NameEn = "XC60",
      NameAr = "XC60",
      Code = "XC60",
      ParentCode = "Volvo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1606,
      NameEn = "XC70",
      NameAr = "XC70",
      Code = "XC70",
      ParentCode = "Volvo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1607,
      NameEn = "XC90",
      NameAr = "XC90",
      Code = "XC90",
      ParentCode = "Volvo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1608,
      NameEn = "GV",
      NameAr = "GV",
      Code = "GV",
      ParentCode = "Yugo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1609,
      NameEn = "GVC",
      NameAr = "GVC",
      Code = "GVC",
      ParentCode = "Yugo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1610,
      NameEn = "GVL",
      NameAr = "GVL",
      Code = "GVL",
      ParentCode = "Yugo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1611,
      NameEn = "GVS",
      NameAr = "GVS",
      Code = "GVS",
      ParentCode = "Yugo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1612,
      NameEn = "GVX",
      NameAr = "GVX",
      Code = "GVX",
      ParentCode = "Yugo",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1618,
      NameEn = "Azkarra",
      NameAr = "Azkarra",
      Code = "Azkarra",
      ParentCode = "Geely",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1619,
      NameEn = "Binray",
      NameAr = "Binray",
      Code = "Binray",
      ParentCode = "Geely",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1620,
      NameEn = "Binyue",
      NameAr = "Binyue",
      Code = "Binyue",
      ParentCode = "Geely",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1621,
      NameEn = "Borui GE",
      NameAr = "Borui GE",
      Code = "Borui GE",
      ParentCode = "Geely",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1622,
      NameEn = "Boyue",
      NameAr = "Boyue",
      Code = "Boyue",
      ParentCode = "Geely",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1623,
      NameEn = "Boyue Cool",
      NameAr = "Boyue Cool",
      Code = "Boyue Cool",
      ParentCode = "Geely",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1624,
      NameEn = "BL",
      NameAr = "BL",
      Code = "BL",
      ParentCode = "Geely",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1625,
      NameEn = "Coolray",
      NameAr = "Coolray",
      Code = "Coolray",
      ParentCode = "Geely",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1626,
      NameEn = "CD",
      NameAr = "CD",
      Code = "CD",
      ParentCode = "Geely",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1627,
      NameEn = "CK",
      NameAr = "CK",
      Code = "CK",
      ParentCode = "Geely",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1628,
      NameEn = "MK",
      NameAr = "MK",
      Code = "MK",
      ParentCode = "Geely",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1629,
      NameEn = "Emgrand",
      NameAr = "Emgrand",
      Code = "Emgrand",
      ParentCode = "Geely",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1630,
      NameEn = "EC7",
      NameAr = "EC7",
      Code = "EC7",
      ParentCode = "Geely",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1631,
      NameEn = "Geometry C",
      NameAr = "Geometry C",
      Code = "Geometry C",
      ParentCode = "Geely",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1632,
      NameEn = "Haoyue",
      NameAr = "Haoyue",
      Code = "Haoyue",
      ParentCode = "Geely",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1633,
      NameEn = "Jiaji",
      NameAr = "Jiaji",
      Code = "Jiaji",
      ParentCode = "Geely",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1634,
      NameEn = "LC",
      NameAr = "LC",
      Code = "LC",
      ParentCode = "Geely",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1635,
      NameEn = "Monjaro",
      NameAr = "Monjaro",
      Code = "Monjaro",
      ParentCode = "Geely",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1636,
      NameEn = "MR",
      NameAr = "MR",
      Code = "MR",
      ParentCode = "Geely",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1637,
      NameEn = "Yuanjing",
      NameAr = "Yuanjing",
      Code = "Yuanjing",
      ParentCode = "Geely",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1638,
      NameEn = "Tugella",
      NameAr = "Tugella",
      Code = "Tugella",
      ParentCode = "Geely",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1639,
      NameEn = "GX3 Pro",
      NameAr = "GX3 Pro",
      Code = "GX3 Pro",
      ParentCode = "Geely",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1640,
      NameEn = "Starray",
      NameAr = "Starray",
      Code = "Starray",
      ParentCode = "Geely",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1641,
      NameEn = "Xingrui",
      NameAr = "Xingrui",
      Code = "Xingrui",
      ParentCode = "Geely",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1642,
      NameEn = "JS8",
      NameAr = "JS8",
      Code = "JS8",
      ParentCode = "JAC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1643,
      NameEn = "J7 Plus",
      NameAr = "J7 Plus",
      Code = "J7 Plus",
      ParentCode = "JAC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1644,
      NameEn = "J7",
      NameAr = "J7",
      Code = "J7",
      ParentCode = "JAC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1645,
      NameEn = "JS6",
      NameAr = "JS6",
      Code = "JS6",
      ParentCode = "JAC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1646,
      NameEn = "JS7",
      NameAr = "JS7",
      Code = "JS7",
      ParentCode = "JAC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1647,
      NameEn = "JS4",
      NameAr = "JS4",
      Code = "JS4",
      ParentCode = "JAC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1648,
      NameEn = "JS3",
      NameAr = "JS3",
      Code = "JS3",
      ParentCode = "JAC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1649,
      NameEn = "JS2",
      NameAr = "JS2",
      Code = "JS2",
      ParentCode = "JAC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1650,
      NameEn = "EMPOW",
      NameAr = "EMPOW",
      Code = "EMPOW",
      ParentCode = "GAC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1651,
      NameEn = "GA6",
      NameAr = "GA6",
      Code = "GA6",
      ParentCode = "GAC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1652,
      NameEn = "GA8",
      NameAr = "GA8",
      Code = "GA8",
      ParentCode = "GAC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1653,
      NameEn = "GA4",
      NameAr = "GA4",
      Code = "GA4",
      ParentCode = "GAC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1655,
      NameEn = "GS3 EMZOOM",
      NameAr = "GS3 EMZOOM",
      Code = "GS3 EMZOOM",
      ParentCode = "GAC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1656,
      NameEn = "EMKOO",
      NameAr = "EMKOO",
      Code = "EMKOO",
      ParentCode = "GAC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1657,
      NameEn = "GS3 POWER",
      NameAr = "GS3 POWER",
      Code = "GS3 POWER",
      ParentCode = "GAC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1658,
      NameEn = "GS8",
      NameAr = "GS8",
      Code = "GS8",
      ParentCode = "GAC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1659,
      NameEn = "GS4",
      NameAr = "GS4",
      Code = "GS4",
      ParentCode = "GAC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1661,
      NameEn = "GS5",
      NameAr = "GS5",
      Code = "GS5",
      ParentCode = "GAC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1662,
      NameEn = "GS3",
      NameAr = "GS3",
      Code = "GS3",
      ParentCode = "GAC",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1663,
      NameEn = "Eado Plus",
      NameAr = "Eado Plus",
      Code = "Eado Plus",
      ParentCode = "CHANGAN",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1664,
      NameEn = "Raeton CC",
      NameAr = "Raeton CC",
      Code = "Raeton CC",
      ParentCode = "CHANGAN",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1665,
      NameEn = "Eado XT",
      NameAr = "Eado XT",
      Code = "Eado XT",
      ParentCode = "CHANGAN",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1666,
      NameEn = "Eado",
      NameAr = "Eado",
      Code = "Eado",
      ParentCode = "CHANGAN",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1667,
      NameEn = "Eado DT",
      NameAr = "Eado DT",
      Code = "Eado DT",
      ParentCode = "CHANGAN",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1668,
      NameEn = "Alsvin",
      NameAr = "Alsvin",
      Code = "Alsvin",
      ParentCode = "CHANGAN",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1669,
      NameEn = "CS15",
      NameAr = "CS15",
      Code = "CS15",
      ParentCode = "CHANGAN",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1670,
      NameEn = "CS35",
      NameAr = "CS35",
      Code = "CS35",
      ParentCode = "CHANGAN",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1671,
      NameEn = "CS35 PLUS",
      NameAr = "CS35 PLUS",
      Code = "CS35 PLUS",
      ParentCode = "CHANGAN",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1672,
      NameEn = "CS55",
      NameAr = "CS55",
      Code = "CS55",
      ParentCode = "CHANGAN",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1673,
      NameEn = "CS75",
      NameAr = "CS75",
      Code = "CS75",
      ParentCode = "CHANGAN",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1674,
      NameEn = "CS75PHEV",
      NameAr = "CS75PHEV",
      Code = "CS75PHEV",
      ParentCode = "CHANGAN",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1675,
      NameEn = "CS75 Plus",
      NameAr = "CS75 Plus",
      Code = "CS75 Plus",
      ParentCode = "CHANGAN",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1676,
      NameEn = "CS85",
      NameAr = "CS85",
      Code = "CS85",
      ParentCode = "CHANGAN",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1677,
      NameEn = "CS85 COUPE",
      NameAr = "CS85 COUPE",
      Code = "CS85 COUPE",
      ParentCode = "CHANGAN",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1678,
      NameEn = "CS95",
      NameAr = "CS95",
      Code = "CS95",
      ParentCode = "CHANGAN",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1679,
      NameEn = "CX70",
      NameAr = "CX70",
      Code = "CX70",
      ParentCode = "CHANGAN",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1680,
      NameEn = "CX70T",
      NameAr = "CX70T",
      Code = "CX70T",
      ParentCode = "CHANGAN",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1681,
      NameEn = "CS15 EV400",
      NameAr = "CS15 EV400",
      Code = "CS15 EV400",
      ParentCode = "CHANGAN",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1682,
      NameEn = "Eado PHEV",
      NameAr = "Eado PHEV",
      Code = "Eado PHEV",
      ParentCode = "CHANGAN",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1683,
      NameEn = "Eado EV460",
      NameAr = "Eado EV460",
      Code = "Eado EV460",
      ParentCode = "CHANGAN",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1684,
      NameEn = "Benni EV360",
      NameAr = "Benni EV360",
      Code = "Benni EV360",
      ParentCode = "CHANGAN",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1685,
      NameEn = "Benni EC260",
      NameAr = "Benni EC260",
      Code = "Benni EC260",
      ParentCode = "CHANGAN",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1686,
      NameEn = "UNI-K",
      NameAr = "UNI-K",
      Code = "UNI-K",
      ParentCode = "CHANGAN",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1687,
      NameEn = "UNI-T",
      NameAr = "UNI-T",
      Code = "UNI-T",
      ParentCode = "CHANGAN",
      CreationDate = new DateTime(2024, 6, 23)
  },

  new LookupValues
  {
      Id = 1688,
      NameEn = "UNI-V",
      NameAr = "UNI-V",
      Code = "UNI-V",
      ParentCode = "CHANGAN",
      CreationDate = new DateTime(2024, 6, 23)
  }
  );
        }
    }
}
