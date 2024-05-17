using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Exceptions;
using RestaurantReservation.Db.Interfaces;
using RestaurantReservation.Db.Models;
using RestaurantReservation.Db.Models.Entities;

namespace RestaurantReservation.Db.Repositories
{
    public class CustomerRepository(ApplicationDbContext context)
        : Repository<Customer>(context, context.Customers), ICustomerRepository
    {
        private readonly ApplicationDbContext _context = context ?? throw new ArgumentNullException(nameof(context));

        public async Task<PagedResult<Customer>> FindCustomersWithPartySizeLargerThanAsync(int partySize,
            PaginationParameters paginationParameters)
        {
            if (partySize <= 0)
            {
                throw new InvalidPartySizeException("Party size must be greater than 0.");
            }

            var skip = (paginationParameters.PageNumber - 1) * paginationParameters.PageSize;

            var totalCount = await _context.Customers
                .FromSqlRaw("EXEC CountCustomersWithPartySize @PartySize={0}", partySize)
                .CountAsync();

            var customers = await _context.Customers
                .FromSqlRaw("EXEC FindCustomersWithPartySize @PartySize={0}", partySize)
                .Skip(skip)
                .Take(paginationParameters.PageSize)
                .ToListAsync();

            return new PagedResult<Customer>(customers, totalCount, paginationParameters.PageNumber,
                paginationParameters.PageSize);
        }
    }
}