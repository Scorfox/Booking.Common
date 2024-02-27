using Otus.Booking.Common.Booking.Contracts.Table.Models;

namespace Otus.Booking.Common.Booking.Contracts.Table.Responses
{
    public record GetTablesListResult
    {
        public List<FullTableDto> Tables { get; set; }
    }
}
