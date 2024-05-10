using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Interfaces;
using RestaurantReservation.Db.Models.Entities;

namespace RestaurantReservation.Db.Repositories;

public class CustomerRepository(ApplicationDbContext context)
    : Repository<Customer>(context, context.Customers), ICustomerRepository
{
    public async Task<IEnumerable<Customer>> FindCustomersWithPartySizeLargerThanAsync(int partySize)
    {
        var customers = await context.Customers
            .FromSqlRaw("EXEC FindCustomersWithPartySize @PartySize={0}", partySize)
            .ToListAsync();

        return customers;
    }
}