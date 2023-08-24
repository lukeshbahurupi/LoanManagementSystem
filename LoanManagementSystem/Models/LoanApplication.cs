using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace LoanManagementSystem.Models
{
    public class LoanApplication
    {
        [Key]
        public int ApplicationNumber { get; set; }
        public DateTime ApplicationDate { get; set; }
        [MaxLength(30)]
        public string CustemerName { get; set; }
        public string Gender { get; set; }
        [Required(ErrorMessage ="Birth Date is required")]
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        [Required(ErrorMessage = "Email Id is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [CustomEmailValidation(ErrorMessage = "Email must contain '@' and '.' character")]
        public string EmailId { get; set; }
        [Required(ErrorMessage = "Phone Number is required")]
        [CustomPhoneNumberValidation(ErrorMessage = "Invalid phone number format")]
        public string PhoneNumber { get; set; }
        public string  LoanType{ get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [Required(ErrorMessage ="Please Enter Required Loan Ammount")]
        public double RequiredLoanAmount { get; set; }
        [Column(TypeName = "decimal(3,1)")]
        public double RateOfInterest { get; set; }
        public int LoanTenureInMonth { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public double LoanEMI { get; set;}
    }
}
public class CustomPhoneNumberValidationAttribute : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        string phoneNumber = value as string;

        if (phoneNumber == null)
            return false;

        // Use regular expression to match the format: optional country code followed by numbers
        return Regex.IsMatch(phoneNumber, @"^(?:\+91|\+61|\+1)?[0-9]+$");
    }
}

public class CustomEmailValidationAttribute : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        string email = value as string;

        if (email == null)
            return false;
        if(email.Contains("@") && email.Contains("."))
        {
            return true;
        }
        return  false;
    }
}