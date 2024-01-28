using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.ViewComponents.Default
{
    public class TestimonialViewComponent : ViewComponent
    {
        private readonly IServiceManager _serviceManager;

        public TestimonialViewComponent(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        public IViewComponentResult Invoke()
        {
            var values = _serviceManager.TestimonialService.TGetList();
            return View(values);
        }
    }
}
