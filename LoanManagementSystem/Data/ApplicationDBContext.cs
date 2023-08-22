using LoanManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace LoanManagementSystem.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        { 

        }
        public DbSet<LoanType> LoanTypes { get; set; }
        public DbSet<LoanApplication> LoanApplications { get; set; }
        public DbSet<DocumentMaster> DocumentMasters { get; set; }
        public DbSet<CustomerLoanHistory> CustomerLoanHistories { get; set; }
        public DbSet<LoanDocumentMapping> DocumentMappings { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoanType>().HasData(
                new LoanType { LoanCode = "L01", LoanDescription = "Vehical Loan", LoanInterestRatePerAnnum = 8.5, MinimumLoanAmount = 75000.00, MaximumLoanAmount = 300000.00, MinimumAgeRequired = 18, MaximumAgeRequired = 60 },
                new LoanType { LoanCode = "L02", LoanDescription = "Personal Loan", LoanInterestRatePerAnnum = 12.00, MinimumLoanAmount = 100000.00, MaximumLoanAmount = 500000.00, MinimumAgeRequired = 18, MaximumAgeRequired = 70 },
                new LoanType { LoanCode = "L03", LoanDescription = "Gold Loan", LoanInterestRatePerAnnum = 14.00, MinimumLoanAmount = 150000.00, MaximumLoanAmount = 1000000.00, MinimumAgeRequired = 18, MaximumAgeRequired = 80 }
                );
            modelBuilder.Entity<DocumentMaster>().HasData(
                new DocumentMaster { DocumentCode = "D01", DocumentName = "PanCard Photo" },
                new DocumentMaster { DocumentCode = "D02", DocumentName = "Aadhar Card Photo" },
                new DocumentMaster { DocumentCode = "D03", DocumentName = "Electricity Bill" },
                new DocumentMaster { DocumentCode = "D04", DocumentName = "School Certificate" },
                new DocumentMaster { DocumentCode = "D05", DocumentName = "Driving Lic Photo" }
                );
            modelBuilder.Entity<LoanDocumentMapping>()
                .HasKey(mapping => mapping.Id);

            // Configure relationships
            modelBuilder.Entity<LoanDocumentMapping>()
                .HasOne(mapping => mapping.LoanType)
                .WithMany(loanType => loanType.LoanDocumentMappings)
                .HasForeignKey(mapping => mapping.LoanCode);

            modelBuilder.Entity<LoanDocumentMapping>()
                .HasOne(mapping => mapping.DocumentMaster)
                .WithMany(document => document.LoanDocumentMappings)
                .HasForeignKey(mapping => mapping.DocumentCode);

            modelBuilder.Entity<LoanDocumentMapping>().HasData(
                new LoanDocumentMapping { Id = 1, DocumentCode = "D01", LoanCode = "L01" },
                new LoanDocumentMapping { Id = 2, DocumentCode = "D02", LoanCode = "L01" },
                new LoanDocumentMapping { Id = 3, DocumentCode = "D03", LoanCode = "L01" },
                new LoanDocumentMapping { Id = 4, DocumentCode = "D04", LoanCode = "L01" },
                new LoanDocumentMapping { Id = 5, DocumentCode = "D05", LoanCode = "L01" },
                new LoanDocumentMapping { Id = 6, DocumentCode = "D01", LoanCode = "L02" },
                new LoanDocumentMapping { Id = 7, DocumentCode = "D02", LoanCode = "L02" },
                new LoanDocumentMapping { Id = 8, DocumentCode = "D03", LoanCode = "L02" },
                new LoanDocumentMapping { Id = 9, DocumentCode = "D01", LoanCode = "L03" },
                new LoanDocumentMapping { Id = 10, DocumentCode = "D02", LoanCode = "L03" }
                );
        }
    }
}
