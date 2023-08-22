namespace LoanManagementSystem.Models
{
    public class LoanDocumentMapping
    {
        public int Id { get; set; }
        public string LoanCode { get; set; }
        public string DocumentCode { get; set; }

        public LoanType LoanType { get; set; }
        public DocumentMaster DocumentMaster { get; set; }
    }
}
