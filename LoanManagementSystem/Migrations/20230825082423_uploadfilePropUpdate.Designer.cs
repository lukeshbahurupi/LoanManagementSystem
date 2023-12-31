﻿// <auto-generated />
using System;
using LoanManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LoanManagementSystem.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20230825082423_uploadfilePropUpdate")]
    partial class uploadfilePropUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LoanManagementSystem.Models.CustomerLoanHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoanDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("LoanRequiredAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("LoanSactionAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("LoanType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("loanStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CustomerLoanHistories");
                });

            modelBuilder.Entity("LoanManagementSystem.Models.DocumentMaster", b =>
                {
                    b.Property<string>("DocumentCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DocumentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DocumentCode");

                    b.ToTable("DocumentMasters");

                    b.HasData(
                        new
                        {
                            DocumentCode = "D01",
                            DocumentName = "PanCard Photo"
                        },
                        new
                        {
                            DocumentCode = "D02",
                            DocumentName = "Aadhar Card Photo"
                        },
                        new
                        {
                            DocumentCode = "D03",
                            DocumentName = "Electricity Bill"
                        },
                        new
                        {
                            DocumentCode = "D04",
                            DocumentName = "School Certificate"
                        },
                        new
                        {
                            DocumentCode = "D05",
                            DocumentName = "Driving Lic Photo"
                        });
                });

            modelBuilder.Entity("LoanManagementSystem.Models.LoanApplication", b =>
                {
                    b.Property<int>("ApplicationNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApplicationNumber"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("ApplicationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustemerName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("LoanEMI")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("LoanTenureInMonth")
                        .HasColumnType("int");

                    b.Property<string>("LoanType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("RateOfInterest")
                        .HasColumnType("decimal(3,1)");

                    b.Property<decimal>("RequiredLoanAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ApplicationNumber");

                    b.ToTable("LoanApplications");
                });

            modelBuilder.Entity("LoanManagementSystem.Models.LoanDocumentMapping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DocumentCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoanCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("DocumentCode");

                    b.HasIndex("LoanCode");

                    b.ToTable("DocumentMappings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DocumentCode = "D01",
                            LoanCode = "L01"
                        },
                        new
                        {
                            Id = 2,
                            DocumentCode = "D02",
                            LoanCode = "L01"
                        },
                        new
                        {
                            Id = 3,
                            DocumentCode = "D03",
                            LoanCode = "L01"
                        },
                        new
                        {
                            Id = 4,
                            DocumentCode = "D04",
                            LoanCode = "L01"
                        },
                        new
                        {
                            Id = 5,
                            DocumentCode = "D05",
                            LoanCode = "L01"
                        },
                        new
                        {
                            Id = 6,
                            DocumentCode = "D01",
                            LoanCode = "L02"
                        },
                        new
                        {
                            Id = 7,
                            DocumentCode = "D02",
                            LoanCode = "L02"
                        },
                        new
                        {
                            Id = 8,
                            DocumentCode = "D03",
                            LoanCode = "L02"
                        },
                        new
                        {
                            Id = 9,
                            DocumentCode = "D01",
                            LoanCode = "L03"
                        },
                        new
                        {
                            Id = 10,
                            DocumentCode = "D02",
                            LoanCode = "L03"
                        });
                });

            modelBuilder.Entity("LoanManagementSystem.Models.LoanType", b =>
                {
                    b.Property<string>("LoanCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoanDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("LoanInterestRatePerAnnum")
                        .HasColumnType("decimal(3,1)");

                    b.Property<int>("MaximumAgeRequired")
                        .HasColumnType("int");

                    b.Property<decimal>("MaximumLoanAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MinimumAgeRequired")
                        .HasColumnType("int");

                    b.Property<decimal>("MinimumLoanAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("LoanCode");

                    b.ToTable("LoanTypes");

                    b.HasData(
                        new
                        {
                            LoanCode = "L01",
                            LoanDescription = "Vehical Loan",
                            LoanInterestRatePerAnnum = 8.5m,
                            MaximumAgeRequired = 60,
                            MaximumLoanAmount = 300000m,
                            MinimumAgeRequired = 18,
                            MinimumLoanAmount = 75000m
                        },
                        new
                        {
                            LoanCode = "L02",
                            LoanDescription = "Personal Loan",
                            LoanInterestRatePerAnnum = 12m,
                            MaximumAgeRequired = 70,
                            MaximumLoanAmount = 500000m,
                            MinimumAgeRequired = 18,
                            MinimumLoanAmount = 100000m
                        },
                        new
                        {
                            LoanCode = "L03",
                            LoanDescription = "Gold Loan",
                            LoanInterestRatePerAnnum = 14m,
                            MaximumAgeRequired = 80,
                            MaximumLoanAmount = 1000000m,
                            MinimumAgeRequired = 18,
                            MinimumLoanAmount = 150000m
                        });
                });

            modelBuilder.Entity("LoanManagementSystem.Models.LoanDocumentMapping", b =>
                {
                    b.HasOne("LoanManagementSystem.Models.DocumentMaster", "DocumentMaster")
                        .WithMany("LoanDocumentMappings")
                        .HasForeignKey("DocumentCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LoanManagementSystem.Models.LoanType", "LoanType")
                        .WithMany("LoanDocumentMappings")
                        .HasForeignKey("LoanCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DocumentMaster");

                    b.Navigation("LoanType");
                });

            modelBuilder.Entity("LoanManagementSystem.Models.DocumentMaster", b =>
                {
                    b.Navigation("LoanDocumentMappings");
                });

            modelBuilder.Entity("LoanManagementSystem.Models.LoanType", b =>
                {
                    b.Navigation("LoanDocumentMappings");
                });
#pragma warning restore 612, 618
        }
    }
}
