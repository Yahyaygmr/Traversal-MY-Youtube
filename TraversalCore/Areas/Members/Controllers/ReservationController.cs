using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TraversalCore.Areas.Members.Controllers
{
    [Area("Members")]
    [Route("Members/Reservation")]
    public class ReservationController : Controller
    {
        private readonly IServiceManager _serviceManager;
        private readonly UserManager<AppUser> _userManager;

        public ReservationController(IServiceManager serviceManager,UserManager<AppUser> userManager)
        {
            _serviceManager = serviceManager;
            _userManager = userManager;
        }
        [Route("MyCurrentReservations")]
        public async Task<IActionResult> MyCurrentReservations()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = _serviceManager.ReservationService.GetListReservationByAccepted(user.Id);
            return View(values);
        }
        [Route("MyOldtReservations")]
        public async Task<IActionResult> MyOldtReservations()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = _serviceManager.ReservationService.GetListReservationByPrevious(user.Id);
            return View(values);
        }
        [Route("MyApprovalReservations")]
        public async Task<IActionResult> MyApprovalReservations()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = _serviceManager.ReservationService.GetListReservationByWaitApproval(user.Id);
            return View(values);
        }
        [HttpGet]
        [Route("NewReservation")]
        public IActionResult NewReservation()
        {
            ViewBag.Destinations = GetDestinations();
            return View();

        }
        [HttpPost]
        [Route("NewReservation")]
        public async Task<IActionResult> NewReservation(Reservation reservation)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            reservation.AppUserId = user.Id;
            reservation.Status = "Onay Bekliyor";
            _serviceManager.ReservationService.TInsert(reservation);

            return RedirectToAction("MyApprovalReservations", "Reservation");
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
