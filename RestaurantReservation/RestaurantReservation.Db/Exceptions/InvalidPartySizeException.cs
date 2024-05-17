namespace RestaurantReservation.Db.Exceptions;

public class InvalidPartySizeException: Exception
{
    public InvalidPartySizeException(string message): base(message)
    {
    }
}