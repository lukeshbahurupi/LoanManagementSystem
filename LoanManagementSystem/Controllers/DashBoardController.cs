using LoanManagementSystem.Data;
using LoanManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LoanManagementSystem.Controllers
{
    
    public class DashBoardController : Controller
    {
        private readonly ApplicationDBContext _dbContext;

        public DashBoardController(ApplicationDBContext db)
        {
            _dbContext = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ApplicationForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ApplicationForm(LoanApplication obj)
        {
            #region min max age validation
            if (ModelState.IsValid)
            {
                foreach (var el in _dbContext.LoanTypes.ToList())
                {
                    if (obj.LoanType == el.LoanDescription)
                    {
                        if (obj.Age < el.MinimumAgeRequired || obj.Age > el.MaximumAgeRequired)
                        {
                            ModelState.AddModelError("Age", "Invalid age based on loan type.");
                            return View(obj);
                        }
                        
                    }

                }

            }
            if (ModelState.IsValid)
            {
                _dbContext.LoanApplications.Add(obj);
                _dbContext.SaveChanges();
            }


                #endregion

                #region non-negative validation
                /* if (ModelState.IsValid)
                 {
                     if (obj.RequiredLoanAmount < 0)
                     {
                         ModelState.AddModelError("RequiredLoanAmount", "Loan amount must be non-negative.");
                     }

                 }

                 if (!ModelState.IsValid)
                 {
                     return View(obj);
                 }*/
                #endregion

                return View();
        }
    }
}
