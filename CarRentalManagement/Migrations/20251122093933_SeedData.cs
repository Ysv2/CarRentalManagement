using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 22, 17, 39, 32, 938, DateTimeKind.Local).AddTicks(2488), new DateTime(2025, 11, 22, 17, 39, 32, 938, DateTimeKind.Local).AddTicks(2498), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 22, 17, 39, 32, 938, DateTimeKind.Local).AddTicks(2500), new DateTime(2025, 11, 22, 17, 39, 32, 938, DateTimeKind.Local).AddTicks(2500), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 22, 17, 39, 32, 938, DateTimeKind.Local).AddTicks(2641), new DateTime(2025, 11, 22, 17, 39, 32, 938, DateTimeKind.Local).AddTicks(2642), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 22, 17, 39, 32, 938, DateTimeKind.Local).AddTicks(2643), new DateTime(2025, 11, 22, 17, 39, 32, 938, DateTimeKind.Local).AddTicks(2644), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 22, 17, 39, 32, 938, DateTimeKind.Local).AddTicks(2702), new DateTime(2025, 11, 22, 17, 39, 32, 938, DateTimeKind.Local).AddTicks(2703), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 22, 17, 39, 32, 938, DateTimeKind.Local).AddTicks(2704), new DateTime(2025, 11, 22, 17, 39, 32, 938, DateTimeKind.Local).AddTicks(2705), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 22, 17, 39, 32, 938, DateTimeKind.Local).AddTicks(2706), new DateTime(2025, 11, 22, 17, 39, 32, 938, DateTimeKind.Local).AddTicks(2706), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 22, 17, 39, 32, 938, DateTimeKind.Local).AddTicks(2707), new DateTime(2025, 11, 22, 17, 39, 32, 938, DateTimeKind.Local).AddTicks(2708), "C_HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
