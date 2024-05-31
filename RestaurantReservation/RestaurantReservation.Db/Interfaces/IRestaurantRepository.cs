using RestaurantReservation.Db.Models.Entities;

namespace RestaurantReservation.Db.Interfaces;

public interface IRestaurantRepository : IRepository<Restaurant>
{
    public Task<decimal> GetTotalRevenueAsync(int restaurantId);
}