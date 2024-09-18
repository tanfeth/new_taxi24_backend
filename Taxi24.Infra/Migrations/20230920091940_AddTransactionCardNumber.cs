using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddTransactionCardNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CardNumber",
                table: "Transaction",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "CardId",
                table: "Order",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_CardId",
                table: "Order",
                column: "CardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Card_CardId",
                table: "Order",
                column: "CardId",
                principalTable: "Card",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Card_CardId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_CardId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CardNumber",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "CardId",
                table: "Order");
        }
    }
}
