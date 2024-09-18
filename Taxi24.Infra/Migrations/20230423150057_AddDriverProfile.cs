using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddDriverProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarCheck",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "CarName",
                table: "Driver");

            migrationBuilder.RenameColumn(
                name: "CarDelegation",
                table: "Driver",
                newName: "DriverNumber");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "User",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Licence",
                table: "Driver",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CarModel",
                table: "Driver",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CarCollor",
                table: "Driver",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.AddColumn<DateTime>(
                name: "LicenceExpiryDate",
                table: "Driver",
                type: "datetime(6)",
                nullable: true);

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

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Driver",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Driver_UserId1",
                table: "Driver",
                column: "UserId1",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Driver_User_UserId1",
                table: "Driver",
                column: "UserId1",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Driver_User_UserId1",
                table: "Driver");

            migrationBuilder.DropIndex(
                name: "IX_Driver_UserId1",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CarInssurance",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "CarInssuranceExpiryDate",
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
                name: "LicenceExpiryDate",
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

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Driver");

            migrationBuilder.RenameColumn(
                name: "DriverNumber",
                table: "Driver",
                newName: "CarDelegation");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Licence",
                keyValue: null,
                column: "Licence",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Licence",
                table: "Driver",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "CarModel",
                keyValue: null,
                column: "CarModel",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CarModel",
                table: "Driver",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "CarCollor",
                keyValue: null,
                column: "CarCollor",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CarCollor",
                table: "Driver",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CarCheck",
                table: "Driver",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CarName",
                table: "Driver",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
