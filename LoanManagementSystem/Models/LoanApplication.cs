namespace LoanManagementSystem.Models
{
    public class LoanApplication
    {
        public int ApplicationNumber { get; set; }
        public string ApplicationDate { get; set; }
        public string CustemerName { get; set; }
        public string Gender { get; set; }
        public string BirthDate { get; set; }
        public int Age { get; set; }
        public string EmailId { get;}
        public string PhoneNumber { get; set; }
        public LoanType  LoanType{ get; set; }
        public int LoanTenureInMonth { get; set; }
        public double LoanEMI { get; set;}
    }
}
