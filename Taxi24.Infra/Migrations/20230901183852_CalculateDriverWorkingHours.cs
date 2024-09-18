using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class CalculateDriverWorkingHours : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EndTrip",
                table: "Order",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTrip",
                table: "Order",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "WorkingHoursInMin",
                table: "Driver",
                type: "double",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndTrip",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "StartTrip",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "WorkingHoursInMin",
                table: "Driver");
        }
    }
}
