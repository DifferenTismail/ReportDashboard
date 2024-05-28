using Microsoft.AspNetCore.Mvc;

namespace ReportDashboardWEBUI.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateReport()
        {
            return View();
        }
    }
}
