namespace Otus.Booking.Common.Booking.Contracts.User.Models
{
    public record FullUserDto:BaseUserDto
    {
        public Guid Id { get; set; }
    }
}
