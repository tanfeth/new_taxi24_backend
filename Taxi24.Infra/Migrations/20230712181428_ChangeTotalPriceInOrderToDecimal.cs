using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTotalPriceInOrderToDecimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "Order",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.AlterColumn<decimal>(
                name: "DriverPrice",
                table: "Order",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.AlterColumn<decimal>(
                name: "ApplicationPrice",
                table: "Order",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");

            //migrationBuilder.AddColumn<string>(
            //    name: "IdentityNumber",
            //    table: "Driver",
            //    type: "longtext",
            //    nullable: true)
            //    .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "PlateLetterLeft",
                table: "Car",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "PlateLetterMiddle",
                table: "Car",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "PlateLetterRight",
                table: "Car",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "PlateNumber",
                table: "Car",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "PlateType",
                table: "Car",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "IdentityNumber",
            //    table: "Driver");

            migrationBuilder.DropColumn(
                name: "PlateLetterLeft",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "PlateLetterMiddle",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "PlateLetterRight",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "PlateNumber",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "PlateType",
                table: "Car");

            migrationBuilder.AlterColumn<double>(
                name: "TotalPrice",
                table: "Order",
                type: "double",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<double>(
                name: "DriverPrice",
                table: "Order",
                type: "double",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<double>(
                name: "ApplicationPrice",
                table: "Order",
                type: "double",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");
        }
    }
}
