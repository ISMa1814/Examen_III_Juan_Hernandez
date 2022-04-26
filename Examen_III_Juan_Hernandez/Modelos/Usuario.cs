using System.ComponentModel.DataAnnotations;

namespace Modelos;

public class Usuario
{
    [Required(ErrorMessage = "El campo Codigo es obligatorio")]
    public string Codigo { get; set; }
    public string Nombre { get; set; }
    public string Rol { get; set; }
    [Required(ErrorMessage = "El campo Clave es obligatorio")]
    public string Clave { get; set; }
    public bool EstaActivo { get; set; }
}
