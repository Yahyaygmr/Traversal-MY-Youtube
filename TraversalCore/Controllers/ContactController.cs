using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IServiceManager _serviceManager;

        public ContactController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ContactUs contactUs)
        {
            contactUs.Status = true;
            contactUs.MessageDate = DateTime.Now;
            _serviceManager.ContactUsService.TInsert(contactUs);
            return RedirectToAction("Index","Default");
        }
    }
}
