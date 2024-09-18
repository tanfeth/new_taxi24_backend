using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class ProfileImageNotificationMessage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "NotificationMessages",
                columns: new[] { "Id", "BodyAr", "BodyEn", "CreationDate", "CreationUser", "IsDeleted", "NotificationName", "TitleAr", "TitleEn", "UserId" },
                values: new object[] { 12, "تم الموافقة على الصورة الشخصية", "Profile image apporved", null, null, false, 12, "تم الموافقة على الصورة الشخصية", "Profile image apporved", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NotificationMessages",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
