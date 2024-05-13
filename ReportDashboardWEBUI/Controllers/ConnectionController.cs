using Microsoft.AspNetCore.Mvc;

namespace ReportDashboardWEBUI.Controllers
{
    public class ConnectionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
