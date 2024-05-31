using RestaurantReservation.Db.Models;
using RestaurantReservation.Db.Models.Entities;
using RestaurantReservation.Db.Models.Views;

namespace RestaurantReservation.Db.Interfaces;

public interface IReservationRepository : IRepository<Reservation>
{
    public Task<PagedResult<Reservation>> GetReservationsByCustomerAsync(int customerId,
        PaginationParameters paginationParameters);

    public Task<PagedResult<ReservationDetails>> GetReservationsDetailsAsync(PaginationParameters paginationParameters);
}