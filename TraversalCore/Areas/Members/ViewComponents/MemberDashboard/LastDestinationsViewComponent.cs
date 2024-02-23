using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Areas.Members.ViewComponents.MemberDashboard
{
    public class LastDestinationsViewComponent : ViewComponent
    {
        private readonly IServiceManager _serviceManager;

        public LastDestinationsViewComponent(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        public IViewComponentResult Invoke()
        {
            var destinations = _serviceManager.DestinationService.TGetLastFourDestinations();
            return View(destinations);
        }
    }
}
