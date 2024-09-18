using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddMixPaymentAddLocationIdToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DepitFromWalletAmount",
                table: "Order",
                type: "decimal(65,30)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Order",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_LocationId",
                table: "Order",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Location_LocationId",
                table: "Order",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Location_LocationId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_LocationId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "DepitFromWalletAmount",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Order");
        }
    }
}
