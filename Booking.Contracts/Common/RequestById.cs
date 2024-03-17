namespace Otus.Booking.Common.Booking.Contracts.Common;

/// <summary>
/// Запрос по ID
/// </summary>
public abstract record RequestById
{
    public Guid Id { get; set; }
}