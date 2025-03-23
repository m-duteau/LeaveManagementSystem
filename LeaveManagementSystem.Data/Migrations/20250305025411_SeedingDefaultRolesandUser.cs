using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRolesandUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05ef557c-95bc-47d3-aaff-221515d525a2", null, "Administrator", "ADMINISTRATOR" },
                    { "18ea90e4-e544-4caa-9ef8-d496a804678a", null, "Employee", "EMPLOYEE" },
                    { "789a217e-5340-4621-841f-e379d9947b1f", null, "Supervisor", "SUPERVISOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "efd188e2-804b-46e4-9def-6ad489444062", 0, "d56675a9-88c6-4280-a38a-99cdc8f5f22b", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEMSMfz5RbJ/F9jM+6L82RyE9yZCaHJ238F+UqZaMkClH6qd+llbMUbHR1bfnfdsx3g==", null, false, "0d242316-b812-4dca-92f1-4d35420e6ee5", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "05ef557c-95bc-47d3-aaff-221515d525a2", "efd188e2-804b-46e4-9def-6ad489444062" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18ea90e4-e544-4caa-9ef8-d496a804678a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "789a217e-5340-4621-841f-e379d9947b1f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "05ef557c-95bc-47d3-aaff-221515d525a2", "efd188e2-804b-46e4-9def-6ad489444062" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05ef557c-95bc-47d3-aaff-221515d525a2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "efd188e2-804b-46e4-9def-6ad489444062");
        }
    }
}
