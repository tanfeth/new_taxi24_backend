using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class OrderTempTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderTemp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SedanCarPrice = table.Column<double>(type: "double", nullable: false),
                    FamilyCarPrice = table.Column<double>(type: "double", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    DistanceInKM = table.Column<int>(type: "int", nullable: false),
                    PromoCodeId = table.Column<int>(type: "int", nullable: true),
                    StartPrice = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DurationPrice = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SedanCarPriceKM = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FamilyCarPriceKM = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreationUser = table.Column<int>(type: "int", nullable: true),
                    ModificationUser = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderTemp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderTemp_PromoCode_PromoCodeId",
                        column: x => x.PromoCodeId,
                        principalTable: "PromoCode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderTemp_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_OrderTemp_PromoCodeId",
                table: "OrderTemp",
                column: "PromoCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderTemp_UserId",
                table: "OrderTemp",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderTemp");
        }
    }
}
