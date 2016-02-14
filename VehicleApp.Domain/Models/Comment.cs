using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp.Domain.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CarId { get; set; }
        [Required]
        [MaxLength(2000)]
        public string CommentDescription { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string CommentEmail { get; set; }        
    }
}
