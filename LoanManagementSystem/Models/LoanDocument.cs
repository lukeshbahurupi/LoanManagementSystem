namespace LoanManagementSystem.Models
{
    public class LoanDocument
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public int LoanApplicationId { get; set; } // Foreign key to LoanApplication

        // Navigation property to the associated LoanApplication
        public LoanApplication LoanApplication { get; set; }

    }
}
