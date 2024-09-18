﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddTripIdToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TripId",
                table: "Order",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TripId",
                table: "Order");
        }
    }
}
