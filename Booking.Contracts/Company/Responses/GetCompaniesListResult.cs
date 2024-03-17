using Otus.Booking.Common.Booking.Contracts.Common;
using Otus.Booking.Common.Booking.Contracts.Company.Models;

namespace Otus.Booking.Common.Booking.Contracts.Company.Responses;

/// <summary>
/// Ответ на успешное получение компаний с пагинацией
/// </summary>
public record GetCompaniesListResult : ResponseByPagination<CompanyGettingDto>;