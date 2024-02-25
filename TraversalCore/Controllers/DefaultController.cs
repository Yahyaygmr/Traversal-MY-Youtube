using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        private readonly IServiceManager _serviceManager;

        public DefaultController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        //[HttpGet]
        //public PartialViewResult _NewsletterPartial()
        //{
        //    return PartialView();
        //}
        //[HttpPost]
        //public IActionResult _NewsletterPartial(Newsletter newsletter)
        //{
        //   _serviceManager.NewsletterService.TInsert(newsletter);
        //   return RedirectToAction("Index");
        //}
    }
}
