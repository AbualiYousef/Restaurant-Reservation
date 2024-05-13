using RestaurantReservation.Db.Models;
using RestaurantReservation.Db.Models.Entities;

namespace RestaurantReservation.Db.Interfaces;

public interface IMenuItemRepository : IRepository<MenuItem>
{
    public Task<PagedResult<MenuItem>> ListOrderedMenuItemsAsync(int reservationId,
        PaginationParameters paginationParameters);
}