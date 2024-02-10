using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TraversalCore.Models;

namespace TraversalCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/City")]
    public class CityController : Controller
    {
        private readonly IServiceManager _serviceManager;

        public CityController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("CityList")]
        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_serviceManager.DestinationService.TGetList());

            return Json(jsonCity);
        }
        [HttpPost]
        [Route("AddCityDestination")]
        public IActionResult AddCityDestination(Destination destination)
        {
            destination.Status = true;
            _serviceManager.DestinationService.TInsert(destination);
            var values = JsonConvert.SerializeObject(destination);
            return Json(values);
        }
        [Route("GetById/{DestinationId}")]
        public IActionResult GetById(int DestinationId)
        {
            var values = _serviceManager.DestinationService.TGetById(DestinationId);
            var jsonValues = JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }
        [Route("GetById/{id}")]
        public IActionResult DeleteCity(int id)
        {
            var values = _serviceManager.DestinationService.TGetById(id);
            _serviceManager.DestinationService.TDelete(values);
            return NoContent();
        }
        [Route("UpdateCity")]
        public IActionResult UpdateCity(Destination destination)
        {
            _serviceManager.DestinationService.TUpdate(destination);
            var v = JsonConvert.SerializeObject(destination);
            return Json(v);
        }
    }
}
