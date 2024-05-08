using RestaurantReservation.Db.Models.Entities;

namespace RestaurantReservation.Db.Interfaces;

public interface IMenuItemRepository : IRepository<MenuItem>
{
    public Task<IEnumerable<MenuItem>> ListOrderedMenuItemsAsync(int reservationId);
}