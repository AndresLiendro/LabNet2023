using System.ComponentModel.DataAnnotations;

namespace labNetPracica7.API.Models
{
    public class OrdersView
    {
        public long Id { get; set; }

        [Required]
        [StringLength(10)]
        [RegularExpression("^[a-zA-Z\\s]+$", ErrorMessage = "El nombre de empleado no acepta valores numericos ni simbolos")]
        public string ship { get; set; }

        [Required]
        [StringLength(10)]
        [RegularExpression("^[a-zA-Z\\s]+$", ErrorMessage = "El nombre de empleado no acepta valores numericos ni simbolos")]
        public string city { get; set; }

        [Required]
        [StringLength(10)]
        [RegularExpression("^[a-zA-Z\\s]+$", ErrorMessage = "El nombre de empleado no acepta valores numericos ni simbolos")]
        public string region { get; set; }
    }
}