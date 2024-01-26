using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
