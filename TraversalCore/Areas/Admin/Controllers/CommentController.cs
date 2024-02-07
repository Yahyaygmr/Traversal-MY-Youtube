using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        private readonly IServiceManager _serviceManager;

        public CommentController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        public IActionResult Index()
        {
            var comments = _serviceManager.CommentService.GetAllCommentsWithDestinations();
            return View(comments);
        }
    }
}
