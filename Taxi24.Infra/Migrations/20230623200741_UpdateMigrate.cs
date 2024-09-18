using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPermissions_Permission_PermissionId",
                table: "UserPermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPermissions_User_UserId",
                table: "UserPermissions");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPermissions_Permission_PermissionId",
                table: "UserPermissions",
                column: "PermissionId",
                principalTable: "Permission",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPermissions_User_UserId",
                table: "UserPermissions",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPermissions_Permission_PermissionId",
                table: "UserPermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPermissions_User_UserId",
                table: "UserPermissions");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPermissions_Permission_PermissionId",
                table: "UserPermissions",
                column: "PermissionId",
                principalTable: "Permission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPermissions_User_UserId",
                table: "UserPermissions",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
