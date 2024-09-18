using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddCarTypesDataValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LookupValues_Lookup_LookupId",
                table: "LookupValues");

            migrationBuilder.AlterColumn<int>(
                name: "LookupId",
                table: "LookupValues",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "LookupValues",
                columns: new[] { "Id", "Code", "CreationDate", "CreationUser", "IsDeleted", "LookupId", "ModificationDate", "ModificationUser", "NameAr", "NameEn", "ParentCode" },
                values: new object[,]
                {
                    { 1, "TOY", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "تويوتا", "Toyota", null },
                    { 2, "FOR", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "فورد", "Ford", null },
                    { 3, "CHE", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "شيفروليه", "Chevrolet", null },
                    { 4, "BMW", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "بي ام دبليو", "BMW", null },
                    { 5, "MB", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "مرسيدس بنز", "Mercedes-Benz", null },
                    { 6, "AUD", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "أودي", "Audi", null },
                    { 7, "NIS", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "نيسان", "Nissan", null },
                    { 8, "VW", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "فولكس واجن", "Volkswagen", null },
                    { 9, "HYU", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "هيونداي", "Hyundai", null },
                    { 10, "KIA", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "كيا", "Kia", null },
                    { 11, "MAZ", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "مازدا", "Mazda", null },
                    { 12, "SUB", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "سوبارو", "Subaru", null },
                    { 13, "POR", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "بورش", "Porsche", null },
                    { 14, "LEX", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "لكزس", "Lexus", null },
                    { 15, "VOL", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "فولفو", "Volvo", null },
                    { 16, "LR", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "لاند روڤر", "Land Rover", null },
                    { 17, "JAG", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "جاكوار", "Jaguar", null },
                    { 18, "FER", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "فيراري", "Ferrari", null },
                    { 19, "MAS", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "مازيراتي", "Maserati", null },
                    { 20, "BUG", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "بوغاتي", "Bugatti", null },
                    { 21, "MCL", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "مكلارين", "McLaren", null },
                    { 22, "RR", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "رولز رويس", "Rolls-Royce", null },
                    { 23, "BEN", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "بنتلي", "Bentley", null },
                    { 24, "AST", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "أستون مارتن", "Aston Martin", null },
                    { 25, "AR", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "ألفا روميو", "Alfa Romeo", null },
                    { 26, "TOYOTA_CAMRY", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "كامري", "Camry", "TOY" },
                    { 27, "TOYOTA_COROLLA", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "كورولا", "Corolla", "TOY" },
                    { 28, "TOYOTA_RAV4", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "راف فور", "Rav4", "TOY" },
                    { 29, "TOYOTA_PRIUS", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "بريوس", "Prius", "TOY" },
                    { 30, "TOYOTA_HIGHLANDER", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "هايلاندر", "Highlander", "TOY" },
                    { 31, "TOYOTA_TACOMA", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "تاكوما", "Tacoma", "TOY" },
                    { 32, "HONDA_ACCORD", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "أكورد", "Accord", "Honda" },
                    { 33, "HONDA_CIVIC", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "سيفيك", "Civic", "Honda" },
                    { 34, "HONDA_CRV", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "سي آر في", "CR-V", "Honda" },
                    { 35, "HONDA_PILOT", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "بايلوت", "Pilot", "Honda" },
                    { 36, "HONDA_ODYSSEY", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "أوديسي", "Odyssey", "Honda" },
                    { 37, "HONDA_FIT", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "فت", "Fit", "Honda" },
                    { 38, "NISSAN_ALTIMA", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "ألتيما", "Altima", "Nissan" },
                    { 39, "NISSAN_SENTRA", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "سنترا", "Sentra", "Nissan" },
                    { 40, "NISSAN_ROGUE", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "روغ", "Rogue", "Nissan" },
                    { 41, "NISSAN_MAXIMA", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "ماكسيما", "Maxima", "Nissan" },
                    { 42, "NISSAN_PATHFINDER", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "باثفايندر", "Pathfinder", "Nissan" },
                    { 43, "NISSAN_TITAN", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "تيتان", "Titan", "Nissan" },
                    { 44, "FORD_F150", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "إف-150", "F-150", "FOR" },
                    { 45, "FORD_ESCAPE", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "إسكيب", "Escape", "FOR" },
                    { 46, "FORD_EXPLORER", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "إكسبلورر", "Explorer", "FOR" },
                    { 47, "FORD_FOCUS", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "فوكس", "Focus", "FOR" },
                    { 48, "FORD_MUSTANG", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "موستانغ", "Mustang", "FOR" },
                    { 49, "FORD_EDGE", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "إيدج", "Edge", "FOR" },
                    { 50, "CHEVROLET_SILVERADO", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "سيلفرادو", "Silverado", "CHE" },
                    { 51, "CHEVROLET_MALIBU", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "ماليبو", "Malibu", "CHE" },
                    { 52, "CHEVROLET_EQUINOX", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "إيكوينوكس", "Equinox", "CHE" },
                    { 53, "CHEVROLET_CRUZE", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "كروز", "Cruze", "CHE" },
                    { 54, "CHEVROLET_TRAVERSE", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "ترافيرس", "Traverse", "CHE" },
                    { 55, "CHEVROLET_SUBURBAN", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "سوبربان", "Suburban", "CHE" },
                    { 56, "BMW_3SERIES", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "سلسلة 3", "3 Series", "BMW" },
                    { 57, "BMW_5SERIES", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "سلسلة 5", "5 Series", "BMW" },
                    { 58, "BMW_X3", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "إكس 3", "X3", "BMW" },
                    { 59, "BMW_X5", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "إكس 5", "X5", "BMW" },
                    { 60, "BMW_7SERIES", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "سلسلة 7", "7 Series", "BMW" },
                    { 61, "BMW_X1", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "إكس 1", "X1", "BMW" },
                    { 62, "MERCEDES_C_CLASS", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "سي-كلاس", "C-Class", "MB" },
                    { 63, "MERCEDES_E_CLASS", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "إي-كلاس", "E-Class", "MB" },
                    { 64, "MERCEDES_S_CLASS", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "إس-كلاس", "S-Class", "MB" },
                    { 65, "MERCEDES_GLC", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "جي-إل-سي", "GLC", "MB" },
                    { 66, "MERCEDES_GLE", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "جي-إل-إي", "GLE", "MB" },
                    { 67, "MERCEDES_GLS", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "جي-إل-إس", "GLS", "MB" },
                    { 68, "MERCEDES_AMG_GT", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "أي-إم-جي جي تي", "AMG GT", "MB" },
                    { 69, "VW_GOLF", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "جولف", "Golf", "VW" },
                    { 70, "VW_PASSAT", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "باسات", "Passat", "VW" },
                    { 71, "VW_JETTA", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "جيتا", "Jetta", "VW" },
                    { 72, "VW_TIGUAN", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "تيجوان", "Tiguan", "VW" },
                    { 73, "VW_ATLAS", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "أطلس", "Atlas", "VW" },
                    { 74, "HYUNDAI_SONATA", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "سوناتا", "Sonata", "HYU" },
                    { 75, "HYUNDAI_ELANTRA", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "إلانترا", "Elantra", "HYU" },
                    { 76, "HYUNDAI_TUCSON", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "توسان", "Tucson", "HYU" },
                    { 77, "HYUNDAI_SANTA_FE", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "سانتا في", "Santa Fe", "HYU" },
                    { 78, "KIA_OPTIMA", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "أوبتيما", "Optima", "KIA" },
                    { 79, "KIA_SPORTAGE", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "سبورتاج", "Sportage", "KIA" },
                    { 80, "KIA_SORENTO", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "سورينتو", "Sorento", "KIA" },
                    { 81, "KIA_TELLURIDE", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "تيليورايد", "Telluride", "KIA" },
                    { 82, "MAZDA_3", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "مازدا 3", "Mazda3", "MAZ" },
                    { 83, "MAZDA_6", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "مازدا 6", "Mazda6", "MAZ" },
                    { 84, "MAZDA_CX5", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "سي إكس-5", "CX-5", "MAZ" },
                    { 85, "MAZDA_CX9", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "سي إكس-9", "CX-9", "MAZ" },
                    { 86, "SUBARU_IMPREZA", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "إمبريزا", "Impreza", "SUB" },
                    { 87, "SUBARU_LEGACY", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "ليجاسي", "Legacy", "SUB" },
                    { 88, "SUBARU_OUTBACK", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "أوتباك", "Outback", "SUB" },
                    { 89, "SUBARU_FORESTER", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "فورستر", "Forester", "SUB" },
                    { 90, "PORSCHE_911", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "911", "911", "POR" },
                    { 91, "PORSCHE_CAYENNE", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "كايين", "Cayenne", "POR" },
                    { 92, "PORSCHE_PANAMERA", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "باناميرا", "Panamera", "POR" },
                    { 93, "PORSCHE_MACAN", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "ماكان", "Macan", "POR" },
                    { 94, "AUDI_A3", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "أيه 3", "A3", "AUD" },
                    { 95, "AUDI_A4", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "أيه 4", "A4", "AUD" },
                    { 96, "AUDI_A6", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "أيه 6", "A6", "AUD" },
                    { 97, "AUDI_Q3", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "كيو 3", "Q3", "AUD" },
                    { 98, "AUDI_Q5", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "كيو 5", "Q5", "AUD" },
                    { 99, "TESLA_MODEL_S", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "موديل اس", "Model S", "TES" },
                    { 100, "TESLA_MODEL_3", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "موديل 3", "Model 3", "TES" },
                    { 101, "TESLA_MODEL_X", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "موديل اكس", "Model X", "TES" },
                    { 102, "TESLA_MODEL_Y", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, null, "موديل واي", "Model Y", "TES" },
                    { 103, "HON", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "هوندا", "Honda", null },
                    { 104, "TES", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, null, null, "تسلا", "Tesla", null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_LookupValues_Lookup_LookupId",
                table: "LookupValues",
                column: "LookupId",
                principalTable: "Lookup",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LookupValues_Lookup_LookupId",
                table: "LookupValues");

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "LookupValues",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.AlterColumn<int>(
                name: "LookupId",
                table: "LookupValues",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_LookupValues_Lookup_LookupId",
                table: "LookupValues",
                column: "LookupId",
                principalTable: "Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
