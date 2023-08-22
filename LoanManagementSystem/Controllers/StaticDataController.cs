using LoanManagementSystem.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LoanManagementSystem.Controllers
{
    public class StaticDataController : Controller
    {
        private readonly ApplicationDBContext _dbContext;
        public StaticDataController(ApplicationDBContext db)
        {
            _dbContext = db;
        }
        public IActionResult Index()
        {
            
            return View(_dbContext.LoanTypes.ToList());
        }
        public IActionResult DocumentMaster()
        {
            
            return View(_dbContext.DocumentMasters.ToList());
        }
        public IActionResult LoanDocumentMapping()
        {
            var mappingData = _dbContext.DocumentMappings
            .Include(mapping => mapping.LoanType)
            .Include(mapping => mapping.DocumentMaster)
            .ToList();
            return View(mappingData);
        }
    }
}
