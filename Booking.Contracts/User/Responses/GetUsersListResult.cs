using Otus.Booking.Common.Booking.Contracts.User.Models;

namespace Otus.Booking.Common.Booking.Contracts.User.Responses
{
    public record GetUsersListResult
    {
        public List<FullUserDto> Users { get; set; }
    }
}
