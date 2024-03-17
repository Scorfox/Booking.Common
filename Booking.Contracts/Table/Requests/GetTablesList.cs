using Otus.Booking.Common.Booking.Contracts.Common;

namespace Otus.Booking.Common.Booking.Contracts.Table.Requests;

/// <summary>
/// Запрос на поулчение столов с пагинацией
/// </summary>
public record GetTablesList : RequestByPagination;