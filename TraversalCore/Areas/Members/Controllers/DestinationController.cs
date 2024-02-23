using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Areas.Members.Controllers
{
    [Area("Members")]
    [Route("Members/[controller]/[Action]")]
    public class DestinationController : Controller
    {
        private readonly IServiceManager _serviceManager;

        public DestinationController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        public IActionResult Index()
        {
            var values = _serviceManager.DestinationService.TGetList();
            return View(values);
        }
    }
}
