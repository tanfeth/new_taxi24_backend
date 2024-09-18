using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddCodeToTripSettings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TripSetting",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "TripSetting",
                keyColumn: "Id",
                keyValue: 1,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "TripSetting",
                keyColumn: "Id",
                keyValue: 2,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "TripSetting",
                keyColumn: "Id",
                keyValue: 3,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "TripSetting",
                keyColumn: "Id",
                keyValue: 4,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "TripSetting",
                keyColumn: "Id",
                keyValue: 5,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "TripSetting",
                keyColumn: "Id",
                keyValue: 6,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "TripSetting",
                keyColumn: "Id",
                keyValue: 7,
                column: "Code",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "TripSetting");
        }
    }
}
