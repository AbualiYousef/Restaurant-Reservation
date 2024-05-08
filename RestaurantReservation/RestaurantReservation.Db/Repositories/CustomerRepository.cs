using RestaurantReservation.Db.Interfaces;
using RestaurantReservation.Db.Models.Entities;

namespace RestaurantReservation.Db.Repositories;

public class CustomerRepository(ApplicationDbContext context)
    : Repository<Customer>(context, context.Customers), ICustomerRepository
{
}