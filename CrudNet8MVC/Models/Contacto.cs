using System.ComponentModel.DataAnnotations;

namespace CrudNet8MVC.Models
{
    public class Contacto
    {
        [Key] //Llave primaria
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")] //Campo obligatorio
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El telefono es obligatorio")] //Campo obligatorio
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El celular es obligatorio")] //Campo obligatorio
        public string Celular { get; set; }
        [Required(ErrorMessage = "El email es obligatorio")] //Campo obligatorio
        public string Email { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
