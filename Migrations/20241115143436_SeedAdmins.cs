using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assessment_BernersLee_API.Migrations
{
    /// <inheritdoc />
    public partial class SeedAdmins : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "admins",
                columns: new[] { "id", "email", "last_name", "name", "password" },
                values: new object[,]
                {
                    { 1, "erwin.smith@example.com", "smith", "erwin", "password123" },
                    { 2, "majopino@example.com", "pino", "majo", "password456" },
                    { 3, "admin@example.com", "admin", "admin", "admin123" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "admins",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "admins",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "admins",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
