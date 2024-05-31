namespace RestaurantReservation.Db.Models.Entities;

public class Table
{
    public int Id { get; set; }
    public int Capacity { get; set; }
    public int? RestaurantId { get; set; }
    public Restaurant Restaurant { get; set; }
    public List<Reservation>? Reservations { get; set; } = new();
}