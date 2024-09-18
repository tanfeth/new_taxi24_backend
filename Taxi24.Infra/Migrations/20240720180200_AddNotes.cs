using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxi24.Infra.Migrations
{
    public partial class AddNotes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfileImageStateNote",
                table: "User",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "LicenseImageStateNote",
                table: "Driver",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "SaudiIdImageStateNote",
                table: "Driver",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CarInssuranceStateNote",
                table: "Car",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CarRegistrationStateNote",
                table: "Car",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileImageStateNote",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LicenseImageStateNote",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "SaudiIdImageStateNote",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "CarInssuranceStateNote",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "CarRegistrationStateNote",
                table: "Car");
        }
    }
}
