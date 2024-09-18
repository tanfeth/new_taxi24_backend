using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddNotificationMessages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.InsertData(
                table: "NotificationMessages",
                columns: new[] { "Id", "BodyAr", "BodyEn", "CreationDate", "CreationUser", "IsDeleted", "NotificationName", "TitleAr", "TitleEn", "UserId" },
                values: new object[,]
                {
                    { 8, "تم الموافقة على بطاقة الهوية", "Sauid ID document apporved", null, null, false, 8, "تم الموافقة على بطاقة الهوية", "Sauid ID document apporved", null },
                    { 9, "تم الموافقة على وثيقة رخصة السائق", "Driver License document apporved", null, null, false, 9, "تم الموافقة على وثيقة رخصة السائق", "Driver License document apporved", null },
                    { 10, "تم الموافقة على وثيقة تسجيل السيارة", "Car Registration  document apporved", null, null, false, 10, "تم الموافقة على وثيقة تسجيل السيارة", "Car Registration document apporved", null },
                    { 11, "تم الموافقة على وثيقة تأمين السيارة", "Driver License document apporved", null, null, false, 11, "تم الموافقة على وثيقة تأمين السيارة", "Driver License document apporved", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
         
        }
    }
}
