using VehicleApp.Domain.Models;

namespace VehicleApp.Client.Web.Managers
{
    public interface IEnquiryManager
    {
        Enquiry Enquire(Enquiry enquiry);
    }
}
