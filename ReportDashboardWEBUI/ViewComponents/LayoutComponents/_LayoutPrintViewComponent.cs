using Microsoft.AspNetCore.Mvc;

namespace ReportDashboardWEBUI.ViewComponents.LayoutComponents
{
    public class _LayoutPrintViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
