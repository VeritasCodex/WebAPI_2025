using System.ComponentModel.DataAnnotations;

namespace ShoppingAPI_2025.DAL.Entities
{
    public class Country: AuditBase
    {
        [Display(Name="Pais")]//Para identificar el nombre mas facil
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres.")]//Longitud maxima
        [Required(ErrorMessage = "El campo {0} es obligatorio")]//Campo obligatorio
        public string Name { get; set; }
    }
}
