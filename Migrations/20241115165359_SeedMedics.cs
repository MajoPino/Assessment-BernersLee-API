using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assessment_BernersLee_API.Migrations
{
    /// <inheritdoc />
    public partial class SeedMedics : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "medics",
                columns: new[] { "id", "email", "identification_number", "last_name", "name", "password", "phone_number" },
                values: new object[,]
                {
                    { 1, "john.doe@example.com", "1234567890", "Doe", "John", "password123", "1234567890" },
                    { 2, "alice.johnson@example.com", "9876543210", "Johnson", "Alice", "password456", "2345678901" },
                    { 3, "michael.williams@example.com", "1122334455", "Williams", "Michael", "password789", "3456789012" },
                    { 4, "sarah.brown@example.com", "2233445566", "Brown", "Sarah", "password321", "4567890123" },
                    { 5, "david.davis@example.com", "3344556677", "Davis", "David", "password654", "5678901234" },
                    { 6, "emily.miller@example.com", "4455667788", "Miller", "Emily", "password987", "6789012345" },
                    { 7, "james.wilson@example.com", "5566778899", "Wilson", "James", "password1234", "7890123456" },
                    { 8, "jessica.moore@example.com", "6677889900", "Moore", "Jessica", "password4321", "8901234567" },
                    { 9, "daniel.taylor@example.com", "7788990011", "Taylor", "Daniel", "password567", "9012345678" },
                    { 10, "olivia.anderson@example.com", "8899001122", "Anderson", "Olivia", "password876", "1234567899" },
                    { 11, "matthew.thomas@example.com", "9900112233", "Thomas", "Matthew", "password2345", "2345678908" },
                    { 12, "sophia.jackson@example.com", "1001122334", "Jackson", "Sophia", "password5678", "3456789017" },
                    { 13, "ethan.white@example.com", "1112233445", "White", "Ethan", "password8901", "4567890126" },
                    { 14, "charlotte.harris@example.com", "2223344556", "Harris", "Charlotte", "password12345", "5678901235" },
                    { 15, "benjamin.martin@example.com", "3334455667", "Martin", "Benjamin", "password6789", "6789012346" },
                    { 16, "avery.lee@example.com", "4445566778", "Lee", "Avery", "password234", "7890123457" },
                    { 17, "mason.perez@example.com", "5556677889", "Perez", "Mason", "password8765", "8901234568" },
                    { 18, "lily.wilson@example.com", "6667788990", "Wilson", "Lily", "password5432", "9012345679" },
                    { 19, "henry.gonzalez@example.com", "7778899001", "Gonzalez", "Henry", "password9876", "1234567800" },
                    { 20, "zoe.rodriguez@example.com", "8889900112", "Rodriguez", "Zoe", "password432", "2345678910" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "medics",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "medics",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "medics",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "medics",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "medics",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "medics",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "medics",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "medics",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "medics",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "medics",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "medics",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "medics",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "medics",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "medics",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "medics",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "medics",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "medics",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "medics",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "medics",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "medics",
                keyColumn: "id",
                keyValue: 20);
        }
    }
}
