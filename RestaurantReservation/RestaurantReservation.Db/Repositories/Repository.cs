using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Interfaces;
using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Db.Repositories;

public class Repository<T>(
    ApplicationDbContext context,
    DbSet<T> dbSet) : IRepository<T>
    where T : class
{
    public async Task<PagedResult<T>> GetAllAsync(PaginationParameters paginationParameters,
        Expression<Func<T, bool>>? filter = null)
    {
        IQueryable<T> query = dbSet;

        if (filter != null)
        {
            query = query.Where(filter);
        }

        var totalItemCount = await query.CountAsync();
        var items = await query
            .Skip((paginationParameters.PageNumber - 1) * paginationParameters.PageSize)
            .Take(paginationParameters.PageSize)
            .ToListAsync();

        return new PagedResult<T>(items, totalItemCount, paginationParameters.PageNumber,
            paginationParameters.PageSize);
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        return await dbSet.FindAsync(id);
    }

    public async Task AddAsync(T entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        await dbSet.AddAsync(entity);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        dbSet.Update(entity);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        dbSet.Remove(entity);
        await context.SaveChangesAsync();
    }
}