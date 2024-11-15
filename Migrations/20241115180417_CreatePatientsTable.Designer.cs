﻿// <auto-generated />
using Assessment_BernersLee_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assessment_BernersLee_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241115180417_CreatePatientsTable")]
    partial class CreatePatientsTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Assessment_BernersLee_API.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("email");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("password");

                    b.HasKey("Id");

                    b.ToTable("admins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "erwin.smith@example.com",
                            LastName = "smith",
                            Name = "erwin",
                            Password = "password123"
                        },
                        new
                        {
                            Id = 2,
                            Email = "majopino@example.com",
                            LastName = "pino",
                            Name = "majo",
                            Password = "password456"
                        },
                        new
                        {
                            Id = 3,
                            Email = "admin@example.com",
                            LastName = "admin",
                            Name = "admin",
                            Password = "admin123"
                        });
                });

            modelBuilder.Entity("Assessment_BernersLee_API.Models.Medic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("email");

                    b.Property<string>("IdentificationNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("identification_number");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("password");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("phone_number");

                    b.HasKey("Id");

                    b.ToTable("medics");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "john.doe@example.com",
                            IdentificationNumber = "1234567890",
                            LastName = "Doe",
                            Name = "John",
                            Password = "password123",
                            PhoneNumber = "1234567890"
                        },
                        new
                        {
                            Id = 2,
                            Email = "alice.johnson@example.com",
                            IdentificationNumber = "9876543210",
                            LastName = "Johnson",
                            Name = "Alice",
                            Password = "password456",
                            PhoneNumber = "2345678901"
                        },
                        new
                        {
                            Id = 3,
                            Email = "michael.williams@example.com",
                            IdentificationNumber = "1122334455",
                            LastName = "Williams",
                            Name = "Michael",
                            Password = "password789",
                            PhoneNumber = "3456789012"
                        },
                        new
                        {
                            Id = 4,
                            Email = "sarah.brown@example.com",
                            IdentificationNumber = "2233445566",
                            LastName = "Brown",
                            Name = "Sarah",
                            Password = "password321",
                            PhoneNumber = "4567890123"
                        },
                        new
                        {
                            Id = 5,
                            Email = "david.davis@example.com",
                            IdentificationNumber = "3344556677",
                            LastName = "Davis",
                            Name = "David",
                            Password = "password654",
                            PhoneNumber = "5678901234"
                        },
                        new
                        {
                            Id = 6,
                            Email = "emily.miller@example.com",
                            IdentificationNumber = "4455667788",
                            LastName = "Miller",
                            Name = "Emily",
                            Password = "password987",
                            PhoneNumber = "6789012345"
                        },
                        new
                        {
                            Id = 7,
                            Email = "james.wilson@example.com",
                            IdentificationNumber = "5566778899",
                            LastName = "Wilson",
                            Name = "James",
                            Password = "password1234",
                            PhoneNumber = "7890123456"
                        },
                        new
                        {
                            Id = 8,
                            Email = "jessica.moore@example.com",
                            IdentificationNumber = "6677889900",
                            LastName = "Moore",
                            Name = "Jessica",
                            Password = "password4321",
                            PhoneNumber = "8901234567"
                        },
                        new
                        {
                            Id = 9,
                            Email = "daniel.taylor@example.com",
                            IdentificationNumber = "7788990011",
                            LastName = "Taylor",
                            Name = "Daniel",
                            Password = "password567",
                            PhoneNumber = "9012345678"
                        },
                        new
                        {
                            Id = 10,
                            Email = "olivia.anderson@example.com",
                            IdentificationNumber = "8899001122",
                            LastName = "Anderson",
                            Name = "Olivia",
                            Password = "password876",
                            PhoneNumber = "1234567899"
                        },
                        new
                        {
                            Id = 11,
                            Email = "matthew.thomas@example.com",
                            IdentificationNumber = "9900112233",
                            LastName = "Thomas",
                            Name = "Matthew",
                            Password = "password2345",
                            PhoneNumber = "2345678908"
                        },
                        new
                        {
                            Id = 12,
                            Email = "sophia.jackson@example.com",
                            IdentificationNumber = "1001122334",
                            LastName = "Jackson",
                            Name = "Sophia",
                            Password = "password5678",
                            PhoneNumber = "3456789017"
                        },
                        new
                        {
                            Id = 13,
                            Email = "ethan.white@example.com",
                            IdentificationNumber = "1112233445",
                            LastName = "White",
                            Name = "Ethan",
                            Password = "password8901",
                            PhoneNumber = "4567890126"
                        },
                        new
                        {
                            Id = 14,
                            Email = "charlotte.harris@example.com",
                            IdentificationNumber = "2223344556",
                            LastName = "Harris",
                            Name = "Charlotte",
                            Password = "password12345",
                            PhoneNumber = "5678901235"
                        },
                        new
                        {
                            Id = 15,
                            Email = "benjamin.martin@example.com",
                            IdentificationNumber = "3334455667",
                            LastName = "Martin",
                            Name = "Benjamin",
                            Password = "password6789",
                            PhoneNumber = "6789012346"
                        },
                        new
                        {
                            Id = 16,
                            Email = "avery.lee@example.com",
                            IdentificationNumber = "4445566778",
                            LastName = "Lee",
                            Name = "Avery",
                            Password = "password234",
                            PhoneNumber = "7890123457"
                        },
                        new
                        {
                            Id = 17,
                            Email = "mason.perez@example.com",
                            IdentificationNumber = "5556677889",
                            LastName = "Perez",
                            Name = "Mason",
                            Password = "password8765",
                            PhoneNumber = "8901234568"
                        },
                        new
                        {
                            Id = 18,
                            Email = "lily.wilson@example.com",
                            IdentificationNumber = "6667788990",
                            LastName = "Wilson",
                            Name = "Lily",
                            Password = "password5432",
                            PhoneNumber = "9012345679"
                        },
                        new
                        {
                            Id = 19,
                            Email = "henry.gonzalez@example.com",
                            IdentificationNumber = "7778899001",
                            LastName = "Gonzalez",
                            Name = "Henry",
                            Password = "password9876",
                            PhoneNumber = "1234567800"
                        },
                        new
                        {
                            Id = 20,
                            Email = "zoe.rodriguez@example.com",
                            IdentificationNumber = "8889900112",
                            LastName = "Rodriguez",
                            Name = "Zoe",
                            Password = "password432",
                            PhoneNumber = "2345678910"
                        });
                });

            modelBuilder.Entity("Assessment_BernersLee_API.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("email");

                    b.Property<string>("IdentificationNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("identification_number");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("password");

                    b.Property<string>("PatientDescription")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("patient_description");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("phone_number");

                    b.HasKey("Id");

                    b.ToTable("patients");
                });
#pragma warning restore 612, 618
        }
    }
}
