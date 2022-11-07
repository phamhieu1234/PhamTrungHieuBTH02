﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BaiThucHanhExcel.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221107105906_Person")]
    partial class Person
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("BaiThucHanhExcel.Models.Person", b =>
                {
                    b.Property<string>("PersonID")
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PersonID");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("BaiThucHanhExcel.Models.Student", b =>
                {
                    b.Property<string>("StudentID")
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StudentID");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}