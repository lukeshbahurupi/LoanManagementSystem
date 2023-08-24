using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.ConstrainedExecution;

namespace LoanManagementSystem.Models
{
    public class LoanType
    {
        [Key]
        public string LoanCode { get; set; }
        public string LoanDescription { get; set; }
        [Column(TypeName = "decimal(3,1)")]
        public double LoanInterestRatePerAnnum { get; set;}
        [Column(TypeName = "decimal(18,2)")]
        public double MinimumLoanAmount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public double MaximumLoanAmount { get; set; }
        public int MinimumAgeRequired { get; set; }
        public int MaximumAgeRequired { get; set;}
        public ICollection<LoanDocumentMapping> LoanDocumentMappings { get; set; }
        
    }
}
