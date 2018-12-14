using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject.Models {
    public class Ticket {
        [Key]
        public string ID { get; set; }
    
        [Required(ErrorMessage = "Please provide a name.")]
        public string Issuer { get; set; }

        [Required(ErrorMessage = "Please provide a email.")]
        public string IssueDate { get; set; }

        [Required(ErrorMessage = "Please provide a phone.")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Please enter a title.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        public string Description { get; set; }

        public string OpenTime { get; set; }

        public string CloseTime { get; set; }
    }
}