using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VehicleApp.Client.Web.ViewModels.Comment
{
    public class CommentViewModel
    {        
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