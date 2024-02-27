using Otus.Booking.Common.Booking.Contracts.User.Models;

namespace Otus.Booking.Common.Booking.Contracts.User.Responses
{
    public record GetUserResult : BaseUserDto
    {
        public Guid Id { get; set; }
    }
}
