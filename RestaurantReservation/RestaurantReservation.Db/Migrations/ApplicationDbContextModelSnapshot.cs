﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantReservation.Db;

#nullable disable

namespace RestaurantReservation.Db.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RestaurantReservation.Db.Models.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "John.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            PhoneNumber = "123-456-7890"
                        },
                        new
                        {
                            Id = 2,
                            Email = "Jane.doe@example.com",
                            FirstName = "Jane",
                            LastName = "Doe",
                            PhoneNumber = "987-654-3210"
                        },
                        new
                        {
                            Id = 3,
                            Email = "Alice.smith@example.com",
                            FirstName = "Alice",
                            LastName = "Smith",
                            PhoneNumber = "555-123-4567"
                        },
                        new
                        {
                            Id = 4,
                            Email = "Bob.smith@example.com",
                            FirstName = "Bob",
                            LastName = "Smith",
                            PhoneNumber = "555-987-6543"
                        },
                        new
                        {
                            Id = 5,
                            Email = "Charlie.brown@example.com",
                            FirstName = "Charlie",
                            LastName = "Brown",
                            PhoneNumber = "555-555-5555"
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.Models.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<int?>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Ella",
                            LastName = "Fitzgerald",
                            Position = 4,
                            RestaurantId = 1
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Louis",
                            LastName = "Armstrong",
                            Position = 2,
                            RestaurantId = 1
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Billie",
                            LastName = "Holiday",
                            Position = 1,
                            RestaurantId = 1
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Charlie",
                            LastName = "Parker",
                            Position = 3,
                            RestaurantId = 2
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Dizzy",
                            LastName = "Gillespie",
                            Position = 1,
                            RestaurantId = 2
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.Models.Entities.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("MenuItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A juicy beef patty with lettuce, tomato, and our special sauce.",
                            Name = "Classic Burger",
                            Price = 8.99m,
                            RestaurantId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "A delicious and hearty vegetarian burger loaded with fresh vegetables.",
                            Name = "Veggie Burger",
                            Price = 9.50m,
                            RestaurantId = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "Crisp romaine lettuce with grilled chicken breast, shaved parmesan, and croutons.",
                            Name = "Chicken Caesar Salad",
                            Price = 7.75m,
                            RestaurantId = 2
                        },
                        new
                        {
                            Id = 4,
                            Description = "Classic pizza with fresh mozzarella, tomatoes, and basil.",
                            Name = "Margherita Pizza",
                            Price = 12.00m,
                            RestaurantId = 2
                        },
                        new
                        {
                            Id = 5,
                            Description = "Creamy pasta with pancetta, parmesan cheese, and a touch of egg.",
                            Name = "Pasta Carbonara",
                            Price = 11.00m,
                            RestaurantId = 3
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.Models.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ReservationId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ReservationId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmployeeId = 5,
                            OrderDate = new DateTime(2024, 5, 7, 23, 49, 6, 780, DateTimeKind.Local).AddTicks(7238),
                            ReservationId = 1,
                            TotalAmount = 45m
                        },
                        new
                        {
                            Id = 2,
                            EmployeeId = 3,
                            OrderDate = new DateTime(2024, 5, 6, 23, 49, 6, 780, DateTimeKind.Local).AddTicks(7290),
                            ReservationId = 2,
                            TotalAmount = 30m
                        },
                        new
                        {
                            Id = 3,
                            EmployeeId = 3,
                            OrderDate = new DateTime(2024, 5, 5, 23, 49, 6, 780, DateTimeKind.Local).AddTicks(7293),
                            ReservationId = 3,
                            TotalAmount = 60m
                        },
                        new
                        {
                            Id = 4,
                            EmployeeId = 5,
                            OrderDate = new DateTime(2024, 5, 4, 23, 49, 6, 780, DateTimeKind.Local).AddTicks(7296),
                            ReservationId = 4,
                            TotalAmount = 22m
                        },
                        new
                        {
                            Id = 5,
                            EmployeeId = 3,
                            OrderDate = new DateTime(2024, 5, 3, 23, 49, 6, 780, DateTimeKind.Local).AddTicks(7299),
                            ReservationId = 5,
                            TotalAmount = 80m
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.Models.Entities.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("MenuItemId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("OrderId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MenuItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MenuItemId = 1,
                            OrderId = 1,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 2,
                            MenuItemId = 2,
                            OrderId = 1,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 3,
                            MenuItemId = 3,
                            OrderId = 2,
                            Quantity = 3
                        },
                        new
                        {
                            Id = 4,
                            MenuItemId = 4,
                            OrderId = 2,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 5,
                            MenuItemId = 5,
                            OrderId = 3,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 6,
                            MenuItemId = 1,
                            OrderId = 3,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 7,
                            MenuItemId = 2,
                            OrderId = 4,
                            Quantity = 4
                        },
                        new
                        {
                            Id = 8,
                            MenuItemId = 3,
                            OrderId = 4,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 9,
                            MenuItemId = 4,
                            OrderId = 5,
                            Quantity = 3
                        },
                        new
                        {
                            Id = 10,
                            MenuItemId = 5,
                            OrderId = 5,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.Models.Entities.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CustomerId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("PartySize")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<int?>("TableId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("RestaurantId");

                    b.HasIndex("TableId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            PartySize = 4,
                            ReservationDate = new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            RestaurantId = 1,
                            TableId = 1
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2,
                            PartySize = 2,
                            ReservationDate = new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Local),
                            RestaurantId = 1,
                            TableId = 2
                        },
                        new
                        {
                            Id = 3,
                            CustomerId = 3,
                            PartySize = 6,
                            ReservationDate = new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            RestaurantId = 2,
                            TableId = 3
                        },
                        new
                        {
                            Id = 4,
                            CustomerId = 4,
                            PartySize = 3,
                            ReservationDate = new DateTime(2024, 5, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            RestaurantId = 2,
                            TableId = 4
                        },
                        new
                        {
                            Id = 5,
                            CustomerId = 5,
                            PartySize = 5,
                            ReservationDate = new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local),
                            RestaurantId = 3,
                            TableId = 5
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.Models.Entities.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("openingHours")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "1234 Culinary Blvd, Foodie Town",
                            Name = "Gourmet Hub",
                            PhoneNumber = "555-1234",
                            openingHours = "9:00 AM - 11:00 PM"
                        },
                        new
                        {
                            Id = 2,
                            Address = "5678 Pasta Lane, Little Italy",
                            Name = "The Italian Corner",
                            PhoneNumber = "555-5678",
                            openingHours = "11:00 AM - 10:00 PM"
                        },
                        new
                        {
                            Id = 3,
                            Address = "135 Sushi St, Downtown",
                            Name = "Sushi Sushi",
                            PhoneNumber = "555-1357",
                            openingHours = "12:00 PM - 10:00 PM"
                        },
                        new
                        {
                            Id = 4,
                            Address = "2468 Curry Ave, Spice City",
                            Name = "Curry Leaf",
                            PhoneNumber = "555-2468",
                            openingHours = "10:00 AM - 9:00 PM"
                        },
                        new
                        {
                            Id = 5,
                            Address = "7890 Burger Blvd, Greasy Corner",
                            Name = "The Burger Joint",
                            PhoneNumber = "555-7890",
                            openingHours = "10:00 AM - 12:00 AM"
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.Models.Entities.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int?>("RestaurantId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Tables");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 4,
                            RestaurantId = 1
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 2,
                            RestaurantId = 1
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 6,
                            RestaurantId = 2
                        },
                        new
                        {
                            Id = 4,
                            Capacity = 4,
                            RestaurantId = 2
                        },
                        new
                        {
                            Id = 5,
                            Capacity = 8,
                            RestaurantId = 3
                        },
                        new
                        {
                            Id = 6,
                            Capacity = 4,
                            RestaurantId = 3
                        },
                        new
                        {
                            Id = 7,
                            Capacity = 4,
                            RestaurantId = 4
                        },
                        new
                        {
                            Id = 8,
                            Capacity = 2,
                            RestaurantId = 4
                        },
                        new
                        {
                            Id = 9,
                            Capacity = 4,
                            RestaurantId = 5
                        },
                        new
                        {
                            Id = 10,
                            Capacity = 6,
                            RestaurantId = 5
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.Models.Views.EmployeeDetails", b =>
                {
                    b.Property<string>("EmployeeFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeePosition")
                        .HasColumnType("int");

                    b.Property<string>("RestaurantAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<string>("RestaurantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestaurantOpeningHours")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestaurantPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable((string)null);

                    b.ToView("View_EmployeesDetails", (string)null);
                });

            modelBuilder.Entity("RestaurantReservation.Db.Models.Views.ReservationDetails", b =>
                {
                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("CustomerLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PartySize")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.Property<int?>("ReservationTableId")
                        .HasColumnType("int");

                    b.Property<string>("RestaurantAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<string>("RestaurantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestaurantOpeningHours")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestaurantPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable((string)null);

                    b.ToView("View_ReservationsDetails", (string)null);
                });

            modelBuilder.Entity("RestaurantReservation.Db.Models.Entities.Employee", b =>
                {
                    b.HasOne("RestaurantReservation.Db.Models.Entities.Restaurant", "Restaurant")
                        .WithMany("Employees")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("RestaurantReservation.Db.Models.Entities.MenuItem", b =>
                {
                    b.HasOne("RestaurantReservation.Db.Models.Entities.Restaurant", "Restaurant")
                        .WithMany("MenuItems")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("RestaurantReservation.Db.Models.Entities.Order", b =>
                {
                    b.HasOne("RestaurantReservation.Db.Models.Entities.Employee", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("RestaurantReservation.Db.Models.Entities.Reservation", "Reservation")
                        .WithMany("Orders")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Employee");

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("RestaurantReservation.Db.Models.Entities.OrderItem", b =>
                {
                    b.HasOne("RestaurantReservation.Db.Models.Entities.MenuItem", "MenuItem")
                        .WithMany("OrderItems")
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RestaurantReservation.Db.Models.Entities.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MenuItem");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("RestaurantReservation.Db.Models.Entities.Reservation", b =>
                {
                    b.HasOne("RestaurantReservation.Db.Models.Entities.Customer", "Customer")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RestaurantReservation.Db.Models.Entities.Restaurant", "Restaurant")
                        .WithMany("Reservations")
                        .HasForeignKey("RestaurantId");

                    b.HasOne("RestaurantReservation.Db.Models.Entities.Table", "Table")
                        .WithMany("Reservations")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Customer");

                    b.Navigation("Restaurant");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("RestaurantReservation.Db.Models.Entities.Table", b =>
                {
                    b.HasOne("RestaurantReservation.Db.Models.Entities.Restaurant", "Restaurant")
                        .WithMany("Tables")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("RestaurantReservation.Db.Models.Entities.Customer", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("RestaurantReservation.Db.Models.Entities.Employee", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("RestaurantReservation.Db.Models.Entities.MenuItem", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("RestaurantReservation.Db.Models.Entities.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("RestaurantReservation.Db.Models.Entities.Reservation", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("RestaurantReservation.Db.Models.Entities.Restaurant", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("MenuItems");

                    b.Navigation("Reservations");

                    b.Navigation("Tables");
                });

            modelBuilder.Entity("RestaurantReservation.Db.Models.Entities.Table", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
