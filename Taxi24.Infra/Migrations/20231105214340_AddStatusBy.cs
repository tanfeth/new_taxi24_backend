using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddStatusBy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LicenseStatusBy",
                table: "Driver",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SaudiIdModifiedBy",
                table: "Driver",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CarInssuranceModifiedBy",
                table: "Car",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CarRegistrationModifiedBy",
                table: "Car",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Driver_LicenseStatusBy",
                table: "Driver",
                column: "LicenseStatusBy");

            migrationBuilder.CreateIndex(
                name: "IX_Driver_SaudiIdModifiedBy",
                table: "Driver",
                column: "SaudiIdModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Car_CarInssuranceModifiedBy",
                table: "Car",
                column: "CarInssuranceModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Car_CarRegistrationModifiedBy",
                table: "Car",
                column: "CarRegistrationModifiedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_User_CarInssuranceModifiedBy",
                table: "Car",
                column: "CarInssuranceModifiedBy",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_User_CarRegistrationModifiedBy",
                table: "Car",
                column: "CarRegistrationModifiedBy",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Driver_User_LicenseStatusBy",
                table: "Driver",
                column: "LicenseStatusBy",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Driver_User_SaudiIdModifiedBy",
                table: "Driver",
                column: "SaudiIdModifiedBy",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_User_CarInssuranceModifiedBy",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_User_CarRegistrationModifiedBy",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Driver_User_LicenseStatusBy",
                table: "Driver");

            migrationBuilder.DropForeignKey(
                name: "FK_Driver_User_SaudiIdModifiedBy",
                table: "Driver");

            migrationBuilder.DropIndex(
                name: "IX_Driver_LicenseStatusBy",
                table: "Driver");

            migrationBuilder.DropIndex(
                name: "IX_Driver_SaudiIdModifiedBy",
                table: "Driver");

            migrationBuilder.DropIndex(
                name: "IX_Car_CarInssuranceModifiedBy",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Car_CarRegistrationModifiedBy",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "LicenseStatusBy",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "SaudiIdModifiedBy",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "CarInssuranceModifiedBy",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "CarRegistrationModifiedBy",
                table: "Car");
        }
    }
}
