using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Interfaces;
using RestaurantReservation.Db.Models;
using RestaurantReservation.Db.Models.Entities;

namespace RestaurantReservation.Db.Repositories;

public class MenuItemRepository(ApplicationDbContext context)
    : Repository<MenuItem>(context, context.MenuItems), IMenuItemRepository
{
    public async Task<PagedResult<MenuItem>> ListOrderedMenuItemsAsync(int reservationId,
        PaginationParameters paginationParameters)
    {
        var skip = (paginationParameters.PageNumber - 1) * paginationParameters.PageSize;

        var totalCount = await context.OrderItems
            .Where(oi => oi.Order.ReservationId == reservationId)
            .Select(oi => oi.MenuItem)
            .Distinct()
            .CountAsync();

        var menuItems = await context.OrderItems
            .Where(oi => oi.Order.ReservationId == reservationId)
            .Select(oi => oi.MenuItem)
            .Distinct()
            .Skip(skip)
            .Take(paginationParameters.PageSize)
            .ToListAsync();

        return new PagedResult<MenuItem>(menuItems, totalCount, paginationParameters.PageNumber,
            paginationParameters.PageSize);
    }
}