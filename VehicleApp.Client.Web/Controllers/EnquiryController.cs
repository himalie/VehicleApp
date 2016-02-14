using AutoMapper;
using VehicleApp.Client.Web.Managers;
using VehicleApp.Client.Web.ViewModels.Enquiry;
using VehicleApp.Domain.Models;
using Newtonsoft.Json;
using Serilog;
using System.Web.Mvc;

namespace VehicleApp.Client.Web.Controllers
{
    public class EnquiryController : Controller
    {
        private readonly IEnquiryManager _enquiryManager;
        private readonly ICarManager _carManager;
        private readonly ILogger _logger;

        public EnquiryController(
            IEnquiryManager enquiryManager, 
            ICarManager carManager, 
            ILogger logger)
        {
            _enquiryManager = enquiryManager;
            _carManager = carManager;
            _logger = logger;
        }

        [HttpPost]
        public ActionResult Enquire(EnquiryViewModel enquiryInfo)
        {
            _logger.Information("Starting to enquire with {0}", JsonConvert.SerializeObject(enquiryInfo));
            if(ModelState.IsValid && _carManager.FindById(enquiryInfo.CarId) != null)
            {
                var enquiry = Mapper.Map<Enquiry>(enquiryInfo);
                _enquiryManager.Enquire(enquiry);

                _logger.Information("Enquiring successful: enquiry {0}", JsonConvert.SerializeObject(enquiry));
                return View("Success"); 
            }
            else
            {
                _logger.Error("Enquiring failed with invalid enquiry input {0}", JsonConvert.SerializeObject(enquiryInfo));
                return View("Failed");
            }
        }
    }
}