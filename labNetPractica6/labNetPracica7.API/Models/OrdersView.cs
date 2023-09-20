using System;
using System.ComponentModel.DataAnnotations;

namespace labNetPracica7.API.Models
{
    public class OrdersView
    {
        public long? Id { get; set; }

        [Required]
        [StringLength(40)]
        [RegularExpression("^[a-zA-Z\\s]+$", ErrorMessage = "El nombre no acepta valores numericos ni simbolos")]
        public string Ship { get; set; }

        [Required]
        [StringLength(15)]
        [RegularExpression("^[a-zA-Z\\s]+$", ErrorMessage = "La ciudad no acepta valores numericos ni simbolos")]
        public string City { get; set; }

        [StringLength(15)]
        [RegularExpression("^[a-zA-Z\\s]+$", ErrorMessage = "La region no acepta valores numericos ni simbolos")]
        public string Region { get; set; }


        [StringLength(60)]
        public string Address { get; set; }
    }
}