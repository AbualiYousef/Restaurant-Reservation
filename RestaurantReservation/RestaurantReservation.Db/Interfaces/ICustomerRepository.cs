using RestaurantReservation.Db.Models.Entities;

namespace RestaurantReservation.Db.Interfaces;

public interface ICustomerRepository : IRepository<Customer>
{
    public Task<IEnumerable<Customer>> FindCustomersWithPartySizeLargerThanAsync(int partySize);
}