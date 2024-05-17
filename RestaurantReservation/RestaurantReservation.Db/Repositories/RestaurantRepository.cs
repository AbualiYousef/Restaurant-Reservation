using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Exceptions;
using RestaurantReservation.Db.Interfaces;
using RestaurantReservation.Db.Models.Entities;

namespace RestaurantReservation.Db.Repositories;

public class RestaurantRepository(
    ApplicationDbContext context,
    IRepository<Restaurant> restaurantRepository)
    : Repository<Restaurant>(context, context.Restaurants), IRestaurantRepository
{
    private readonly ApplicationDbContext _context = context;

    public async Task<decimal> GetTotalRevenueAsync(int restaurantId)
    {
        var restaurant = await restaurantRepository.GetByIdAsync(restaurantId);
        if (restaurant == null)
        {
            throw new EntityNotFoundException<Restaurant>($"Restaurant with id {restaurantId} not found.");
        }

        var revenue = await _context.Restaurants
            .Where(r => r.Id == restaurantId)
            .Select(r => _context.CalculateRestaurantTotalRevenue(r.Id))
            .FirstOrDefaultAsync();
        return revenue;
    }
}