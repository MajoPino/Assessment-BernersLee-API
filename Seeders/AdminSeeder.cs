using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_BernersLee_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Assessment_BernersLee_API.Seeders;
public class AdminSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>().HasData(
            new Admin
            {
                Id = 1,
                Name = "erwin",
                LastName = "smith",
                Email = "erwin.smith@example.com",
                Password = "password123"
            },
            new Admin
            {
                Id = 2,
                Name = "majo",
                LastName = "pino",
                Email = "majopino@example.com",
                Password = "password456"
            },
            new Admin
            {
                Id = 3,
                Name = "admin",
                LastName = "admin",
                Email = "admin@example.com",
                Password = "admin123"
            }
        );
    }
}
