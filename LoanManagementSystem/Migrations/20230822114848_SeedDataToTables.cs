using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LoanManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataToTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocumentMappings_DocumentMasters_DocumentMasterDocumentCode",
                table: "DocumentMappings");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentMappings_LoanTypes_LoanTypeLoanCode",
                table: "DocumentMappings");

            migrationBuilder.DropIndex(
                name: "IX_DocumentMappings_DocumentMasterDocumentCode",
                table: "DocumentMappings");

            migrationBuilder.DropIndex(
                name: "IX_DocumentMappings_LoanTypeLoanCode",
                table: "DocumentMappings");

            migrationBuilder.DropColumn(
                name: "DocumentMasterDocumentCode",
                table: "DocumentMappings");

            migrationBuilder.DropColumn(
                name: "LoanTypeLoanCode",
                table: "DocumentMappings");

            migrationBuilder.AlterColumn<string>(
                name: "LoanCode",
                table: "DocumentMappings",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DocumentCode",
                table: "DocumentMappings",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "DocumentMasters",
                columns: new[] { "DocumentCode", "DocumentName" },
                values: new object[,]
                {
                    { "D01", "PanCard Photo" },
                    { "D02", "Aadhar Card Photo" },
                    { "D03", "Electricity Bill" },
                    { "D04", "School Certificate" },
                    { "D05", "Driving Lic Photo" }
                });

            migrationBuilder.InsertData(
                table: "LoanTypes",
                columns: new[] { "LoanCode", "LoanDescription", "LoanInterestRatePerAnnum", "MaximumAgeRequired", "MaximumLoanAmount", "MinimumAgeRequired", "MinimumLoanAmount" },
                values: new object[,]
                {
                    { "L01", "Vehical Loan", 8.5m, 60, 300000m, 18, 75000m },
                    { "L02", "Personal Loan", 12m, 70, 500000m, 18, 100000m },
                    { "L03", "Gold Loan", 14m, 80, 1000000m, 18, 150000m }
                });

            migrationBuilder.InsertData(
                table: "DocumentMappings",
                columns: new[] { "Id", "DocumentCode", "LoanCode" },
                values: new object[,]
                {
                    { 1, "D01", "L01" },
                    { 2, "D02", "L01" },
                    { 3, "D03", "L01" },
                    { 4, "D04", "L01" },
                    { 5, "D05", "L01" },
                    { 6, "D01", "L02" },
                    { 7, "D02", "L02" },
                    { 8, "D03", "L02" },
                    { 9, "D01", "L03" },
                    { 10, "D02", "L03" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DocumentMappings_DocumentCode",
                table: "DocumentMappings",
                column: "DocumentCode");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentMappings_LoanCode",
                table: "DocumentMappings",
                column: "LoanCode");

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentMappings_DocumentMasters_DocumentCode",
                table: "DocumentMappings",
                column: "DocumentCode",
                principalTable: "DocumentMasters",
                principalColumn: "DocumentCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentMappings_LoanTypes_LoanCode",
                table: "DocumentMappings",
                column: "LoanCode",
                principalTable: "LoanTypes",
                principalColumn: "LoanCode",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocumentMappings_DocumentMasters_DocumentCode",
                table: "DocumentMappings");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentMappings_LoanTypes_LoanCode",
                table: "DocumentMappings");

            migrationBuilder.DropIndex(
                name: "IX_DocumentMappings_DocumentCode",
                table: "DocumentMappings");

            migrationBuilder.DropIndex(
                name: "IX_DocumentMappings_LoanCode",
                table: "DocumentMappings");

            migrationBuilder.DeleteData(
                table: "DocumentMappings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DocumentMappings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DocumentMappings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DocumentMappings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DocumentMappings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DocumentMappings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DocumentMappings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DocumentMappings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DocumentMappings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DocumentMappings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DocumentMasters",
                keyColumn: "DocumentCode",
                keyValue: "D01");

            migrationBuilder.DeleteData(
                table: "DocumentMasters",
                keyColumn: "DocumentCode",
                keyValue: "D02");

            migrationBuilder.DeleteData(
                table: "DocumentMasters",
                keyColumn: "DocumentCode",
                keyValue: "D03");

            migrationBuilder.DeleteData(
                table: "DocumentMasters",
                keyColumn: "DocumentCode",
                keyValue: "D04");

            migrationBuilder.DeleteData(
                table: "DocumentMasters",
                keyColumn: "DocumentCode",
                keyValue: "D05");

            migrationBuilder.DeleteData(
                table: "LoanTypes",
                keyColumn: "LoanCode",
                keyValue: "L01");

            migrationBuilder.DeleteData(
                table: "LoanTypes",
                keyColumn: "LoanCode",
                keyValue: "L02");

            migrationBuilder.DeleteData(
                table: "LoanTypes",
                keyColumn: "LoanCode",
                keyValue: "L03");

            migrationBuilder.AlterColumn<string>(
                name: "LoanCode",
                table: "DocumentMappings",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "DocumentCode",
                table: "DocumentMappings",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "DocumentMasterDocumentCode",
                table: "DocumentMappings",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LoanTypeLoanCode",
                table: "DocumentMappings",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentMappings_DocumentMasterDocumentCode",
                table: "DocumentMappings",
                column: "DocumentMasterDocumentCode");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentMappings_LoanTypeLoanCode",
                table: "DocumentMappings",
                column: "LoanTypeLoanCode");

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentMappings_DocumentMasters_DocumentMasterDocumentCode",
                table: "DocumentMappings",
                column: "DocumentMasterDocumentCode",
                principalTable: "DocumentMasters",
                principalColumn: "DocumentCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentMappings_LoanTypes_LoanTypeLoanCode",
                table: "DocumentMappings",
                column: "LoanTypeLoanCode",
                principalTable: "LoanTypes",
                principalColumn: "LoanCode",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
