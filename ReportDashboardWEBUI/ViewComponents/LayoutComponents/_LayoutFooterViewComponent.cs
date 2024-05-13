using Microsoft.AspNetCore.Mvc;

namespace ReportDashboardWEBUI.ViewComponents.LayoutComponents
{
    public class _LayoutFooterViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
