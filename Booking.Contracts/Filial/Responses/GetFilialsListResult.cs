using Otus.Booking.Common.Booking.Contracts.Common;
using Otus.Booking.Common.Booking.Contracts.Filial.Models;

namespace Otus.Booking.Common.Booking.Contracts.Filial.Responses;

/// <summary>
/// Ответ на успешное получение филиалов с пагинацией
/// </summary>
public record GetFilialsListResult : ResponseByPagination<FilialGettingDto>;