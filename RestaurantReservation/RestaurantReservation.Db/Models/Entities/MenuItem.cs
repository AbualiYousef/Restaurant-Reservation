namespace RestaurantReservation.Db.Models.Entities;

public class MenuItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public int? RestaurantId { get; set; }
    public Restaurant Restaurant { get; set; }
    public List<OrderItem> OrderItems { get; set; }=new List<OrderItem>();
}