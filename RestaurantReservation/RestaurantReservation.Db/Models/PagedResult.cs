namespace RestaurantReservation.Db.Models;

public class PagedResult<T>(IEnumerable<T> items, int count, int pageNumber, int pageSize)
{
    public IEnumerable<T> Items { get; set; } = items;
    public int CurrentPage { get; set; } = pageNumber;
    public int TotalPages { get; set; } = (int)Math.Ceiling(count / (double)pageSize);
    public int PageSize { get; set; } = pageSize;
    public int TotalCount { get; set; } = count;

    public bool HasPrevious => CurrentPage > 1;
    public bool HasNext => CurrentPage < TotalPages;
}