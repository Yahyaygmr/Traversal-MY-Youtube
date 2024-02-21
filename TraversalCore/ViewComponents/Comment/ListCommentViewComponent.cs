using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.ViewComponents.Comment
{
    public class ListCommentViewComponent : ViewComponent
    {
        private readonly IServiceManager _serviceManager;

        public ListCommentViewComponent(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        public IViewComponentResult Invoke(int id)
        {
            var values = _serviceManager.CommentService.GetAllCommentsWithDestinationsAndUserByDestinationId(id);
            ViewBag.commentCount = values.Count;
            return View(values);
        }
    }
}
