using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddPaymentMethodEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "Order",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DriverAcceptOrderDate",
                table: "Order",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ErrorInRegistreToWsl",
                table: "Order",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "IsRegisterdInWsl",
                table: "Order",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "CashWallet" },
                    { 5, "CreditWallet" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_CarId",
                table: "Order",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Car_CarId",
                table: "Order",
                column: "CarId",
                principalTable: "Car",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Car_CarId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_CarId",
                table: "Order");

            migrationBuilder.DeleteData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "DriverAcceptOrderDate",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ErrorInRegistreToWsl",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "IsRegisterdInWsl",
                table: "Order");
        }
    }
}
