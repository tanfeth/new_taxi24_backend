using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddDurationDistanceToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "DistanceKM",
                table: "Order",
                type: "double",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "Order",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DistanceKM",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Order");
        }
    }
}
