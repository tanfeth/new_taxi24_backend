using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddNamesToPermissions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Permission",
                newName: "NameEn");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Permission",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "NameAr",
                table: "Permission",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Permission");

            migrationBuilder.DropColumn(
                name: "NameAr",
                table: "Permission");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "Permission",
                newName: "Name");
        }
    }
}
