using RestaurantReservation.Db.Interfaces;
using RestaurantReservation.Db.Models.Entities;

namespace RestaurantReservation.Db.Repositories;

public class OrderItemRepository(ApplicationDbContext context)
    : Repository<OrderItem>(context, context.OrderItems), IOrderItemRepository
{
}