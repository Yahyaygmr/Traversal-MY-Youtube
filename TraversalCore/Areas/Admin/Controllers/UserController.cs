using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/User")]
    public class UserController : Controller
    {
        private readonly IServiceManager _serviceManager;

        public UserController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            var users = _serviceManager.AppUserService.TGetList();
            return View(users);
        }
        [Route("DeleteUser/{id}")]
        public IActionResult DeleteUser(int id)
        {
            var user = _serviceManager.AppUserService.TGetById(id);
            _serviceManager.AppUserService.TDelete(user);

            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("EditUser/{id}")]
        public IActionResult EditUser(int id)
        {
            var user = _serviceManager.AppUserService.TGetById(id);

            return View(user);
        }
        [HttpPost]
        [Route("EditUser/{id}")]
        public IActionResult EditUser(AppUser user)
        {
            _serviceManager.AppUserService.TUpdate(user);
            return RedirectToAction("Index");
        }
        [Route("CommentUser/{id}")]
        public IActionResult CommentUser(int id)
        {
            return View();
        }
        [Route("ReservationUser/{id}")]
        public IActionResult ReservationUser(int id)
        {
            var user = _serviceManager.AppUserService.TGetById(id);
            ViewBag.User = user.Name + " " + user.Surname.ToUpper();
            var reservations = _serviceManager.ReservationService.GetListAllReservationByUserId(id);
            return View(reservations);
        }
    }
}
