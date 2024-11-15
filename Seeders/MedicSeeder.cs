using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_BernersLee_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Assessment_BernersLee_API.Seeders;
public class MedicSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Medic>().HasData(
            new Medic { Id = 1, Name = "John", LastName = "Doe", IdentificationNumber = "1234567890", Email = "john.doe@example.com", PhoneNumber = "1234567890", Password = "password123" },
    new Medic { Id = 2, Name = "Alice", LastName = "Johnson", IdentificationNumber = "9876543210", Email = "alice.johnson@example.com", PhoneNumber = "2345678901", Password = "password456" },
    new Medic { Id = 3, Name = "Michael", LastName = "Williams", IdentificationNumber = "1122334455", Email = "michael.williams@example.com", PhoneNumber = "3456789012", Password = "password789" },
    new Medic { Id = 4, Name = "Sarah", LastName = "Brown", IdentificationNumber = "2233445566", Email = "sarah.brown@example.com", PhoneNumber = "4567890123", Password = "password321" },
    new Medic { Id = 5, Name = "David", LastName = "Davis", IdentificationNumber = "3344556677", Email = "david.davis@example.com", PhoneNumber = "5678901234", Password = "password654" },
    new Medic { Id = 6, Name = "Emily", LastName = "Miller", IdentificationNumber = "4455667788", Email = "emily.miller@example.com", PhoneNumber = "6789012345", Password = "password987" },
    new Medic { Id = 7, Name = "James", LastName = "Wilson", IdentificationNumber = "5566778899", Email = "james.wilson@example.com", PhoneNumber = "7890123456", Password = "password1234" },
    new Medic { Id = 8, Name = "Jessica", LastName = "Moore", IdentificationNumber = "6677889900", Email = "jessica.moore@example.com", PhoneNumber = "8901234567", Password = "password4321" },
    new Medic { Id = 9, Name = "Daniel", LastName = "Taylor", IdentificationNumber = "7788990011", Email = "daniel.taylor@example.com", PhoneNumber = "9012345678", Password = "password567" },
    new Medic { Id = 10, Name = "Olivia", LastName = "Anderson", IdentificationNumber = "8899001122", Email = "olivia.anderson@example.com", PhoneNumber = "1234567899", Password = "password876" },
    new Medic { Id = 11, Name = "Matthew", LastName = "Thomas", IdentificationNumber = "9900112233", Email = "matthew.thomas@example.com", PhoneNumber = "2345678908", Password = "password2345" },
    new Medic { Id = 12, Name = "Sophia", LastName = "Jackson", IdentificationNumber = "1001122334", Email = "sophia.jackson@example.com", PhoneNumber = "3456789017", Password = "password5678" },
    new Medic { Id = 13, Name = "Ethan", LastName = "White", IdentificationNumber = "1112233445", Email = "ethan.white@example.com", PhoneNumber = "4567890126", Password = "password8901" },
    new Medic { Id = 14, Name = "Charlotte", LastName = "Harris", IdentificationNumber = "2223344556", Email = "charlotte.harris@example.com", PhoneNumber = "5678901235", Password = "password12345" },
    new Medic { Id = 15, Name = "Benjamin", LastName = "Martin", IdentificationNumber = "3334455667", Email = "benjamin.martin@example.com", PhoneNumber = "6789012346", Password = "password6789" },
    new Medic { Id = 16, Name = "Avery", LastName = "Lee", IdentificationNumber = "4445566778", Email = "avery.lee@example.com", PhoneNumber = "7890123457", Password = "password234" },
    new Medic { Id = 17, Name = "Mason", LastName = "Perez", IdentificationNumber = "5556677889", Email = "mason.perez@example.com", PhoneNumber = "8901234568", Password = "password8765" },
    new Medic { Id = 18, Name = "Lily", LastName = "Wilson", IdentificationNumber = "6667788990", Email = "lily.wilson@example.com", PhoneNumber = "9012345679", Password = "password5432" },
    new Medic { Id = 19, Name = "Henry", LastName = "Gonzalez", IdentificationNumber = "7778899001", Email = "henry.gonzalez@example.com", PhoneNumber = "1234567800", Password = "password9876" },
    new Medic { Id = 20, Name = "Zoe", LastName = "Rodriguez", IdentificationNumber = "8889900112", Email = "zoe.rodriguez@example.com", PhoneNumber = "2345678910", Password = "password432" }
        );
    }
}
