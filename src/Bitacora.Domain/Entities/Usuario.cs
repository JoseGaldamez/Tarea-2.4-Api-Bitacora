namespace Bitacora.Domain.Entities;
//Agregamos la clase Usuario para representar a los usuarios en la aplicación
public class Usuario
{
    public int Id { get; set; }
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string Role { get; set; } = "Usuario"; // "Admin" o "Usuario"

    public ICollection<Registro> Registros { get; set; } = new List<Registro>();
}
