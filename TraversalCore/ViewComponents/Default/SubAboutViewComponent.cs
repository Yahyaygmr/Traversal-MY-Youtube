using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.ViewComponents.Default
{
    public class SubAboutViewComponent : ViewComponent
    {
        private readonly IServiceManager _serviceManager;

        public SubAboutViewComponent(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        public IViewComponentResult Invoke()
        {
            var values = _serviceManager.SubAboutService.TGetList();
            return View(values);
        }
    }
}
