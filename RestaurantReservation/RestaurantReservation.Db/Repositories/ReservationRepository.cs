using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Exceptions;
using RestaurantReservation.Db.Interfaces;
using RestaurantReservation.Db.Models;
using RestaurantReservation.Db.Models.Entities;
using RestaurantReservation.Db.Models.Views;

namespace RestaurantReservation.Db.Repositories;

public class ReservationRepository(
    ApplicationDbContext context,
    IRepository<Customer> customerRepository)
    : Repository<Reservation>(context, context.Reservations), IReservationRepository
{
    private readonly ApplicationDbContext _context = context;

    public async Task<PagedResult<Reservation>> GetReservationsByCustomerAsync(int customerId,
        PaginationParameters paginationParameters)
    {
        var customer = await customerRepository.GetByIdAsync(customerId);
        if (customer == null)
        {
            throw new EntityNotFoundException<Customer>($"Customer with id {customerId} not found.");
        }

        var skip = (paginationParameters.PageNumber - 1) * paginationParameters.PageSize;

        var totalCount = await _context.Reservations
            .Where(r => r.CustomerId == customerId)
            .CountAsync();

        var reservations = await _context.Reservations
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

        var totalCount = await _context.ReservationsDetails.CountAsync();

        var reservationsDetails = await _context.ReservationsDetails
            .Skip(skip)
            .Take(paginationParameters.PageSize)
            .ToListAsync();

        return new PagedResult<ReservationDetails>(reservationsDetails, totalCount, paginationParameters.PageNumber,
            paginationParameters.PageSize);
    }
}