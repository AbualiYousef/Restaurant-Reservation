using RestaurantReservation.Db.Interfaces;
using RestaurantReservation.Db.Models.Entities;

namespace RestaurantReservation.Db.Repositories;

public class TableRepository(ApplicationDbContext context)
    : Repository<Table>(context, context.Tables), ITableRepository
{
}