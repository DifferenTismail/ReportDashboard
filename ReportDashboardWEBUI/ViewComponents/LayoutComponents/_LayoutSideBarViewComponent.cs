using Microsoft.AspNetCore.Mvc;

namespace ReportDashboardWEBUI.ViewComponents.LayoutComponents
{
    public class _LayoutSideBarViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
