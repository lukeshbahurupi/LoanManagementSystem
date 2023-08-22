using System.ComponentModel.DataAnnotations;

namespace LoanManagementSystem.Models
{
    public class DocumentMaster
    {
        [Key]
        public string DocumentCode { get; set; }
        public string DocumentName { get; set; }
        public ICollection<LoanDocumentMapping> LoanDocumentMappings { get; set; }
    }
}
