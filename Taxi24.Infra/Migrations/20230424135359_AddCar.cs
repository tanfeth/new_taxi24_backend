using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddCar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarCollor",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "CarInssurance",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "CarInssuranceExpiryDate",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "CarModel",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "CarRegistration",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "CarRegistrationExpiryDate",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "CarType",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "CarYear",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "PlateNo",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "SauidIdExpiryDate",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "SauidIdImage",
                table: "Driver");

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CarType = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CarModel = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CarYear = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    CarCollor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CarRegistration = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CarRegistrationExpiryDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CarInssurance = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CarInssuranceExpiryDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    SauidIdImage = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SauidIdExpiryDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    PlateNo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DriverId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreationUser = table.Column<int>(type: "int", nullable: true),
                    ModificationUser = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Car_Driver_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Driver",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Car_DriverId",
                table: "Car",
                column: "DriverId");

            migrationBuilder.AddForeignKey(
                name: "FK_Driver_Car_UserId",
                table: "Driver",
                column: "UserId",
                principalTable: "Car",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Driver_Car_UserId",
                table: "Driver");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.AddColumn<string>(
                name: "CarCollor",
                table: "Driver",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CarInssurance",
                table: "Driver",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CarInssuranceExpiryDate",
                table: "Driver",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CarModel",
                table: "Driver",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CarRegistration",
                table: "Driver",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CarRegistrationExpiryDate",
                table: "Driver",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CarType",
                table: "Driver",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "CarYear",
                table: "Driver",
                type: "int",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PlateNo",
                table: "Driver",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "SauidIdExpiryDate",
                table: "Driver",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SauidIdImage",
                table: "Driver",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
