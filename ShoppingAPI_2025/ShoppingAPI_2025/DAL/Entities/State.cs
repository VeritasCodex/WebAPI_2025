using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ShoppingAPI_2025.DAL.Entities
{
    public class State: AuditBase
    {
        [Display(Name = "Estado/Departamento")]//Para identificar el nombre mas facil
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres.")]//Longitud maxima
        [Required(ErrorMessage = "El campo {0} es obligatorio")]//Campo obligatorio
        public string Name { get; set; }

        // Asi es como relaciono 2 tablas con EF Core:
        [Display(Name = "Pais")]
        [JsonIgnore]
        public Country? Country { get; set; }

        //Fk
        [Display(Name = "Id Pais")]
        
        public Guid CountryId { get; set; }

    }
}
