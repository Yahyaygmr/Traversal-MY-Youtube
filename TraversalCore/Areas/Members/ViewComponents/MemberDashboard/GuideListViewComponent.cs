using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Areas.Members.ViewComponents.MemberDashboard
{
    public class GuideListViewComponent : ViewComponent
    {
        private readonly IServiceManager _serviceManager;

        public GuideListViewComponent(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        public IViewComponentResult Invoke()
        {
            var values = _serviceManager.GuideService.TGetList().Take(5).ToList();

            return View(values);
        }
    }
}
