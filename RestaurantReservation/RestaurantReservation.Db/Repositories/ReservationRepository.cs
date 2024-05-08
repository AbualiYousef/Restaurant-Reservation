using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Interfaces;
using RestaurantReservation.Db.Models.Entities;

namespace RestaurantReservation.Db.Repositories;

public class ReservationRepository(ApplicationDbContext context)
    : Repository<Reservation>(context, context.Reservations), IReservationRepository
{
    public async Task<IEnumerable<Reservation>> GetReservationsByCustomerAsync(int customerId)
    {
        return await context.Reservations
            .Where(r => r.CustomerId == customerId)
            .ToListAsync();
    }
}