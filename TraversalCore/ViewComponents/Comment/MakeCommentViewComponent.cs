using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.ViewComponents.Comment
{
    public class MakeCommentViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
