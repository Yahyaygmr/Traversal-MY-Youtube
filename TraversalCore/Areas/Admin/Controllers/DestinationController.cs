using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Areas.Admin.Controllers
{
    [Area("Admin")]
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
        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDestination(Destination destination)
        {
            if (ModelState.IsValid)
            {
                _serviceManager.DestinationService.TInsert(destination);

                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult DeleteDestination(int id)
        {
            var dest = _serviceManager.DestinationService.TGetById(id);
            _serviceManager.DestinationService.TDelete(dest);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateDEstination(int id)
        {
            var dest = _serviceManager.DestinationService.TGetById(id);
            return View(dest);
        }
        [HttpPost]
        public IActionResult UpdateDEstination(Destination destination)
        {
            _serviceManager.DestinationService.TUpdate(destination);
            return RedirectToAction("Index");
        }
    }
}
