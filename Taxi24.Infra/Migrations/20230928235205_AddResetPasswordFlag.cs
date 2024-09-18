using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddResetPasswordFlag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PasswordReset",
                table: "User",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "Code", "CreationDate", "CreationUser", "IsDeleted", "IsSystem", "ModificationDate", "ModificationUser", "NameAr", "NameEn", "ParentId" },
                values: new object[] { 31, "dashboard", null, null, false, false, null, null, "Driver Details", "Driver Details", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DropColumn(
                name: "PasswordReset",
                table: "User");
        }
    }
}
