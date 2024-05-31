using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Exceptions;
using RestaurantReservation.Db.Interfaces;
using RestaurantReservation.Db.Models;
using RestaurantReservation.Db.Models.Entities;

namespace RestaurantReservation.Db.Repositories
{
    public class MenuItemRepository(ApplicationDbContext context, IRepository<Reservation> reservationRepository)
        : Repository<MenuItem>(context, context.MenuItems), IMenuItemRepository
    {
        private readonly ApplicationDbContext _context = context ?? throw new ArgumentNullException(nameof(context));

        public async Task<PagedResult<MenuItem>> ListOrderedMenuItemsAsync(int reservationId,
            PaginationParameters paginationParameters)
        {
            var reservation = await reservationRepository.GetByIdAsync(reservationId);

            if (reservation == null)
            {
                throw new EntityNotFoundException<Reservation>($"Reservation with id {reservationId} not found.");
            }

            var skip = (paginationParameters.PageNumber - 1) * paginationParameters.PageSize;

            var totalCount = await _context.OrderItems
                .Where(oi => oi.Order.ReservationId == reservationId)
                .Select(oi => oi.MenuItem)
                .Distinct()
                .CountAsync();

            var menuItems = await _context.OrderItems
                .Where(oi => oi.Order.ReservationId == reservationId)
                .Select(oi => oi.MenuItem)
                .Distinct()
                .Skip(skip)
                .Take(paginationParameters.PageSize)
                .ToListAsync();

            return new PagedResult<MenuItem>(menuItems, totalCount, paginationParameters.PageNumber,
                paginationParameters.PageSize);
        }
    }
}