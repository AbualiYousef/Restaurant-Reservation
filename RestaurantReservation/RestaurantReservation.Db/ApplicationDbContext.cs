using Microsoft.EntityFrameworkCore;

namespace RestaurantReservation.Db;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
}