using System.ComponentModel.DataAnnotations;

namespace MiOpenApiDemo.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "El correo es obligatorio")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        public string Password { get; set; }
    }
}
