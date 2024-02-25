using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[Action]")]
    public class NewsletterController : Controller
    {
        private readonly IServiceManager _serviceManager;

        public NewsletterController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        public IActionResult Index()
        {
            var newsletters = _serviceManager.NewsletterService.TGetList();
            return View(newsletters);
        }
    }
}
