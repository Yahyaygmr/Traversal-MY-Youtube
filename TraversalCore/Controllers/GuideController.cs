using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Controllers
{
    [AllowAnonymous]
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
    }
}
