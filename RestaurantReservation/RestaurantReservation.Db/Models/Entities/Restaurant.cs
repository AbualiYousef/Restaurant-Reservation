namespace RestaurantReservation.Db.Models.Entities;

public class Restaurant
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string openingHours { get; set; }
    public List<Employee> Employees { get; set; } = new List<Employee>();
    public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
    public List<Reservation> Reservations { get; set; } = new List<Reservation>();
    public List<Table> Tables { get; set; } = new List<Table>();
}