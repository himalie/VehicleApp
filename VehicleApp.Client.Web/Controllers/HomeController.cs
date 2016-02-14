using AutoMapper;
using VehicleApp.Client.Web.Managers;
using VehicleApp.Client.Web.ViewModels.Car;
using VehicleApp.Domain.Models;
using Serilog;
using System.Linq;
using System.Web.Mvc;

namespace VehicleApp.Client.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarManager _carManager;
        private readonly ILogger _logger;

        public HomeController(ICarManager carManager, ILogger logger)
        {
            _carManager = carManager;
            _logger = logger;
        }

        public ActionResult Index()
        {
            _logger.Information("Getting all the cars..");
            var allCars = _carManager.FindAll();
            var allCarViewModels = Mapper.Map<Car[], CarViewModel[]>(allCars.ToArray());
            return View(allCarViewModels);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}