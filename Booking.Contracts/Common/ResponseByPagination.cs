namespace Otus.Booking.Common.Booking.Contracts.Common;

/// <summary>
/// Ответ с пагинацией
/// </summary>
public abstract record ResponseByPagination<T>
{
    public int TotalCount { get; set; }
    public List<T> Elements { get; set; } = [];
}