using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_BernersLee_API.Models;
using Assessment_BernersLee_API.Seeders;
using Microsoft.EntityFrameworkCore;

namespace Assessment_BernersLee_API.Data;
public class AppDbContext : DbContext
{
    public DbSet<Admin> Admins { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        AdminSeeder.Seed(modelBuilder);
    }
}
