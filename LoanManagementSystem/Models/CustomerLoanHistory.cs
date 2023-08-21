using System.ComponentModel.DataAnnotations.Schema;

namespace LoanManagementSystem.Models
{
    public class CustomerLoanHistory
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string LoanDescription { get; set; }
        public string LoanType { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public double LoanRequiredAmount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public double LoanSactionAmount { get; set; }
        public string loanStatus { get; set; }

    }
}
