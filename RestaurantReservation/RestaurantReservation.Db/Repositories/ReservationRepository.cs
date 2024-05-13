using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Interfaces;
using RestaurantReservation.Db.Models;
using RestaurantReservation.Db.Models.Entities;
using RestaurantReservation.Db.Models.Views;

namespace RestaurantReservation.Db.Repositories;

public class ReservationRepository(ApplicationDbContext context)
    : Repository<Reservation>(context, context.Reservations), IReservationRepository
{
    public async Task<PagedResult<Reservation>> GetReservationsByCustomerAsync(int customerId,
        PaginationParameters paginationParameters)
    {
        var skip = (paginationParameters.PageNumber - 1) * paginationParameters.PageSize;

        var totalCount = await context.Reservations
            .Where(r => r.CustomerId == customerId)
            .CountAsync();

        var reservations = await context.Reservations
            .Where(r => r.CustomerId == customerId)
            .Skip(skip)
            .Take(paginationParameters.PageSize)
            .ToListAsync();

        return new PagedResult<Reservation>(reservations, totalCount, paginationParameters.PageNumber,
            paginationParameters.PageSize);
    }

    public async Task<PagedResult<ReservationDetails>> GetReservationsDetailsAsync(
        PaginationParameters paginationParameters)
    {
        var skip = (paginationParameters.PageNumber - 1) * paginationParameters.PageSize;

        var totalCount = await context.ReservationsDetails.CountAsync();

        var reservationsDetails = await context.ReservationsDetails
            .Skip(skip)
            .Take(paginationParameters.PageSize)
            .ToListAsync();

        return new PagedResult<ReservationDetails>(reservationsDetails, totalCount, paginationParameters.PageNumber,
            paginationParameters.PageSize);
    }
}