using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    [Route("Admin/ContactUs")]
    public class ContactUsController : Controller
    {
        private readonly IServiceManager _serviceManager;

        public ContactUsController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            var values = _serviceManager.ContactUsService.GetListContactUsByTrue();
            return View(values);
        }
    }
}
