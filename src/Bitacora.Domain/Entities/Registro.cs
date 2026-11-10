namespace Bitacora.Domain.Entities;

public sealed class Registro
{
    //Agregar la propiedad UsuarioId y la propiedad de navegación Usuario
    public int UsuarioId { get; set; }
    public Usuario? Usuario { get; set; }
    public int Id { get; set; }
    public required string Titulo { get; set; }
    public required string Descripcion { get; set; }
    public string? FotoBase64 { get; set; }
    public DateTimeOffset FechaCreacion { get; set; } = DateTimeOffset.UtcNow;
}