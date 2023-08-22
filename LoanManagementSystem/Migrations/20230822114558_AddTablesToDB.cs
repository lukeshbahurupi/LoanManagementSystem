using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddTablesToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerLoanHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoanDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoanType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoanRequiredAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoanSactionAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    loanStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerLoanHistories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentMasters",
                columns: table => new
                {
                    DocumentCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DocumentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentMasters", x => x.DocumentCode);
                });

            migrationBuilder.CreateTable(
                name: "LoanApplications",
                columns: table => new
                {
                    ApplicationNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustemerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoanType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequiredLoanAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RateOfInterest = table.Column<decimal>(type: "decimal(3,1)", nullable: false),
                    LoanTenureInMonth = table.Column<int>(type: "int", nullable: false),
                    LoanEMI = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanApplications", x => x.ApplicationNumber);
                });

            migrationBuilder.CreateTable(
                name: "LoanTypes",
                columns: table => new
                {
                    LoanCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoanDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoanInterestRatePerAnnum = table.Column<decimal>(type: "decimal(3,1)", nullable: false),
                    MinimumLoanAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaximumLoanAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MinimumAgeRequired = table.Column<int>(type: "int", nullable: false),
                    MaximumAgeRequired = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanTypes", x => x.LoanCode);
                });

            migrationBuilder.CreateTable(
                name: "DocumentMappings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoanTypeLoanCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DocumentMasterDocumentCode = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentMappings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentMappings_DocumentMasters_DocumentMasterDocumentCode",
                        column: x => x.DocumentMasterDocumentCode,
                        principalTable: "DocumentMasters",
                        principalColumn: "DocumentCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocumentMappings_LoanTypes_LoanTypeLoanCode",
                        column: x => x.LoanTypeLoanCode,
                        principalTable: "LoanTypes",
                        principalColumn: "LoanCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DocumentMappings_DocumentMasterDocumentCode",
                table: "DocumentMappings",
                column: "DocumentMasterDocumentCode");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentMappings_LoanTypeLoanCode",
                table: "DocumentMappings",
                column: "LoanTypeLoanCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerLoanHistories");

            migrationBuilder.DropTable(
                name: "DocumentMappings");

            migrationBuilder.DropTable(
                name: "LoanApplications");

            migrationBuilder.DropTable(
                name: "DocumentMasters");

            migrationBuilder.DropTable(
                name: "LoanTypes");
        }
    }
}
