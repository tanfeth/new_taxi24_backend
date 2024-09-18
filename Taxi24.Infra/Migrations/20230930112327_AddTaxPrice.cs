using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddTaxPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TaxPrice",
                table: "Order",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "NameAr", "NameEn" },
                values: new object[] { "dashboard", "dashboard" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TaxPrice",
                table: "Order");

            migrationBuilder.UpdateData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "NameAr", "NameEn" },
                values: new object[] { "Driver Details", "Driver Details" });
        }
    }
}
