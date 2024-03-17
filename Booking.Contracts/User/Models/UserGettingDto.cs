namespace Otus.Booking.Common.Booking.Contracts.User.Models;

public record UserGettingDto : BaseUserDto
{
    public Guid Id { get; set; }
}