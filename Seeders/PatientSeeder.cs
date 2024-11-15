using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_BernersLee_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Assessment_BernersLee_API.Seeders;
public class PatientSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Patient>().HasData(
            new Patient { Id = 1, Name = "Jane", LastName = "Smith", IdentificationNumber = "9876543210", Email = "jane.smith@example.com", PhoneNumber = "9876543210", PatientDescription = "Jane is a 35-year-old woman with a history of heart disease.", Password = "password123" },
    new Patient { Id = 2, Name = "Oliver", LastName = "Brown", IdentificationNumber = "1234567890", Email = "oliver.brown@example.com", PhoneNumber = "1234567890", PatientDescription = "Oliver is a 42-year-old man recovering from a recent knee surgery.", Password = "password456" },
    new Patient { Id = 3, Name = "Emily", LastName = "Davis", IdentificationNumber = "1122334455", Email = "emily.davis@example.com", PhoneNumber = "2345678901", PatientDescription = "Emily is a 29-year-old woman undergoing treatment for asthma.", Password = "password789" },
    new Patient { Id = 4, Name = "James", LastName = "Wilson", IdentificationNumber = "2233445566", Email = "james.wilson@example.com", PhoneNumber = "3456789012", PatientDescription = "James is a 60-year-old man with diabetes and high blood pressure.", Password = "password321" },
    new Patient { Id = 5, Name = "Sophia", LastName = "Martinez", IdentificationNumber = "3344556677", Email = "sophia.martinez@example.com", PhoneNumber = "4567890123", PatientDescription = "Sophia is a 50-year-old woman being treated for chronic migraines.", Password = "password654" },
    new Patient { Id = 6, Name = "Benjamin", LastName = "Garcia", IdentificationNumber = "4455667788", Email = "benjamin.garcia@example.com", PhoneNumber = "5678901234", PatientDescription = "Benjamin is a 38-year-old man with a recent diagnosis of depression.", Password = "password987" },
    new Patient { Id = 7, Name = "Mia", LastName = "Lopez", IdentificationNumber = "5566778899", Email = "mia.lopez@example.com", PhoneNumber = "6789012345", PatientDescription = "Mia is a 27-year-old woman with a history of seasonal allergies.", Password = "password1234" },
    new Patient { Id = 8, Name = "Ethan", LastName = "Hernandez", IdentificationNumber = "6677889900", Email = "ethan.hernandez@example.com", PhoneNumber = "7890123456", PatientDescription = "Ethan is a 45-year-old man recovering from a stroke.", Password = "password4321" },
    new Patient { Id = 9, Name = "Charlotte", LastName = "Gonzalez", IdentificationNumber = "7788990011", Email = "charlotte.gonzalez@example.com", PhoneNumber = "8901234567", PatientDescription = "Charlotte is a 32-year-old woman with autoimmune disorder treatment.", Password = "password567" },
    new Patient { Id = 10, Name = "Liam", LastName = "Rodriguez", IdentificationNumber = "8899001122", Email = "liam.rodriguez@example.com", PhoneNumber = "9012345678", PatientDescription = "Liam is a 40-year-old man recovering from a sports injury.", Password = "password876" },
    new Patient { Id = 11, Name = "Isabella", LastName = "Perez", IdentificationNumber = "9900112233", Email = "isabella.perez@example.com", PhoneNumber = "1234567899", PatientDescription = "Isabella is a 24-year-old woman undergoing physical therapy.", Password = "password2345" },
    new Patient { Id = 12, Name = "Lucas", LastName = "Hall", IdentificationNumber = "1001122334", Email = "lucas.hall@example.com", PhoneNumber = "2345678908", PatientDescription = "Lucas is a 55-year-old man with chronic back pain.", Password = "password5678" },
    new Patient { Id = 13, Name = "Ava", LastName = "Allen", IdentificationNumber = "1112233445", Email = "ava.allen@example.com", PhoneNumber = "3456789017", PatientDescription = "Ava is a 19-year-old woman with a history of anemia.", Password = "password8901" },
    new Patient { Id = 14, Name = "Noah", LastName = "Young", IdentificationNumber = "2223344556", Email = "noah.young@example.com", PhoneNumber = "4567890126", PatientDescription = "Noah is a 36-year-old man with high cholesterol.", Password = "password12345" },
    new Patient { Id = 15, Name = "Grace", LastName = "King", IdentificationNumber = "3334455667", Email = "grace.king@example.com", PhoneNumber = "5678901235", PatientDescription = "Grace is a 48-year-old woman being treated for arthritis.", Password = "password6789" },
    new Patient { Id = 16, Name = "Logan", LastName = "Wright", IdentificationNumber = "4445566778", Email = "logan.wright@example.com", PhoneNumber = "6789012346", PatientDescription = "Logan is a 30-year-old man recovering from appendicitis surgery.", Password = "password234" },
    new Patient { Id = 17, Name = "Ella", LastName = "Scott", IdentificationNumber = "5556677889", Email = "ella.scott@example.com", PhoneNumber = "7890123457", PatientDescription = "Ella is a 22-year-old woman with celiac disease.", Password = "password8765" },
    new Patient { Id = 18, Name = "Jacob", LastName = "Torres", IdentificationNumber = "6667788990", Email = "jacob.torres@example.com", PhoneNumber = "8901234568", PatientDescription = "Jacob is a 59-year-old man undergoing cancer treatment.", Password = "password5432" },
    new Patient { Id = 19, Name = "Victoria", LastName = "Nguyen", IdentificationNumber = "7778899001", Email = "victoria.nguyen@example.com", PhoneNumber = "9012345679", PatientDescription = "Victoria is a 62-year-old woman with hypertension.", Password = "password9876" },
    new Patient { Id = 20, Name = "Henry", LastName = "Lewis", IdentificationNumber = "8889900112", Email = "henry.lewis@example.com", PhoneNumber = "1234567800", PatientDescription = "Henry is a 43-year-old man with thyroid issues.", Password = "password432" },
    new Patient { Id = 21, Name = "Luna", LastName = "Walker", IdentificationNumber = "9990011223", Email = "luna.walker@example.com", PhoneNumber = "2345678910", PatientDescription = "Luna is a 29-year-old woman with chronic fatigue.", Password = "password6543" },
    new Patient { Id = 22, Name = "Jack", LastName = "Hill", IdentificationNumber = "1011122334", Email = "jack.hill@example.com", PhoneNumber = "3456789021", PatientDescription = "Jack is a 51-year-old man recovering from hip replacement surgery.", Password = "password87654" },
    new Patient { Id = 23, Name = "Chloe", LastName = "Green", IdentificationNumber = "1112233445", Email = "chloe.green@example.com", PhoneNumber = "4567890132", PatientDescription = "Chloe is a 37-year-old woman managing chronic sinus infections.", Password = "password123456" },
    new Patient { Id = 24, Name = "Samuel", LastName = "Adams", IdentificationNumber = "2223344556", Email = "samuel.adams@example.com", PhoneNumber = "5678901243", PatientDescription = "Samuel is a 47-year-old man with kidney stones.", Password = "password78901" },
    new Patient { Id = 25, Name = "Zoe", LastName = "Carter", IdentificationNumber = "3334455667", Email = "zoe.carter@example.com", PhoneNumber = "6789012354", PatientDescription = "Zoe is a 26-year-old woman undergoing psychological therapy.", Password = "password54321" },
    new Patient { Id = 26, Name = "Nathan", LastName = "Baker", IdentificationNumber = "4445566778", Email = "nathan.baker@example.com", PhoneNumber = "7890123465", PatientDescription = "Nathan is a 39-year-old man recovering from a motorcycle accident.", Password = "password67890" },
    new Patient { Id = 27, Name = "Stella", LastName = "Nelson", IdentificationNumber = "5556677889", Email = "stella.nelson@example.com", PhoneNumber = "8901234576", PatientDescription = "Stella is a 33-year-old woman with epilepsy.", Password = "password234567" },
    new Patient { Id = 28, Name = "Elias", LastName = "Mitchell", IdentificationNumber = "6667788990", Email = "elias.mitchell@example.com", PhoneNumber = "9012345687", PatientDescription = "Elias is a 41-year-old man with a history of chronic headaches.", Password = "password76543" },
    new Patient { Id = 29, Name = "Hannah", LastName = "Rivera", IdentificationNumber = "7778899001", Email = "hannah.rivera@example.com", PhoneNumber = "1234567898", PatientDescription = "Hannah is a 34-year-old woman with a persistent rash.", Password = "password45678" },
    new Patient { Id = 30, Name = "Ryan", LastName = "Parker", IdentificationNumber = "8889900112", Email = "ryan.parker@example.com", PhoneNumber = "2345678909", PatientDescription = "Ryan is a 25-year-old man recovering from a sports-related injury.", Password = "password876543" }
        );
    }
}
