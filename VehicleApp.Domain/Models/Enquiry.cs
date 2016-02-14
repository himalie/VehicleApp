using System;
using System.ComponentModel.DataAnnotations;

namespace VehicleApp.Domain.Models
{
    public class Enquiry
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CarId { get; set; }
        [Required]
        [MaxLength(50)]
        public string EnquirerName { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string EnquirerEmail { get; set; }
        [Required]
        public DateTime EnquiryTime { get; set; }
    }
}
