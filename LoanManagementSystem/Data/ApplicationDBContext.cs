using Microsoft.EntityFrameworkCore;

namespace LoanManagementSystem.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        { 

        }
    }
}
