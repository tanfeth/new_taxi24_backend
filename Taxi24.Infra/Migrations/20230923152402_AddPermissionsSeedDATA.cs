using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddPermissionsSeedDATA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "Code", "CreationDate", "CreationUser", "IsDeleted", "ModificationDate", "ModificationUser", "NameAr", "NameEn", "ParentId" },
                values: new object[,]
                {
                    { 4, "users", null, null, false, null, null, "Users", "Users", null },
                    { 9, "trips", null, null, false, null, null, "Trips", "Trips", null },
                    { 11, "notifications", null, null, false, null, null, "Notifications", "Notifications", null },
                    { 12, "notifications", null, null, false, null, null, "Notification Send", "Notification Send", 12 },
                    { 13, "delete_notifications", null, null, false, null, null, "Notifications Delete", "Notifications Delete", null },
                    { 14, "promo_code", null, null, false, null, null, "Promo Codes", "Promo Codes", null },
                    { 18, "transactions", null, null, false, null, null, "Transactions", "Transactions", null },
                    { 19, "settings", null, null, false, null, null, "settings", "settings", null },
                    { 20, "support", null, null, false, null, null, "Support", "Support", null },
                    { 21, "wallets", null, null, false, null, null, "Wallets", "Wallets", null },
                    { 5, "activate_deactivate_users", null, null, false, null, null, "Activate , DeActivate User", "Activate , DeActivate User", 4 },
                    { 6, "users_delete", null, null, false, null, null, "Delete User", "Delete User", 4 },
                    { 7, "users_edit", null, null, false, null, null, "Edit User", "Edit User", 4 },
                    { 8, "users_details", null, null, false, null, null, "Details User", "Details User", 4 },
                    { 10, "trips_details", null, null, false, null, null, "Trips Details", "Trips Details", 9 },
                    { 15, "promo_code_add", null, null, false, null, null, "Promo Code Add", "Promo Code Add", 14 },
                    { 16, "promo_code_delete", null, null, false, null, null, "Promo Code Delete", "Promo Code Delete", 14 },
                    { 17, "promo_code_add", null, null, false, null, null, "Promo Code Activate ,Deactivate", "Promo Code Activate ,Deactivate", 14 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 14);
        }
    }
}
