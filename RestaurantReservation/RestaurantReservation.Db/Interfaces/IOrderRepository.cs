using RestaurantReservation.Db.Models.Entities;

namespace RestaurantReservation.Db.Interfaces;

public interface IOrderRepository : IRepository<Order>
{
    public Task<IEnumerable<Order>> ListOrdersAndMenuItemsAsync(int reservationId);
    public Task<decimal> CalculateAverageOrderAmountAsync(int employeeId);
}