using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Areas.Admin.ViewComponents.Dashboard
{
    public class DashboardGuideListViewComponent : ViewComponent
    {
        private readonly IServiceManager _serviceManager;
        public DashboardGuideListViewComponent(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        public IViewComponentResult Invoke()
        {
            var values = _serviceManager.GuideService.TGetList().Take(6).ToList();

            return View(values);
        }
    }
}
