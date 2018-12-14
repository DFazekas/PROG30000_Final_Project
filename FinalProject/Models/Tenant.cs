using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject.Models {
    public class Tenant {
        [Key]
        public string ID { get; set; }

        [Required(ErrorMessage = "Please provide a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please provide a email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please provide a phone.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        public string Password { get; set; }

        public Property Property { get; set; }
    }
}