using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddRejectedTemplateAndReminderTemplates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotificationMessages");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NotificationMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    BodyAr = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BodyEn = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreationUser = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NotificationName = table.Column<int>(type: "int", nullable: false),
                    TitleAr = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TitleEn = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotificationMessages_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "NotificationMessages",
                columns: new[] { "Id", "BodyAr", "BodyEn", "CreationDate", "CreationUser", "IsDeleted", "NotificationName", "TitleAr", "TitleEn", "UserId" },
                values: new object[,]
                {
                    { 1, "سوف يصل في 5 دقائق [DriverName]", "[DriverName] will arrive in 5 min", null, null, false, 1, "وجدنا سائق لك", "We found driver for you", null },
                    { 2, "في انتظارك ، تأكد من مقابلته قبل 5 دقائق لتجنب أي رسوم إضافية [DriverName]", "[DriverName] waiting for you,Be sure to meet him before 5 min to avoid any extra fees", null, null, false, 2, "وصل السائق الخاص بك", "Your driver has arrived", null },
                    { 3, "نأسف جدًا لذلك، يمكنك العثور على سائق  اخر أو تغيير رحلتك", "we are very sorry for this, you can find other drivers or change your trip", null, null, false, 3, "السائق قام بالغاء الرحلة", "Your driver cancelled trip", null },
                    { 4, "تم تحصيل  [Amount] ريال سعودي من محفظتك بسبب تغيير أجرة رحلتك", "Your have been charged with [Amount] SAR from your wallet because your trip fare changed", null, null, false, 4, "ريال سعودي مسحوب من محفظتك [Amount]", "[Amount] SAR withdrawn from your wallet", null },
                    { 5, "قام المستخدم بإلغاء الرحلة. لا تقلق لن نفرض عليك رسوم.", "The user has cancelled the trip. Don't worry we won't charge you.", null, null, false, 5, "تم إلغاء الرحلة", "Trip has been canceled", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_NotificationMessages_UserId",
                table: "NotificationMessages",
                column: "UserId");
        }
    }
}
