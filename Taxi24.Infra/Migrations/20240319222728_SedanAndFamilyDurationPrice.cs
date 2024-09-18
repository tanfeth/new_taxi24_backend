using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class SedanAndFamilyDurationPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DurationPrice",
                table: "OrderTemp",
                newName: "DurationPriceSedan");

            migrationBuilder.AddColumn<string>(
                name: "DurationPriceFamily",
                table: "OrderTemp",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DurationPriceFamily",
                table: "OrderTemp");

            migrationBuilder.RenameColumn(
                name: "DurationPriceSedan",
                table: "OrderTemp",
                newName: "DurationPrice");
        }
    }
}
