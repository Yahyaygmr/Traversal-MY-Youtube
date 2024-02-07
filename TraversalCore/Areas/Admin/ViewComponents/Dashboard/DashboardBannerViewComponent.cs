using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Areas.Admin.ViewComponents.Dashboard
{
    public class DashboardBannerViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
