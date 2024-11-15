using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assessment_BernersLee_API.Migrations
{
    /// <inheritdoc />
    public partial class SeedPatients : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "patients",
                columns: new[] { "id", "email", "identification_number", "last_name", "name", "password", "patient_description", "phone_number" },
                values: new object[,]
                {
                    { 1, "jane.smith@example.com", "9876543210", "Smith", "Jane", "password123", "Jane is a 35-year-old woman with a history of heart disease.", "9876543210" },
                    { 2, "oliver.brown@example.com", "1234567890", "Brown", "Oliver", "password456", "Oliver is a 42-year-old man recovering from a recent knee surgery.", "1234567890" },
                    { 3, "emily.davis@example.com", "1122334455", "Davis", "Emily", "password789", "Emily is a 29-year-old woman undergoing treatment for asthma.", "2345678901" },
                    { 4, "james.wilson@example.com", "2233445566", "Wilson", "James", "password321", "James is a 60-year-old man with diabetes and high blood pressure.", "3456789012" },
                    { 5, "sophia.martinez@example.com", "3344556677", "Martinez", "Sophia", "password654", "Sophia is a 50-year-old woman being treated for chronic migraines.", "4567890123" },
                    { 6, "benjamin.garcia@example.com", "4455667788", "Garcia", "Benjamin", "password987", "Benjamin is a 38-year-old man with a recent diagnosis of depression.", "5678901234" },
                    { 7, "mia.lopez@example.com", "5566778899", "Lopez", "Mia", "password1234", "Mia is a 27-year-old woman with a history of seasonal allergies.", "6789012345" },
                    { 8, "ethan.hernandez@example.com", "6677889900", "Hernandez", "Ethan", "password4321", "Ethan is a 45-year-old man recovering from a stroke.", "7890123456" },
                    { 9, "charlotte.gonzalez@example.com", "7788990011", "Gonzalez", "Charlotte", "password567", "Charlotte is a 32-year-old woman with autoimmune disorder treatment.", "8901234567" },
                    { 10, "liam.rodriguez@example.com", "8899001122", "Rodriguez", "Liam", "password876", "Liam is a 40-year-old man recovering from a sports injury.", "9012345678" },
                    { 11, "isabella.perez@example.com", "9900112233", "Perez", "Isabella", "password2345", "Isabella is a 24-year-old woman undergoing physical therapy.", "1234567899" },
                    { 12, "lucas.hall@example.com", "1001122334", "Hall", "Lucas", "password5678", "Lucas is a 55-year-old man with chronic back pain.", "2345678908" },
                    { 13, "ava.allen@example.com", "1112233445", "Allen", "Ava", "password8901", "Ava is a 19-year-old woman with a history of anemia.", "3456789017" },
                    { 14, "noah.young@example.com", "2223344556", "Young", "Noah", "password12345", "Noah is a 36-year-old man with high cholesterol.", "4567890126" },
                    { 15, "grace.king@example.com", "3334455667", "King", "Grace", "password6789", "Grace is a 48-year-old woman being treated for arthritis.", "5678901235" },
                    { 16, "logan.wright@example.com", "4445566778", "Wright", "Logan", "password234", "Logan is a 30-year-old man recovering from appendicitis surgery.", "6789012346" },
                    { 17, "ella.scott@example.com", "5556677889", "Scott", "Ella", "password8765", "Ella is a 22-year-old woman with celiac disease.", "7890123457" },
                    { 18, "jacob.torres@example.com", "6667788990", "Torres", "Jacob", "password5432", "Jacob is a 59-year-old man undergoing cancer treatment.", "8901234568" },
                    { 19, "victoria.nguyen@example.com", "7778899001", "Nguyen", "Victoria", "password9876", "Victoria is a 62-year-old woman with hypertension.", "9012345679" },
                    { 20, "henry.lewis@example.com", "8889900112", "Lewis", "Henry", "password432", "Henry is a 43-year-old man with thyroid issues.", "1234567800" },
                    { 21, "luna.walker@example.com", "9990011223", "Walker", "Luna", "password6543", "Luna is a 29-year-old woman with chronic fatigue.", "2345678910" },
                    { 22, "jack.hill@example.com", "1011122334", "Hill", "Jack", "password87654", "Jack is a 51-year-old man recovering from hip replacement surgery.", "3456789021" },
                    { 23, "chloe.green@example.com", "1112233445", "Green", "Chloe", "password123456", "Chloe is a 37-year-old woman managing chronic sinus infections.", "4567890132" },
                    { 24, "samuel.adams@example.com", "2223344556", "Adams", "Samuel", "password78901", "Samuel is a 47-year-old man with kidney stones.", "5678901243" },
                    { 25, "zoe.carter@example.com", "3334455667", "Carter", "Zoe", "password54321", "Zoe is a 26-year-old woman undergoing psychological therapy.", "6789012354" },
                    { 26, "nathan.baker@example.com", "4445566778", "Baker", "Nathan", "password67890", "Nathan is a 39-year-old man recovering from a motorcycle accident.", "7890123465" },
                    { 27, "stella.nelson@example.com", "5556677889", "Nelson", "Stella", "password234567", "Stella is a 33-year-old woman with epilepsy.", "8901234576" },
                    { 28, "elias.mitchell@example.com", "6667788990", "Mitchell", "Elias", "password76543", "Elias is a 41-year-old man with a history of chronic headaches.", "9012345687" },
                    { 29, "hannah.rivera@example.com", "7778899001", "Rivera", "Hannah", "password45678", "Hannah is a 34-year-old woman with a persistent rash.", "1234567898" },
                    { 30, "ryan.parker@example.com", "8889900112", "Parker", "Ryan", "password876543", "Ryan is a 25-year-old man recovering from a sports-related injury.", "2345678909" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 30);
        }
    }
}
