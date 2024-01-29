using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Controllers
{
    [AllowAnonymous]
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
        public IActionResult DestinationDetails(int id)
        {
            ViewBag.Id = id;
            var destination = _serviceManager.DestinationService.TGetById(id);
            return View(destination);
        }
    }
}
