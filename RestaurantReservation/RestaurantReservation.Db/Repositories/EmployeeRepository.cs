using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Interfaces;
using RestaurantReservation.Db.Models;
using RestaurantReservation.Db.Models.Entities;
using RestaurantReservation.Db.Models.Enums;
using RestaurantReservation.Db.Models.Views;

namespace RestaurantReservation.Db.Repositories
{
    public class EmployeeRepository(ApplicationDbContext context)
        : Repository<Employee>(context, context.Employees), IEmployeeRepository
    {
        private readonly ApplicationDbContext _context = context ?? throw new ArgumentNullException(nameof(context));

        public async Task<PagedResult<Employee>> ListManagersAsync(PaginationParameters paginationParameters)
        {
            var skip = (paginationParameters.PageNumber - 1) * paginationParameters.PageSize;

            var totalCount = await _context.Employees
                .Where(e => e.Position == EmployeePosition.Manager)
                .CountAsync();

            var managers = await _context.Employees
                .Where(e => e.Position == EmployeePosition.Manager)
                .Skip(skip)
                .Take(paginationParameters.PageSize)
                .ToListAsync();

            return new PagedResult<Employee>(managers, totalCount, paginationParameters.PageNumber,
                paginationParameters.PageSize);
        }

        public async Task<PagedResult<EmployeeDetails>> GetEmployeesDetailsAsync(
            PaginationParameters paginationParameters)
        {
            var skip = (paginationParameters.PageNumber - 1) * paginationParameters.PageSize;

            var totalCount = await _context.EmployeesDetails.CountAsync();

            var employeesDetails = await _context.EmployeesDetails
                .Skip(skip)
                .Take(paginationParameters.PageSize)
                .ToListAsync();

            return new PagedResult<EmployeeDetails>(employeesDetails, totalCount, paginationParameters.PageNumber,
                paginationParameters.PageSize);
        }
    }
}