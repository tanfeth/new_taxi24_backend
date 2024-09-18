using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Taxi24.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddLookupsValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Lookup",
                columns: new[] { "Id", "Code", "CreationDate", "CreationUser", "IsDeleted", "ModificationDate", "ModificationUser", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, "cars", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "سيارات", "Cars" },
                    { 2, "nationality", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "الجنسية", "Nationalities" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
