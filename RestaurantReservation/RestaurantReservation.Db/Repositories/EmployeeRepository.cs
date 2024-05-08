using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Interfaces;
using RestaurantReservation.Db.Models.Entities;
using RestaurantReservation.Db.Models.Enums;
using RestaurantReservation.Db.Models.Views;

namespace RestaurantReservation.Db.Repositories;

public class EmployeeRepository(ApplicationDbContext context)
    : Repository<Employee>(context, context.Employees), IEmployeeRepository
{
    public async Task<IEnumerable<Employee>> ListManagersAsync()
    {
        return await context.Employees
            .Where(e => e.Position == EmployeePosition.Manager)
            .ToListAsync();
    }

    public async Task<IEnumerable<EmployeeDetails>> GetEmployeesDetailsAsync()
    {
        return await context.EmployeesDetails.ToListAsync();
    }
}