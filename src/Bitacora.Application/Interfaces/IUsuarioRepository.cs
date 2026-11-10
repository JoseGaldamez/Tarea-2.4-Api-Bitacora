using Bitacora.Domain.Entities;
// Interface para el repositorio de usuarios, define los métodos que deben implementarse para interactuar con la entidad Usuario.
namespace Bitacora.Application.Interfaces;

public interface IUsuarioRepository
{
    Task<Usuario?> GetByEmailAsync(string email);
    Task AddAsync(Usuario usuario);
    Task<bool> ExistsAsync(string email);
}
