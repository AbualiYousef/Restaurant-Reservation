using RestaurantReservation.Db.Models.Enums;

namespace RestaurantReservation.Db.Models.Entities;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public EmployeePosition Position { get; set; }
    public int? RestaurantId { get; set; }
    public Restaurant Restaurant { get; set; }
    public List<Order>? Orders { get; set; } = new();
}