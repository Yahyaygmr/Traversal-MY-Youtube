using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Guide")]
    public class GuideController : Controller
    {
        private readonly IServiceManager _serviceManager;

        public GuideController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            var guides = _serviceManager.GuideService.TGetList();
            return View(guides);
        }
        [HttpGet]
        [Route("CreateGuide")]
        public IActionResult CreateGuide()
        {
            return View();
        }
        [HttpPost]
        [Route("CreateGuide")]
        public IActionResult CreateGuide(Guide guide)
        {
            GuideValidator validationRules = new GuideValidator();
            ValidationResult validationResult = validationRules.Validate(guide);
            if (validationResult.IsValid)
            {
                _serviceManager.GuideService.TInsert(guide);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

                }
                return View();
            }

        }
        [Route("EditGuide/{id}")]
        [HttpGet]
        public IActionResult EditGuide(int id)
        {
            var guide = _serviceManager.GuideService.TGetById(id);
            return View(guide);
        }
        [HttpPost]
        [Route("EditGuide/{id}")]
        public IActionResult EditGuide(Guide guide)
        {
            _serviceManager.GuideService.TUpdate(guide);
            return RedirectToAction("Index");
        }
        [Route("DeleteGuide/{id}")]
        public IActionResult DeleteGuide(int id)
        {
            var guide = _serviceManager.GuideService.TGetById(id);
            _serviceManager.GuideService.TDelete(guide);
            return RedirectToAction("Index");
        }
        [Route("ChangeToTrue/{id}")]
        public IActionResult ChangeToTrue(int id)
        {
            var guide = _serviceManager.GuideService.TGetById(id);
            guide.Status = true;
            _serviceManager.GuideService.TUpdate(guide);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }
        [Route("ChangeToFalse/{id}")]
        public IActionResult ChangeToFalse(int id)
        {
            var guide = _serviceManager.GuideService.TGetById(id);
            guide.Status = false;
            _serviceManager.GuideService.TUpdate(guide);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }
    }

}
