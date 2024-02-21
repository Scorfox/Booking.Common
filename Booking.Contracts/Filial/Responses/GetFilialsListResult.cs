using Otus.Booking.Common.Booking.Contracts.Filial.Models;

namespace Otus.Booking.Common.Booking.Contracts.Filial.Responses
{
    public record GetFilialsListResult
    {
        public List<FullFilialDto> Filials { get; set; }
    }
}
