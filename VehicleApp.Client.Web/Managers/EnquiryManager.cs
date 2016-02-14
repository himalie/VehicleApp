using VehicleApp.Domain.Context;
using VehicleApp.Domain.Models;
using Newtonsoft.Json;
using Serilog;

namespace VehicleApp.Client.Web.Managers
{
    public class EnquiryManager : ManagerBase, IEnquiryManager
    {
        private readonly CarContext _carContext;

        public EnquiryManager(ILogger logger, CarContext carContext) : base(logger)
        {
            _carContext = carContext;
        }

        public Enquiry Enquire(Enquiry enquiry)
        {
            var result = _carContext.Enquiries.Add(enquiry);
            _carContext.SaveChanges();

            Logger.Information("Saved Enquiry Successfully", JsonConvert.SerializeObject(result));
            return result;
        }
    }
}   