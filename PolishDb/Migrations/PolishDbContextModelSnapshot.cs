﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PolishDb;

#nullable disable

namespace PolishDb.Migrations
{
    [DbContext(typeof(PolishDbContext))]
    partial class PolishDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CompanyPerson", b =>
                {
                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("EmploymentTypeId")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasIndex("CompanyId");

                    b.HasIndex("EmploymentTypeId");

                    b.HasIndex("PersonId");

                    b.ToTable("CompanyPersons");
                });

            modelBuilder.Entity("PolishDb.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CompanyCEOName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyCEOName = "Jan Kowalski",
                            CompanyName = "Firma herbata"
                        },
                        new
                        {
                            Id = 2,
                            CompanyCEOName = "Anna Nowak",
                            CompanyName = "Firma samochód"
                        },
                        new
                        {
                            Id = 3,
                            CompanyCEOName = "Piotr Nowakowski",
                            CompanyName = "Firma dom"
                        },
                        new
                        {
                            Id = 4,
                            CompanyCEOName = "Alicja Wiśniewska",
                            CompanyName = "Firma książka"
                        },
                        new
                        {
                            Id = 5,
                            CompanyCEOName = "Marek Kaczmarek",
                            CompanyName = "Firma rower"
                        },
                        new
                        {
                            Id = 6,
                            CompanyCEOName = "Ewa Wojciechowska",
                            CompanyName = "Firma stół"
                        },
                        new
                        {
                            Id = 7,
                            CompanyCEOName = "Tomasz Malinowski",
                            CompanyName = "Firma lampa"
                        },
                        new
                        {
                            Id = 8,
                            CompanyCEOName = "Katarzyna Duda",
                            CompanyName = "Firma komputer"
                        },
                        new
                        {
                            Id = 9,
                            CompanyCEOName = "Bartosz Krawczyk",
                            CompanyName = "Firma telefon"
                        },
                        new
                        {
                            Id = 10,
                            CompanyCEOName = "Magdalena Pawlak",
                            CompanyName = "Firma telewizor"
                        },
                        new
                        {
                            Id = 11,
                            CompanyCEOName = "Wojciech Nowak",
                            CompanyName = "Firma drzwi"
                        },
                        new
                        {
                            Id = 12,
                            CompanyCEOName = "Zofia Szymańska",
                            CompanyName = "Firma sofa"
                        },
                        new
                        {
                            Id = 13,
                            CompanyCEOName = "Krzysztof Woźniak",
                            CompanyName = "Firma kawa"
                        },
                        new
                        {
                            Id = 14,
                            CompanyCEOName = "Elżbieta Kaczmarek",
                            CompanyName = "Firma biurko"
                        },
                        new
                        {
                            Id = 15,
                            CompanyCEOName = "Andrzej Kowalczyk",
                            CompanyName = "Firma fotel"
                        },
                        new
                        {
                            Id = 16,
                            CompanyCEOName = "Marta Wiśniewska",
                            CompanyName = "Firma telewizja"
                        },
                        new
                        {
                            Id = 17,
                            CompanyCEOName = "Paweł Nowak",
                            CompanyName = "Firma woda"
                        },
                        new
                        {
                            Id = 18,
                            CompanyCEOName = "Krystyna Szymańska",
                            CompanyName = "Firma okno"
                        },
                        new
                        {
                            Id = 19,
                            CompanyCEOName = "Michał Krawczyk",
                            CompanyName = "Firma komoda"
                        },
                        new
                        {
                            Id = 20,
                            CompanyCEOName = "Maria Malinowska",
                            CompanyName = "Firma herbata"
                        },
                        new
                        {
                            Id = 21,
                            CompanyCEOName = "Wojciech Nowak",
                            CompanyName = "Firma sofa"
                        },
                        new
                        {
                            Id = 22,
                            CompanyCEOName = "Zofia Szymańska",
                            CompanyName = "Firma samochód"
                        },
                        new
                        {
                            Id = 23,
                            CompanyCEOName = "Krzysztof Woźniak",
                            CompanyName = "Firma drzwi"
                        },
                        new
                        {
                            Id = 24,
                            CompanyCEOName = "Elżbieta Kaczmarek",
                            CompanyName = "Firma biurko"
                        },
                        new
                        {
                            Id = 25,
                            CompanyCEOName = "Andrzej Kowalczyk",
                            CompanyName = "Firma komputer"
                        },
                        new
                        {
                            Id = 26,
                            CompanyCEOName = "Marta Wiśniewska",
                            CompanyName = "Firma kawa"
                        },
                        new
                        {
                            Id = 27,
                            CompanyCEOName = "Paweł Nowak",
                            CompanyName = "Firma dom"
                        },
                        new
                        {
                            Id = 28,
                            CompanyCEOName = "Krystyna Szymańska",
                            CompanyName = "Firma telefon"
                        },
                        new
                        {
                            Id = 29,
                            CompanyCEOName = "Michał Krawczyk",
                            CompanyName = "Firma rower"
                        },
                        new
                        {
                            Id = 30,
                            CompanyCEOName = "Maria Malinowska",
                            CompanyName = "Firma telewizor"
                        },
                        new
                        {
                            Id = 31,
                            CompanyCEOName = "Wojciech Nowak",
                            CompanyName = "Firma herbata"
                        },
                        new
                        {
                            Id = 32,
                            CompanyCEOName = "Zofia Szymańska",
                            CompanyName = "Firma stół"
                        },
                        new
                        {
                            Id = 33,
                            CompanyCEOName = "Krzysztof Woźniak",
                            CompanyName = "Firma książka"
                        },
                        new
                        {
                            Id = 34,
                            CompanyCEOName = "Elżbieta Kaczmarek",
                            CompanyName = "Firma lampa"
                        },
                        new
                        {
                            Id = 35,
                            CompanyCEOName = "Andrzej Kowalczyk",
                            CompanyName = "Firma komoda"
                        },
                        new
                        {
                            Id = 36,
                            CompanyCEOName = "Marta Wiśniewska",
                            CompanyName = "Firma telewizja"
                        },
                        new
                        {
                            Id = 37,
                            CompanyCEOName = "Paweł Nowak",
                            CompanyName = "Firma drzwi"
                        },
                        new
                        {
                            Id = 38,
                            CompanyCEOName = "Krystyna Szymańska",
                            CompanyName = "Firma samochód"
                        },
                        new
                        {
                            Id = 39,
                            CompanyCEOName = "Michał Krawczyk",
                            CompanyName = "Firma dom"
                        },
                        new
                        {
                            Id = 40,
                            CompanyCEOName = "Maria Malinowska",
                            CompanyName = "Firma biurko"
                        },
                        new
                        {
                            Id = 41,
                            CompanyCEOName = "Wojciech Nowak",
                            CompanyName = "Firma komputer"
                        },
                        new
                        {
                            Id = 42,
                            CompanyCEOName = "Zofia Szymańska",
                            CompanyName = "Firma telefon"
                        },
                        new
                        {
                            Id = 43,
                            CompanyCEOName = "Krzysztof Woźniak",
                            CompanyName = "Firma rower"
                        },
                        new
                        {
                            Id = 44,
                            CompanyCEOName = "Elżbieta Kaczmarek",
                            CompanyName = "Firma telewizor"
                        },
                        new
                        {
                            Id = 45,
                            CompanyCEOName = "Andrzej Kowalczyk",
                            CompanyName = "Firma stół"
                        },
                        new
                        {
                            Id = 46,
                            CompanyCEOName = "Marta Wiśniewska",
                            CompanyName = "Firma lampa"
                        },
                        new
                        {
                            Id = 47,
                            CompanyCEOName = "Paweł Nowak",
                            CompanyName = "Firma komoda"
                        },
                        new
                        {
                            Id = 48,
                            CompanyCEOName = "Krystyna Szymańska",
                            CompanyName = "Firma herbata"
                        },
                        new
                        {
                            Id = 49,
                            CompanyCEOName = "Michał Krawczyk",
                            CompanyName = "Firma sofa"
                        },
                        new
                        {
                            Id = 50,
                            CompanyCEOName = "Maria Malinowska",
                            CompanyName = "Firma samochód"
                        });
                });

            modelBuilder.Entity("PolishDb.Entities.EmploymentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "MandateContract"
                        },
                        new
                        {
                            Id = 2,
                            Name = "ContractOfEmployment"
                        });
                });

            modelBuilder.Entity("PolishDb.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<double>("Earnings")
                        .HasColumnType("float");

                    b.Property<bool>("Father")
                        .HasColumnType("bit");

                    b.Property<string>("FatherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Husband")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Mother")
                        .HasColumnType("bit");

                    b.Property<string>("MotherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpouseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Wife")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("CompanyPerson", b =>
                {
                    b.HasOne("PolishDb.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PolishDb.Entities.EmploymentType", "EmploymentType")
                        .WithMany()
                        .HasForeignKey("EmploymentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PolishDb.Entities.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("EmploymentType");

                    b.Navigation("Person");
                });
#pragma warning restore 612, 618
        }
    }
}
