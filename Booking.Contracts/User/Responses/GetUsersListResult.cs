using Otus.Booking.Common.Booking.Contracts.Common;
using Otus.Booking.Common.Booking.Contracts.User.Models;

namespace Otus.Booking.Common.Booking.Contracts.User.Responses
{
    public record GetUsersListResult : ListedResponse<FullUserDto>;
}
