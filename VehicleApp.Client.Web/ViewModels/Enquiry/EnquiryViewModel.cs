using System.ComponentModel.DataAnnotations;

namespace VehicleApp.Client.Web.ViewModels.Enquiry
{
    public class EnquiryViewModel
    {
        [Required]
        public int CarId { get; set; }
        [Required]
        [StringLength(50)]
        public string EnquirerName { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string EnquirerEmail { get; set; }
    }
}