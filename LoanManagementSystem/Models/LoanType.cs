using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Runtime.ConstrainedExecution;

namespace LoanManagementSystem.Models
{
    public class LoanType
    {
        public string LoanCode { get; set; }
        public string LoanDescription { get; set; }
        public double LoanInterestRatePerAnnum { get; set;}
        public double MinimumLoanAmount { get; set; }
        public int MaximumLoanAmount { get; set; }
        public int MinimumAgeRequired { get; set; }
        public int MaximumAgeRequired { get; set;}
        
    }
}
