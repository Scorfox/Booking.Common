namespace Otus.Booking.Common.Booking.Contracts.Common;

/// <summary>
/// Запрос с пагинацией
/// </summary>
public abstract record RequestByPagination
{
    public int Offset { get; set; }
    public int Count { get; set; }
}