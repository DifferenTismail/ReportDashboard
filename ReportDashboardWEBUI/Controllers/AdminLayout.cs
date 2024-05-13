using Microsoft.AspNetCore.Mvc;

namespace ReportDashboardWEBUI.Controllers
{
    public class AdminLayout : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
