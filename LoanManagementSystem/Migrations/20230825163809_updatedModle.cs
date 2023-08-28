using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class updatedModle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_loanDocuments_LoanApplications_LoanApplicationId",
                table: "loanDocuments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoanApplications",
                table: "LoanApplications");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationNumber",
                table: "LoanApplications",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "LoanApplications",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<byte[]>(
                name: "Attachment",
                table: "LoanApplications",
                type: "varbinary(MAX)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "LoanApplications",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "LoanApplications",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoanApplications",
                table: "LoanApplications",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_loanDocuments_LoanApplications_LoanApplicationId",
                table: "loanDocuments",
                column: "LoanApplicationId",
                principalTable: "LoanApplications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_loanDocuments_LoanApplications_LoanApplicationId",
                table: "loanDocuments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoanApplications",
                table: "LoanApplications");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "LoanApplications");

            migrationBuilder.DropColumn(
                name: "Attachment",
                table: "LoanApplications");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "LoanApplications");

            migrationBuilder.DropColumn(
                name: "FileName",
                table: "LoanApplications");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationNumber",
                table: "LoanApplications",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoanApplications",
                table: "LoanApplications",
                column: "ApplicationNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_loanDocuments_LoanApplications_LoanApplicationId",
                table: "loanDocuments",
                column: "LoanApplicationId",
                principalTable: "LoanApplications",
                principalColumn: "ApplicationNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
