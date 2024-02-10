using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TraversalCore.Areas.Members.Controllers
{
    [Area("Members")]
    [Route("Members/[controller]/[action]")]
    [AllowAnonymous]
    public class ReservationController : Controller
    {
        private readonly IServiceManager _serviceManager;
        private readonly UserManager<AppUser> _userManager;

        public ReservationController(IServiceManager serviceManager,UserManager<AppUser> userManager)
        {
            _serviceManager = serviceManager;
            _userManager = userManager;
        }

        public async Task<IActionResult> MyCurrentReservations()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = _serviceManager.ReservationService.GetListReservationByAccepted(user.Id);
            return View(values);
        }
        public async Task<IActionResult> MyOldtReservations()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = _serviceManager.ReservationService.GetListReservationByPrevious(user.Id);
            return View(values);
        }
        public async Task<IActionResult> MyApprovalReservations()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = _serviceManager.ReservationService.GetListReservationByWaitApproval(user.Id);
            return View(values);
        }
        [HttpGet]
        public IActionResult NewReservation()
        {
            ViewBag.Destinations = GetDestinations();
            return View();

        }
        [HttpPost]
        public IActionResult NewReservation(Reservation reservation)
        {
            reservation.AppUserId = 7;
            reservation.Status = "Onay Bekliyor";
            _serviceManager.ReservationService.TInsert(reservation);

            return RedirectToAction("MyCurrentReservations","Reservation",new {area="Members"});
        }
        private SelectList GetDestinations()
        {
            return new SelectList(_serviceManager.DestinationService.TGetList(), "DestinationId", "City");
        }
        //private async Task<AppUser> GetAppUser(string userName)
        //{
        //    return await _userManager.FindByNameAsync(userName);
        //}
    }
}
