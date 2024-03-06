using Otus.Booking.Common.Booking.Contracts.Common;
using Otus.Booking.Common.Booking.Contracts.Filial.Models;

namespace Otus.Booking.Common.Booking.Contracts.Filial.Responses
{
    public record GetFilialsListResult : ListedResponse<FullFilialDto>;
}
