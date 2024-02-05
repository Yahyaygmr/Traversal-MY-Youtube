using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
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

        public ReservationController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        public IActionResult MyCurrentReservations()
        {
            return View();
        }
        public IActionResult MyOldtReservations()
        {
            return View();
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

            return RedirectToAction("MyCurrentReservations");
        }
        private SelectList GetDestinations()
        {
            return new SelectList(_serviceManager.DestinationService.TGetList(), "DestinationId", "City");
        }
    }
}
