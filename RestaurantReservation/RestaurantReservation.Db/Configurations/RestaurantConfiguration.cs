using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReservation.Db.Models.Entities;

namespace RestaurantReservation.Db.Configurations;

public class RestaurantConfiguration : IEntityTypeConfiguration<Restaurant>
{
    public void Configure(EntityTypeBuilder<Restaurant> builder)
    {
        builder.Property(r => r.Name).IsRequired().HasMaxLength(50);
        builder.Property(r => r.Address).IsRequired().HasMaxLength(100);
        builder.Property(r => r.PhoneNumber).IsRequired().HasMaxLength(15);
        builder.Property(r => r.OpeningHours).IsRequired().HasMaxLength(50);
    }
}