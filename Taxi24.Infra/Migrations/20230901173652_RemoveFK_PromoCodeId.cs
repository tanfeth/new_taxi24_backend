using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class RemoveFK_PromoCodeId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Order_PromoCodeId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "PromoCode");

            migrationBuilder.CreateIndex(
                name: "IX_Order_PromoCodeId",
                table: "Order",
                column: "PromoCodeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Order_PromoCodeId",
                table: "Order");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "PromoCode",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_PromoCodeId",
                table: "Order",
                column: "PromoCodeId",
                unique: true);
        }
    }
}
