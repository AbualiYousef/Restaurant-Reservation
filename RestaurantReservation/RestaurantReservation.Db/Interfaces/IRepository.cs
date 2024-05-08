using System.Linq.Expressions;
using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Db.Interfaces;

public interface IRepository<T> where T : class
{
    Task<PagedResult<T>> GetAllAsync(int pageNumber, int pageSize, Expression<Func<T, bool>>? filter = null);
    Task<T?> GetByIdAsync(Guid id);
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}