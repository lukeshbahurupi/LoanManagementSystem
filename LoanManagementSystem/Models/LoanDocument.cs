using System.Collections;

namespace LoanManagementSystem.Models
{
    public class LoanDocument
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public int LoanApplicationId { get; set; } 
        public LoanApplication LoanApplication { get; set; }


    }
}
