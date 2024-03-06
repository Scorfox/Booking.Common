using Otus.Booking.Common.Booking.Contracts.Common;
using Otus.Booking.Common.Booking.Contracts.Table.Models;

namespace Otus.Booking.Common.Booking.Contracts.Table.Responses
{
    public record GetTablesListResult : ListedResponse<FullTableDto>;
}
