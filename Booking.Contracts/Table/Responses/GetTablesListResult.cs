using Otus.Booking.Common.Booking.Contracts.Common;
using Otus.Booking.Common.Booking.Contracts.Table.Models;

namespace Otus.Booking.Common.Booking.Contracts.Table.Responses;

/// <summary>
/// Запрос на успешноен получение столов с пагинацией
/// </summary>
public record GetTablesListResult : ResponseByPagination<TableGettingDto>;