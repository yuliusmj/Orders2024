using System.ComponentModel.DataAnnotations;

namespace Orders.Shared.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "país")]
        [MaxLength(255, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public required string Name { get; set; }
    }
}