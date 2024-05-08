using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Interfaces;
using RestaurantReservation.Db.Models.Entities;

namespace RestaurantReservation.Db.Repositories;

public class OrderRepository(ApplicationDbContext context)
    : Repository<Order>(context, context.Orders), IOrderRepository
{
    public async Task<IEnumerable<Order>> ListOrdersAndMenuItemsAsync(int reservationId)
    {
        return await context.Orders
            .Where(o => o.ReservationId == reservationId)
            .Include(o => o.OrderItems)
            .ThenInclude(oi => oi.MenuItem)
            .ToListAsync();
    }

    public async Task<decimal> CalculateAverageOrderAmountAsync(int employeeId)
    {
        var avg = await context.Orders
            .Where(o => o.EmployeeId == employeeId)
            .AverageAsync(o => o.TotalAmount);
        return avg;
    }
}