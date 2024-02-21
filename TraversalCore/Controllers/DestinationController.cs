using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        private readonly IServiceManager _serviceManager;
        private readonly UserManager<AppUser> _userManager;

        public DestinationController(IServiceManager serviceManager, UserManager<AppUser> userManager)
        {
            _serviceManager = serviceManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = _serviceManager.DestinationService.TGetList();
            return View(values);
        }
        public async Task<IActionResult> DestinationDetails(int id)
        {
            var userName = User.Identity.Name;
            if (userName != null)
            {
                var user = await _userManager.FindByNameAsync(userName);
                if (user != null)
                {
                    ViewBag.UserId = user.Id;
                }
            }
           
            ViewBag.Id = id;
            var destination = _serviceManager.DestinationService.TGetDestinationWithGuideById(id);
            return View(destination);
        }
    }
}
