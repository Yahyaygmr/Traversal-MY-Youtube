using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Areas.Members.Controllers
{
    [Area("Members")]
    [AllowAnonymous]
    public class ReservationController : Controller
    {
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
            return View();
        }
        [HttpPost]
        public IActionResult NewReservation(Reservation reservation)
        {
            return View();
        }
    }
}
