using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class TripSettingsSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TripSetting",
                columns: new[] { "Id", "IsDeleted", "Name", "Value" },
                values: new object[,]
                {
                    { 1, false, "kilometerPrice", "5" },
                    { 2, false, "WaitingPrice", "5" },
                    { 3, false, "PassangerCancellationPrice", "5" },
                    { 4, false, "DriverCancellationPrice", "5" },
                    { 5, false, "ApplicationPrice", "5" },
                    { 6, false, "SedanCarPriceForkilometer", "1" },
                    { 7, false, "FamilyCarPriceForkilometer", "2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TripSetting",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TripSetting",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TripSetting",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TripSetting",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TripSetting",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TripSetting",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TripSetting",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
