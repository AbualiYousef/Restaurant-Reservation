namespace RestaurantReservation.Db.Exceptions;

public class InvalidReservationIdException : Exception
{
    public InvalidReservationIdException(string message) : base(message)
    {
    }
}