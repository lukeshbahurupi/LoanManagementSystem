namespace LoanManagementSystem.Models
{
    public class CustomerLoanHistory
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string LoanDescription { get; set; }
        public string LoanType { get; set; }
        public double LoanRequiredAmount { get; set; }
        public double LoanSactionAction { get; set; }
        public string loanStatus { get; set; }

    }
}
