using Otus.Booking.Common.Booking.Contracts.Common;

namespace Otus.Booking.Common.Booking.Contracts.Company.Requests;

/// <summary>
/// Запрос на получение компанией с пагниацией
/// </summary>
public record GetCompaniesList : RequestByPagination;