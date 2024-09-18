using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentityNumberToUserAddPlateToCar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "IdentityNumber",
            //    table: "Driver");

            migrationBuilder.DropColumn(
                name: "PlateNumber",
                table: "Car");

            //migrationBuilder.AddColumn<string>(
            //    name: "IdentityNumber",
            //    table: "User",
            //    type: "longtext",
            //    nullable: true)
            //    .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdentityNumber",
                table: "User");

            //migrationBuilder.AddColumn<string>(
            //    name: "IdentityNumber",
            //    table: "Driver",
            //    type: "longtext",
            //    nullable: true)
            //    .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "PlateNumber",
                table: "Car",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
