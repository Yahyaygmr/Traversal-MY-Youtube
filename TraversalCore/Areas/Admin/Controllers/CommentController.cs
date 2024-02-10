using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Comment")]
    public class CommentController : Controller
    {
        private readonly IServiceManager _serviceManager;

        public CommentController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            var comments = _serviceManager.CommentService.GetAllCommentsWithDestinations();
            return View(comments);
        }
        [Route("DeleteComment/{id}")]
        public IActionResult DeleteComment(int id)
        {
            var comment = _serviceManager.CommentService.TGetById(id);
            _serviceManager.CommentService.TDelete(comment);

            return RedirectToAction("Index", "Comment", new { area = "Admin" });
        }
    }
}
