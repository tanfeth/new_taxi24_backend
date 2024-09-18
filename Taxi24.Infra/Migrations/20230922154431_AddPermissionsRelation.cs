using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddPermissionsRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Permission",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Permission_ParentId",
                table: "Permission",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Permission_Permission_ParentId",
                table: "Permission",
                column: "ParentId",
                principalTable: "Permission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permission_Permission_ParentId",
                table: "Permission");

            migrationBuilder.DropIndex(
                name: "IX_Permission_ParentId",
                table: "Permission");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Permission");
        }
    }
}
