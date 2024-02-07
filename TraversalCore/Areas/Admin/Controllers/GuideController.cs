using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GuideController : Controller
    {
        private readonly IServiceManager _serviceManager;

        public GuideController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        public IActionResult Index()
        {
            var guides = _serviceManager.GuideService.TGetList();
            return View(guides);
        }
        [HttpGet]
        public IActionResult CreateGuide()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateGuide(Guide guide)
        {
            _serviceManager.GuideService.TInsert(guide);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditGuide(int id)
        {
            var guide = _serviceManager.GuideService.TGetById(id);
            return View(guide);
        }
        [HttpPost]
        public IActionResult EditGuide(Guide guide)
        {
            _serviceManager.GuideService.TUpdate(guide);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteGuide(int id)
        {
            var guide = _serviceManager.GuideService.TGetById(id);
            _serviceManager.GuideService.TDelete(guide);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeToTrue(int id)
        {
            var guide = _serviceManager.GuideService.TGetById(id);
            guide.Status = true;
            _serviceManager.GuideService.TUpdate(guide);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeToFalse(int id)
        {
            var guide = _serviceManager.GuideService.TGetById(id);
            guide.Status = false;
            _serviceManager.GuideService.TUpdate(guide);
            return RedirectToAction("Index");
        }
    }

}
