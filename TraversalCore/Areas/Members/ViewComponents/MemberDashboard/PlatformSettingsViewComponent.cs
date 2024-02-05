using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Areas.Members.ViewComponents.MemberDashboard
{
    public class PlatformSettingsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
