using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Interfaces;
using RestaurantReservation.Db.Models.Entities;

namespace RestaurantReservation.Db.Repositories;

public class RestaurantRepository(ApplicationDbContext context)
    : Repository<Restaurant>(context, context.Restaurants), IRestaurantRepository
{
    public async Task<decimal> GetTotalRevenueAsync(int restaurantId)
    {
        var revenue = await context.Restaurants
            .Where(r => r.Id == restaurantId)
            .Select(r => context.CalculateRestaurantTotalRevenue(r.Id))
            .FirstOrDefaultAsync();
        return revenue;
    }
}