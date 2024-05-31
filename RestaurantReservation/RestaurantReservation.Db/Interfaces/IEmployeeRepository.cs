using RestaurantReservation.Db.Models;
using RestaurantReservation.Db.Models.Entities;
using RestaurantReservation.Db.Models.Views;

namespace RestaurantReservation.Db.Interfaces;

public interface IEmployeeRepository : IRepository<Employee>
{
    Task<PagedResult<Employee>> ListManagersAsync(PaginationParameters paginationParameters);
    Task<PagedResult<EmployeeDetails>> GetEmployeesDetailsAsync(PaginationParameters paginationParameters);
}