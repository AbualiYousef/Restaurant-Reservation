using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Interfaces;
using RestaurantReservation.Db.Models;
using RestaurantReservation.Db.Models.Entities;

namespace RestaurantReservation.Db.Repositories;

public class OrderRepository(ApplicationDbContext context)
    : Repository<Order>(context, context.Orders), IOrderRepository
{
    public async Task<PagedResult<Order>> ListOrdersAndMenuItemsAsync(int reservationId,
        PaginationParameters paginationParameters)
    {
        var skip = (paginationParameters.PageNumber - 1) * paginationParameters.PageSize;

        var totalCount = await context.Orders
            .Where(o => o.ReservationId == reservationId)
            .CountAsync();

        var orders = await context.Orders
            .Where(o => o.ReservationId == reservationId)
            .Include(o => o.OrderItems)
            .ThenInclude(oi => oi.MenuItem)
            .Skip(skip)
            .Take(paginationParameters.PageSize)
            .ToListAsync();

        return new PagedResult<Order>(orders, totalCount, paginationParameters.PageNumber,
            paginationParameters.PageSize);
    }

    public async Task<decimal> CalculateAverageOrderAmountAsync(int employeeId)
    {
        var avg = await context.Orders
            .Where(o => o.EmployeeId == employeeId)
            .AverageAsync(o => o.TotalAmount);
        return avg;
    }
}