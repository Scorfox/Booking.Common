namespace Otus.Booking.Common.Booking.Contracts.Auth.Requests;

// Запрос на аутентификакцию, авторизацию и получения JWT-токена
public record Authenticate
{
    public string Email { get; set; }
    public string Password { get; set; }
}