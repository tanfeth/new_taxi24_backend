using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxi24.Infra.Migrations
{
    public partial class AddCarModelId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CarModelId",
                table: "Car",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CarTypeId",
                table: "Car",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_CityId",
                table: "User",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Car_CarModelId",
                table: "Car",
                column: "CarModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Car_CarTypeId",
                table: "Car",
                column: "CarTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_LookupValues_CarModelId",
                table: "Car",
                column: "CarModelId",
                principalTable: "LookupValues",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_LookupValues_CarTypeId",
                table: "Car",
                column: "CarTypeId",
                principalTable: "LookupValues",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_LookupValues_CityId",
                table: "User",
                column: "CityId",
                principalTable: "LookupValues",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_LookupValues_CarModelId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_LookupValues_CarTypeId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_User_LookupValues_CityId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_CityId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Car_CarModelId",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Car_CarTypeId",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CarModelId",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "CarTypeId",
                table: "Car");
        }
    }
}
