using RestaurantReservation.Db.Interfaces;
using RestaurantReservation.Db.Models.Entities;

namespace RestaurantReservation.Db.Repositories;

public class RestaurantRepository(ApplicationDbContext context)
    : Repository<Restaurant>(context, context.Restaurants), IRestaurantRepository
{
}