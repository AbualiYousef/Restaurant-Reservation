using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Interfaces;
using RestaurantReservation.Db.Models.Entities;

namespace RestaurantReservation.Db.Repositories;

public class MenuItemRepository(ApplicationDbContext context)
    : Repository<MenuItem>(context, context.MenuItems), IMenuItemRepository
{
    public async Task<IEnumerable<MenuItem>> ListOrderedMenuItemsAsync(int reservationId)
    {
        return await context.OrderItems
            .Where(oi => oi.Order.ReservationId == reservationId)
            .Select(oi => oi.MenuItem)
            .Distinct()
            .ToListAsync();
    }
}