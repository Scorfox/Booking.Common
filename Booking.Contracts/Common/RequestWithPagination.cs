namespace Otus.Booking.Common.Booking.Contracts.Common
{
    public abstract record RequestWithPagination
    {
        public int Offset { get; set; }
        public int Count { get; set; }
    }
}
