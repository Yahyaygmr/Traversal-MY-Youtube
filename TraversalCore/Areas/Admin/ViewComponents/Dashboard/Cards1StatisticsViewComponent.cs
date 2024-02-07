using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Areas.Admin.ViewComponents.Dashboard
{
    public class Cards1StatisticsViewComponent : ViewComponent
    {
        private readonly Context _context;

        public Cards1StatisticsViewComponent(Context context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.Rotalar = _context.Destinations.Count();
            ViewBag.Misafirler = _context.Users.Count();
            return View();
        }
    }
}
