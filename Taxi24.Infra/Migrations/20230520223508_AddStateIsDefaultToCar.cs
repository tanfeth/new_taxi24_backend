using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddStateIsDefaultToCar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Support_ModelId",
                table: "Photos");

            migrationBuilder.AddColumn<string>(
                name: "ProfileImageState",
                table: "User",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Support",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "LicenseImageState",
                table: "Driver",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "SaudiIdImageState",
                table: "Driver",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CarDetailsState",
                table: "Car",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CarInssuranceState",
                table: "Car",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CarRegistrationState",
                table: "Car",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "IsDefault",
                table: "Car",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileImageState",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LicenseImageState",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "SaudiIdImageState",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "CarDetailsState",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "CarInssuranceState",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "CarRegistrationState",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "IsDefault",
                table: "Car");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Support",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Support_ModelId",
                table: "Photos",
                column: "ModelId",
                principalTable: "Support",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
