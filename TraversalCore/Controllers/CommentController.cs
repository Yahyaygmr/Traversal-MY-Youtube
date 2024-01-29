using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Controllers
{
    public class CommentController : Controller
    {
        private readonly IServiceManager _serviceManager;

        public CommentController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {
            comment.CommentDate = DateTime.Now;
            comment.CommentState = true;
            _serviceManager.CommentService.TInsert(comment);
            return RedirectToAction("Index","Destination");
        }

    }
}
