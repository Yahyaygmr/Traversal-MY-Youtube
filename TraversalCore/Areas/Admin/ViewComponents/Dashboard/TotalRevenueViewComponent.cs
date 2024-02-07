using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Areas.Admin.ViewComponents.Dashboard
{
    public class TotalRevenueViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
