using LoanManagementSystem.Data;
using LoanManagementSystem.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;

namespace LoanManagementSystem.Controllers
{
    
    public class DashBoardController : Controller
    {
        private readonly ApplicationDBContext _dbContext;

        public DashBoardController(ApplicationDBContext db)
        {
            _dbContext = db;
        }
        public IActionResult LoanDocument()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View(_dbContext.LoanApplications.ToList());
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
                
                #endregion
            }
                if (ModelState.IsValid)
                {
                    _dbContext.LoanApplications.Add(obj);
                    _dbContext.SaveChanges();
                }            

                return View();
        }

         public IActionResult CustemerResultHistory()
        {
            return View(_dbContext.LoanApplications.ToList());
        }
    }
}
