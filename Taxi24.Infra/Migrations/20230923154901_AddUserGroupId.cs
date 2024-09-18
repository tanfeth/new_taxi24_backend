using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddUserGroupId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "Code", "CreationDate", "CreationUser", "IsDeleted", "ModificationDate", "ModificationUser", "NameAr", "NameEn", "ParentId" },
                values: new object[,]
                {
                    { 22, "group", null, null, false, null, null, "Groups", "Groups", null },
                    { 23, "group_add", null, null, false, null, null, "Groups Add", "Groups Add", 22 },
                    { 24, "group_edit", null, null, false, null, null, "Groups Edit", "Groups Edit", 22 },
                    { 25, "group_delete", null, null, false, null, null, "Groups Delete", "Groups Delete", 22 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_GroupId",
                table: "User",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Group_GroupId",
                table: "User",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Group_GroupId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_GroupId",
                table: "User");

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "User");
        }
    }
}
