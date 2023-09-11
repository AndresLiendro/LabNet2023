using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace labNetPractica6.MVC.Models
{
    public class CustomersView
    {
        public string Id { get; set; }

        [Required]
        [StringLength(10)]
        [RegularExpression("^[a-zA-Z\\s]+$", ErrorMessage = "El nombre de empleado no acepta valores numericos ni simbolos")]
        public string companyName { get; set; }

        [Required]
        [StringLength(10)]
        [RegularExpression("^[a-zA-Z\\s]+$", ErrorMessage = "El nombre de empleado no acepta valores numericos ni simbolos")]
        public string contactName  { get; set; }

        [Required]
        [StringLength(10)]
        [RegularExpression("^[a-zA-Z\\s]+$", ErrorMessage = "El nombre de empleado no acepta valores numericos ni simbolos")]
        public string contactTitle { get; set; }
    }
}