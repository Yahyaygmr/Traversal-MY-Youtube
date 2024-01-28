using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.ViewComponents.Comment
{
    public class MakeCommentViewComponent : ViewComponent
    {
        private readonly ServiceManager _serviceManager;

        public MakeCommentViewComponent(ServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
