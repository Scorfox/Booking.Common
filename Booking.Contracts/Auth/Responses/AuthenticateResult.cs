namespace Otus.Booking.Common.Booking.Contracts.Auth.Responses;

// Ответ на запрос аутентификации, авторизации
public record AuthenticateResult
{
    public string AccessToken { get; set; }
    public string RefreshToken { get; set; }
}