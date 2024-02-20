using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.ViewComponents.Default
{
    public class PopularDestinationsViewComponent : ViewComponent
    {
        //DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        //public IViewComponentResult Invoke()
        //{
        //    var values = destinationManager.TGetList();
        //    return View(values);
        //}
        private readonly IServiceManager _serviceManager;

        public PopularDestinationsViewComponent(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        public IViewComponentResult Invoke()
        {
            var results = _serviceManager.DestinationService.TGetList().Take(6);
            return View(results);
        }
    }
}
