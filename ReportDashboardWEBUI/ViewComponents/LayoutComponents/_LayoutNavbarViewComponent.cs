using Microsoft.AspNetCore.Mvc;

namespace ReportDashboardWEBUI.ViewComponents.LayoutComponents
{
    public class _LayoutNavbarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
