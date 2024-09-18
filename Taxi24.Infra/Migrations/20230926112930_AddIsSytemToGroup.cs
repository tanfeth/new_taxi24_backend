using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddIsSytemToGroup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSystem",
                table: "Permission",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsSystem",
                value: false);

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsSystem",
                value: false);

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsSystem",
                value: false);

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsSystem",
                value: false);

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsSystem",
                value: false);

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsSystem",
                value: false);

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7,
                column: "IsSystem",
                value: false);

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8,
                column: "IsSystem",
                value: false);

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9,
                column: "IsSystem",
                value: false);

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10,
                column: "IsSystem",
                value: false);

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11,
                column: "IsSystem",
                value: false);

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12,
                column: "IsSystem",
                value: false);

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13,
                column: "IsSystem",
                value: false);

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14,
                column: "IsSystem",
                value: false);

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15,
                column: "IsSystem",
                value: false);

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16,
                column: "IsSystem",
                value: false);

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Code", "IsSystem" },
                values: new object[] { "activate_deactivate_promoCode", false });

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18,
                column: "IsSystem",
                value: false);

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 19,
                column: "IsSystem",
                value: false);

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 20,
                column: "IsSystem",
                value: false);

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 21,
                column: "IsSystem",
                value: false);

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 22,
                column: "IsSystem",
                value: true);

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 23,
                column: "IsSystem",
                value: true);

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 24,
                column: "IsSystem",
                value: true);

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 25,
                column: "IsSystem",
                value: true);

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "Code", "CreationDate", "CreationUser", "IsDeleted", "IsSystem", "ModificationDate", "ModificationUser", "NameAr", "NameEn", "ParentId" },
                values: new object[,]
                {
                    { 26, "users_add", null, null, false, true, null, null, "Add User", "Add User", 4 },
                    { 27, "cars", null, null, false, false, null, null, "Cars", "Cars", null },
                    { 30, "driver_details", null, null, false, false, null, null, "Driver Details", "Driver Details", 1 },
                    { 28, "Approve , Reject documents", null, null, false, false, null, null, "Approve , Reject documents", "Approve , Reject documents", 27 },
                    { 29, "car_details", null, null, false, false, null, null, "Car Details", "Car Details", 27 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DropColumn(
                name: "IsSystem",
                table: "Permission");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17,
                column: "Code",
                value: "promo_code_add");
        }
    }
}
