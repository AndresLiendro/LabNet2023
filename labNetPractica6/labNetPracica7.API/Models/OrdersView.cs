using System.ComponentModel.DataAnnotations;

namespace labNetPracica7.API.Models
{
    public class OrdersView
    {
        public long Id { get; set; }

        [Required]
        [StringLength(15)]
        [RegularExpression("^[a-zA-Z\\s]+$", ErrorMessage = "El nombre de empleado no acepta valores numericos ni simbolos")]
        public string Ship { get; set; }

        [Required]
        [StringLength(15)]
        [RegularExpression("^[a-zA-Z\\s]+$", ErrorMessage = "El nombre de empleado no acepta valores numericos ni simbolos")]
        public string City { get; set; }

        [Required]
        [StringLength(15)]
        [RegularExpression("^[a-zA-Z\\s]+$", ErrorMessage = "El nombre de empleado no acepta valores numericos ni simbolos")]
        public string Region { get; set; }
    }
}