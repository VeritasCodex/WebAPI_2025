using System.ComponentModel.DataAnnotations;

namespace ShoppingAPI_2025.DAL.Entities
{
    public class AuditBase
    {
        [Key]//PK
        [Required]//Significa que este campo es Obligatorio
        public virtual Guid Id { get; set; }// Esta sera el PK de todas las tablas
        public virtual DateTime? CreatedDate { get; set; }// Para guardar todo registro nuevo con su date
        public virtual DateTime? ModifiedDate { get; set; }// Para guardar todo registro que se modifico con su date

        //Usamos la notacion Elvis(?) para que el campo no sea obligatorio(Permite guardar nulos)

        [Display(Name = "Estados/Departamentos")]
        public ICollection<State>? States { get; set; }
    }
}
