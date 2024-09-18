using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class RemovePaymentMethodsFromPromoCodes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PromoCode_PaymentMethod_PaymentMethodId",
                table: "PromoCode");

            migrationBuilder.DropIndex(
                name: "IX_PromoCode_PaymentMethodId",
                table: "PromoCode");

            migrationBuilder.DropColumn(
                name: "PaymentMethodId",
                table: "PromoCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaymentMethodId",
                table: "PromoCode",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PromoCode_PaymentMethodId",
                table: "PromoCode",
                column: "PaymentMethodId");

            migrationBuilder.AddForeignKey(
                name: "FK_PromoCode_PaymentMethod_PaymentMethodId",
                table: "PromoCode",
                column: "PaymentMethodId",
                principalTable: "PaymentMethod",
                principalColumn: "Id");
        }
    }
}
