namespace Otus.Booking.Common.Booking.Contracts.Filial.Requests
{
    public record GetFilialsList
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
