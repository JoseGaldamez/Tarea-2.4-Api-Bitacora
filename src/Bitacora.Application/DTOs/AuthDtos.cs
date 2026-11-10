namespace Bitacora.Application.DTOs;
// DTOs contratos para el registro, el login y la gestión de tokens
public record RegisterRequestDto(string Email, string Password, string Role = "Usuario");
public record LoginRequestDto(string Email, string Password);
public record AuthResponseDto(string Token, DateTime Expiration, string Role, string Email);
