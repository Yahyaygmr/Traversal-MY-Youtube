using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TraversalCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Destination")]

    public class DestinationController : Controller
    {
        private readonly IServiceManager _serviceManager;

        public DestinationController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            var values = _serviceManager.DestinationService.TGetList();
            return View(values);
        }
        [HttpGet]
        [Route("AddDestination")]
        public IActionResult AddDestination()
        {
            ViewBag.guides = GetGuides();
            return View();
        }
        [HttpPost]
        [Route("AddDestination")]
        public IActionResult AddDestination(Destination destination)
        {
            destination.Status = true;
            destination.CreatedDate = DateTime.Now;
            if (ModelState.IsValid)
            {
                _serviceManager.DestinationService.TInsert(destination);

                return RedirectToAction("Index");
            }
            return View();
        }
        [Route("DeleteDestination/{id}")]
        public IActionResult DeleteDestination(int id)
        {
            var dest = _serviceManager.DestinationService.TGetById(id);

            _serviceManager.DestinationService.TDelete(dest);

            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("UpdateDestination/{id}")]
        public IActionResult UpdateDestination(int id)
        {
            ViewBag.guides = GetGuides();
            var dest = _serviceManager.DestinationService.TGetById(id);
            return View(dest);
        }
        [HttpPost]
        [Route("UpdateDestination/{id}")]

        public IActionResult UpdateDestination(Destination destination)
        {
            destination.CreatedDate = DateTime.Now;
            _serviceManager.DestinationService.TUpdate(destination);
            return RedirectToAction("Index");
        }
        private List<SelectListItem> GetGuides()
        {
            return (from x in _serviceManager.GuideService.TGetList()
                    select new SelectListItem
                    {
                        Text = x.Name,
                        Value = x.GuideId.ToString()
                    }).ToList();
        }
    }
}
