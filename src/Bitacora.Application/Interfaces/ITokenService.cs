using Bitacora.Domain.Entities;
// Token interfaz de servicio para generar tokens de autenticación para los usuarios.
namespace Bitacora.Application.Interfaces;

public interface ITokenService
{
    string GenerateToken(Usuario usuario, out DateTime expiration);
}