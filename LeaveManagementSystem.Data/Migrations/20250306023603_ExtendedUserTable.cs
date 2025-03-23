using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "efd188e2-804b-46e4-9def-6ad489444062",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed8d3042-d840-44b6-b9b7-160d4c0ff535", new DateOnly(1992, 3, 11), "Default", "Admin", "AQAAAAIAAYagAAAAEHCLQ8BR9ropqyR4o3PfHAGz44eTxD5OJde6t1bF0Tf9hT/TsdoBiGdp1YymwMYmgA==", "09135988-67a8-4c9a-8d16-a10d70bcacea" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "efd188e2-804b-46e4-9def-6ad489444062",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d56675a9-88c6-4280-a38a-99cdc8f5f22b", "AQAAAAIAAYagAAAAEMSMfz5RbJ/F9jM+6L82RyE9yZCaHJ238F+UqZaMkClH6qd+llbMUbHR1bfnfdsx3g==", "0d242316-b812-4dca-92f1-4d35420e6ee5" });
        }
    }
}
