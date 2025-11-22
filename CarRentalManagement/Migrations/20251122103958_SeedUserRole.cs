using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "7e36ab32-2593-452c-b9c7-a9e07d7f8bac", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEJAT90IQWuRqQz3P3lUr0/lSFajIgNiEmcX8cmqxjb5HdSloC7TkWK7H2zHlylLW5g==", null, false, "5b553820-526f-41fb-a9e7-fc99983fb502", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 18, 39, 57, 988, DateTimeKind.Local).AddTicks(6880), new DateTime(2025, 11, 22, 18, 39, 57, 988, DateTimeKind.Local).AddTicks(6891) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 18, 39, 57, 988, DateTimeKind.Local).AddTicks(6893), new DateTime(2025, 11, 22, 18, 39, 57, 988, DateTimeKind.Local).AddTicks(6893) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 18, 39, 57, 988, DateTimeKind.Local).AddTicks(7029), new DateTime(2025, 11, 22, 18, 39, 57, 988, DateTimeKind.Local).AddTicks(7029) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 18, 39, 57, 988, DateTimeKind.Local).AddTicks(7031), new DateTime(2025, 11, 22, 18, 39, 57, 988, DateTimeKind.Local).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 18, 39, 57, 988, DateTimeKind.Local).AddTicks(7095), new DateTime(2025, 11, 22, 18, 39, 57, 988, DateTimeKind.Local).AddTicks(7095) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 18, 39, 57, 988, DateTimeKind.Local).AddTicks(7097), new DateTime(2025, 11, 22, 18, 39, 57, 988, DateTimeKind.Local).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 18, 39, 57, 988, DateTimeKind.Local).AddTicks(7098), new DateTime(2025, 11, 22, 18, 39, 57, 988, DateTimeKind.Local).AddTicks(7099) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 18, 39, 57, 988, DateTimeKind.Local).AddTicks(7100), new DateTime(2025, 11, 22, 18, 39, 57, 988, DateTimeKind.Local).AddTicks(7100) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 18, 6, 30, 97, DateTimeKind.Local).AddTicks(8801), new DateTime(2025, 11, 22, 18, 6, 30, 97, DateTimeKind.Local).AddTicks(8811) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 18, 6, 30, 97, DateTimeKind.Local).AddTicks(8813), new DateTime(2025, 11, 22, 18, 6, 30, 97, DateTimeKind.Local).AddTicks(8813) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 18, 6, 30, 97, DateTimeKind.Local).AddTicks(8958), new DateTime(2025, 11, 22, 18, 6, 30, 97, DateTimeKind.Local).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 18, 6, 30, 97, DateTimeKind.Local).AddTicks(8960), new DateTime(2025, 11, 22, 18, 6, 30, 97, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 18, 6, 30, 97, DateTimeKind.Local).AddTicks(9020), new DateTime(2025, 11, 22, 18, 6, 30, 97, DateTimeKind.Local).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 18, 6, 30, 97, DateTimeKind.Local).AddTicks(9051), new DateTime(2025, 11, 22, 18, 6, 30, 97, DateTimeKind.Local).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 18, 6, 30, 97, DateTimeKind.Local).AddTicks(9053), new DateTime(2025, 11, 22, 18, 6, 30, 97, DateTimeKind.Local).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 22, 18, 6, 30, 97, DateTimeKind.Local).AddTicks(9054), new DateTime(2025, 11, 22, 18, 6, 30, 97, DateTimeKind.Local).AddTicks(9055) });
        }
    }
}
