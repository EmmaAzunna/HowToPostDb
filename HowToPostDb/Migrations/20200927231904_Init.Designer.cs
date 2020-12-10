﻿// <auto-generated />
using System;
using HowToPostDb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HowToPostDb.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20200927231904_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HowToPostDb.Model.UserDb", b =>
                {
                    b.Property<int?>("EmpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmpAddress")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("EmpContact")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("EmpEmail")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("EmpName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("EmpId");

                    b.ToTable("UserDb");
                });
#pragma warning restore 612, 618
        }
    }
}