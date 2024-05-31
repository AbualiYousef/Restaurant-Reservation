namespace RestaurantReservation.Db.Exceptions;

public class EntityNotFoundException<T> : Exception where T : class
{
    public EntityNotFoundException(string message) : base(message)
    {
    }
}