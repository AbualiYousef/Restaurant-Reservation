using RestaurantReservation.Db.Models.Entities;

namespace RestaurantReservation.Db.Interfaces;

public interface IEmployeeRepository : IRepository<Employee>
{
    public Task<IEnumerable<Employee>> ListManagersAsync();
}