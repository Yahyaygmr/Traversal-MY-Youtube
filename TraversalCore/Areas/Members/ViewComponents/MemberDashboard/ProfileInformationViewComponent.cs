using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Areas.Members.ViewComponents.MemberDashboard
{
    public class ProfileInformationViewComponent : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileInformationViewComponent(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            //Invoke metodu async kullanılamadığı için getawaiter() getresult() kullandım.alternatifi aşşağıda
            var user = _userManager.FindByNameAsync(User.Identity.Name).GetAwaiter().GetResult();

            ViewBag.name = user.UserName;
            ViewBag.mail = user.Email;
            ViewBag.phone = user.PhoneNumber;

            return View();
        }
        //public async Task<IViewComponentResult> InvokeAsync()
        //{
        //    var user = await _userManager.FindByNameAsync(User.Identity.Name);

        //    ViewBag.name = user.UserName;
        //    ViewBag.mail = user.Email;
        //    ViewBag.phone = user.PhoneNumber;

        //    return View();
        //}
    }
}
