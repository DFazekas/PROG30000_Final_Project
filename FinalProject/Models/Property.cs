using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject.Models {
    public class Property {
        [Key]
        public string ID { get; set; }

        [Required(ErrorMessage = "Please provide a address.")]
        public string Address { get; set; }

        public List<Tenant> Tenants { get; set; }

        public List<Ticket> Tickets { get; set; }
    }
}