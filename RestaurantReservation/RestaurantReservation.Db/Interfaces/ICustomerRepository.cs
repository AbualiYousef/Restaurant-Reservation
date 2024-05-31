using RestaurantReservation.Db.Models;
using RestaurantReservation.Db.Models.Entities;

namespace RestaurantReservation.Db.Interfaces;

public interface ICustomerRepository : IRepository<Customer>
{
    public Task<PagedResult<Customer>> FindCustomersWithPartySizeLargerThanAsync(int partySize,
        PaginationParameters paginationParameters);
}