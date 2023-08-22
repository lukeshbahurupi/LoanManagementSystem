using Microsoft.AspNetCore.Mvc;

namespace LoanManagementSystem.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ApplicationForm()
        {
            return View();
        }
    }
}
