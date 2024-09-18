using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxi24.Infra.Migrations
{
    public partial class AddEditProfileImageEditedState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfileImageEditedState",
                table: "User",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ProfileImageEditedStateNote",
                table: "User",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileImageEditedState",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ProfileImageEditedStateNote",
                table: "User");
        }
    }
}
