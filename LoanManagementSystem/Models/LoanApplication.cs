using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanManagementSystem.Models
{
    public class LoanApplication
    {
        [Key]
        public int ApplicationNumber { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string CustemerName { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public string EmailId { get;}
        public string PhoneNumber { get; set; }
        public string  LoanType{ get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public double RequiredLoanAmount { get; set; }
        [Column(TypeName = "decimal(3,1)")]
        public double RateOfInterest { get; set; }
        public int LoanTenureInMonth { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public double LoanEMI { get; set;}
    }
}
