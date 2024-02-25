using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Areas.Members.Controllers
{
    [Area("Members")]
    [Route("Members/[controller]/[Action]")]
    public class DashboardController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public DashboardController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            List<string> roleNames = (List<string>)await _userManager.GetRolesAsync(user);
            
               if( roleNames.Contains("Admin"))
                {
                    ViewBag.RoleName = "Admin";
                }
            ViewBag.UserName = user.Name + " " + user.Surname.ToUpper();
            ViewBag.UserImage = user.ImageUrl;
            return View();
        }
    }
}
