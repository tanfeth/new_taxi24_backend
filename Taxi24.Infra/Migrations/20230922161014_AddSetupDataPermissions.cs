using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddSetupDataPermissions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permission_Permission_ParentId",
                table: "Permission");

            migrationBuilder.AlterColumn<int>(
                name: "ParentId",
                table: "Permission",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "Code", "CreationDate", "CreationUser", "IsDeleted", "ModificationDate", "ModificationUser", "NameAr", "NameEn", "ParentId" },
                values: new object[,]
                {
                    { 1, "Driver", null, null, false, null, null, "Driver", "Driver", null },
                    { 2, "delete_driver", null, null, false, null, null, "Delete Driver", "Delete Driver", 1 },
                    { 3, "approve_documents", null, null, false, null, null, "Approve ,  Reject Documents", "Approve ,  Reject Documents", 1 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Permission_Permission_ParentId",
                table: "Permission",
                column: "ParentId",
                principalTable: "Permission",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permission_Permission_ParentId",
                table: "Permission");

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "ParentId",
                table: "Permission",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Permission_Permission_ParentId",
                table: "Permission",
                column: "ParentId",
                principalTable: "Permission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
