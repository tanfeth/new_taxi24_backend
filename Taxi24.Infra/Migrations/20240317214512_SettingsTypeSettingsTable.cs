using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class SettingsTypeSettingsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SettingsType",
                table: "TripSetting",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TripSetting",
                keyColumn: "Id",
                keyValue: 1,
                column: "SettingsType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TripSetting",
                keyColumn: "Id",
                keyValue: 2,
                column: "SettingsType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TripSetting",
                keyColumn: "Id",
                keyValue: 3,
                column: "SettingsType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TripSetting",
                keyColumn: "Id",
                keyValue: 4,
                column: "SettingsType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TripSetting",
                keyColumn: "Id",
                keyValue: 5,
                column: "SettingsType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TripSetting",
                keyColumn: "Id",
                keyValue: 6,
                column: "SettingsType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TripSetting",
                keyColumn: "Id",
                keyValue: 7,
                column: "SettingsType",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SettingsType",
                table: "TripSetting");
        }
    }
}
