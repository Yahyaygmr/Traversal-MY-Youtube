using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Areas.Admin.ViewComponents.AdminLayout
{
    public class FooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
