﻿// <auto-generated />
using EFCore_DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCore_DataAccess.Migrations
{
    [DbContext(typeof(EFData))]
    partial class EFDataModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCore_ModelAccess.Models.Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PhoneId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CompanyFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneModel")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PhoneName");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 5)
                        .HasColumnType("decimal(10,5)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Phone");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyFullName = "Samsung",
                            PhoneModel = "Samsung S24",
                            Price = 3500m
                        },
                        new
                        {
                            Id = 2,
                            CompanyFullName = "MI",
                            PhoneModel = "MIPhone2345",
                            Price = 4500m
                        },
                        new
                        {
                            Id = 3,
                            CompanyFullName = "Apple",
                            PhoneModel = "iPhone 14",
                            Price = 1000m
                        },
                        new
                        {
                            Id = 4,
                            CompanyFullName = "Nokia",
                            PhoneModel = "Nokia 3310",
                            Price = 500m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
