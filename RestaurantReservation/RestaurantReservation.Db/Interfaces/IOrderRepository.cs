using RestaurantReservation.Db.Models;
using RestaurantReservation.Db.Models.Entities;

namespace RestaurantReservation.Db.Interfaces;

public interface IOrderRepository : IRepository<Order>
{
    public Task<PagedResult<Order>> ListOrdersAndMenuItemsAsync(int reservationId,
        PaginationParameters paginationParameters);

    public Task<decimal> CalculateAverageOrderAmountAsync(int employeeId);
}