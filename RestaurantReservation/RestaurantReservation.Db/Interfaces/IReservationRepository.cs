using RestaurantReservation.Db.Models.Entities;
using RestaurantReservation.Db.Models.Views;

namespace RestaurantReservation.Db.Interfaces;

public interface IReservationRepository : IRepository<Reservation>
{
    Task<IEnumerable<Reservation>> GetReservationsByCustomerAsync(int customerId);
    Task<IEnumerable<ReservationDetails>> GetReservationsDetailsAsync();
}