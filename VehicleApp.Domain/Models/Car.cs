using System;
using System.ComponentModel.DataAnnotations;

namespace VehicleApp.Domain.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public int Year { get; set; }

        public CarPriceType PriceType { get; set; }
        [Required]
        public decimal Price { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string ContactName { get; set; }
        [MaxLength(10)]
        public string Phone { get; set; }
        [MaxLength(7)]
        public string ABN { get; set; }

    }
}
