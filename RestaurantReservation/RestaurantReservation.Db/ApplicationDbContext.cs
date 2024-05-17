using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Exceptions;
using RestaurantReservation.Db.Extensions;
using RestaurantReservation.Db.Models.Entities;
using RestaurantReservation.Db.Models.Views;

namespace RestaurantReservation.Db;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<MenuItem> MenuItems { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Table> Tables { get; set; }

    public DbSet<ReservationDetails> ReservationsDetails { get; set; }

    public DbSet<EmployeeDetails> EmployeesDetails { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        modelBuilder.Seed();
        modelBuilder.Entity<ReservationDetails>().HasNoKey().ToView("View_ReservationsDetails");
        modelBuilder.Entity<EmployeeDetails>().HasNoKey().ToView("View_EmployeesDetails");
        modelBuilder
            .HasDbFunction(typeof(ApplicationDbContext)
                .GetMethod(nameof(CalculateRestaurantTotalRevenue), new[] { typeof(int) })!)
            .HasName("fn_CalculateTotalRevenue");
    }

    public decimal CalculateRestaurantTotalRevenue(int restaurantId)
    {
        var restaurant = Restaurants
            .Include(r => r.Reservations)!
            .ThenInclude(r => r.Orders)!
            .ThenInclude(o => o.OrderItems)
            .ThenInclude(oi => oi.MenuItem)
            .FirstOrDefault(r => r.Id == restaurantId);

        if (restaurant == null)
        {
            throw new EntityNotFoundException<Restaurant>($"Restaurant with id {restaurantId} not found.");
        }

        var totalRevenue = restaurant.Reservations!
            .SelectMany(r => r.Orders!)
            .SelectMany(o => o.OrderItems)
            .Sum(oi => oi.MenuItem.Price * oi.Quantity);

        return totalRevenue;
    }
}