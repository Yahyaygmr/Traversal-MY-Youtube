using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.ViewComponents.Destination
{
    public class RandomGuideDetailViewComponent : ViewComponent
    {
        private readonly IServiceManager _serviceManager;

        public RandomGuideDetailViewComponent(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        public IViewComponentResult Invoke()
        {
            var guides = _serviceManager.GuideService.TGetById(3);
            return View(guides);
        }
    }
}
