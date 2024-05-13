using Microsoft.AspNetCore.Mvc;

namespace ReportDashboardWEBUI.ViewComponents.LayoutComponents
{
    public class _LayoutHeaderViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
