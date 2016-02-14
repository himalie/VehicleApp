using AutoMapper;
using VehicleApp.Client.Web.Managers;
using VehicleApp.Client.Web.ViewModels.Car;
using Serilog;
using System.Web.Mvc;

namespace VehicleApp.Client.Web.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarManager _carManager;
        private readonly ILogger _logger;

        public CarController(ICarManager carManager, ILogger logger)
        {
            _carManager = carManager;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Details(int? id = null)
        {
            if(!id.HasValue)
            {
                _logger.Warning("Details was called with no Id, redirecting to home");
                return Redirect("/Home/Index");
            }

            var car = _carManager.FindById(id.Value);
            if(car == null)
            {
                _logger.Error("Car by Id {0} does not exist, redirecting to home", id.Value);
                return Redirect("/Home/Index");
            }

            var carViewModel = Mapper.Map<CarViewModel>(car);
            return View(carViewModel);
        }
    }
}