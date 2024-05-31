using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Exceptions;
using RestaurantReservation.Db.Interfaces;
using RestaurantReservation.Db.Models;
using RestaurantReservation.Db.Models.Entities;

namespace RestaurantReservation.Db.Repositories;

public class OrderRepository(
    ApplicationDbContext context,
    IRepository<Reservation> reservationRepository,
    IRepository<Employee> employeeRepository)
    : Repository<Order>(context, context.Orders), IOrderRepository
{
    private readonly ApplicationDbContext _context = context;

    public async Task<PagedResult<Order>> ListOrdersAndMenuItemsAsync(int reservationId,
        PaginationParameters paginationParameters)
    {
        var reservation = await reservationRepository.GetByIdAsync(reservationId);
        if (reservation == null)
        {
            throw new EntityNotFoundException<Reservation>($"Reservation with id {reservationId} not found.");
        }

        var skip = (paginationParameters.PageNumber - 1) * paginationParameters.PageSize;

        var totalCount = await _context.Orders
            .Where(o => o.ReservationId == reservationId)
            .CountAsync();

        var orders = await _context.Orders
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
        var employee = await employeeRepository.GetByIdAsync(employeeId);
        if (employee == null)
        {
            throw new EntityNotFoundException<Employee>($"Employee with id {employeeId} not found.");
        }

        var avg = await _context.Orders
            .Where(o => o.EmployeeId == employeeId)
            .AverageAsync(o => o.TotalAmount);
        return avg;
    }
}