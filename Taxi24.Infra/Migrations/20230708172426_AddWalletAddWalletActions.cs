using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddWalletAddWalletActions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WalletActions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WalletId = table.Column<int>(type: "int", nullable: false),
                    WalletActionType = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: true),
                    WalletId1 = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ModificationUser = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WalletActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WalletActions_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WalletActions_Wallet_WalletId",
                        column: x => x.WalletId,
                        principalTable: "Wallet",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WalletActions_Wallet_WalletId1",
                        column: x => x.WalletId1,
                        principalTable: "Wallet",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_WalletActions_AccountId",
                table: "WalletActions",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_WalletActions_WalletId",
                table: "WalletActions",
                column: "WalletId");

            migrationBuilder.CreateIndex(
                name: "IX_WalletActions_WalletId1",
                table: "WalletActions",
                column: "WalletId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WalletActions");
        }
    }
}
