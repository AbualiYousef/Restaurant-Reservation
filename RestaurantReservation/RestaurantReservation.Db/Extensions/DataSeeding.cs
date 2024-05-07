using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Models.Entities;
using RestaurantReservation.Db.Models.Enums;

namespace RestaurantReservation.Db.Extensions;

public static class DataSeeding
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().HasData(GetCustomers());
        modelBuilder.Entity<Employee>().HasData(GetEmployees());
        modelBuilder.Entity<MenuItem>().HasData(GetMenuItems());
        modelBuilder.Entity<Order>().HasData(GetOrders());
        modelBuilder.Entity<OrderItem>().HasData(GetOrderItems());
        modelBuilder.Entity<Reservation>().HasData(GetReservations());
        modelBuilder.Entity<Restaurant>().HasData(GetRestaurants());
        modelBuilder.Entity<Table>().HasData(GetTables());
    }

    private static List<Customer> GetCustomers()
    {
        return new List<Customer>
        {
            new Customer
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "John.doe@example.com",
                PhoneNumber = "123-456-7890"
            },
            new Customer
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Doe",
                Email = "Jane.doe@example.com",
                PhoneNumber = "987-654-3210"
            },
            new Customer
            {
                Id = 3,
                FirstName = "Alice",
                LastName = "Smith",
                Email = "Alice.smith@example.com",
                PhoneNumber = "555-123-4567"
            },
            new Customer
            {
                Id = 4,
                FirstName = "Bob",
                LastName = "Smith",
                Email = "Bob.smith@example.com",
                PhoneNumber = "555-987-6543"
            },
            new Customer
            {
                Id = 5,
                FirstName = "Charlie",
                LastName = "Brown",
                Email = "Charlie.brown@example.com",
                PhoneNumber = "555-555-5555"
            }
        };
    }

    private static List<Employee> GetEmployees()
    {
        return new List<Employee>
        {
            new Employee
            {
                Id = 1,
                FirstName = "Ella",
                LastName = "Fitzgerald",
                Position = EmployeePosition.Manager,
                RestaurantId = 1
            },
            new Employee
            {
                Id = 2,
                FirstName = "Louis",
                LastName = "Armstrong",
                Position = EmployeePosition.Chef,
                RestaurantId = 1
            },
            new Employee
            {
                Id = 3,
                FirstName = "Billie",
                LastName = "Holiday",
                Position = EmployeePosition.Waiter,
                RestaurantId = 1
            },
            new Employee
            {
                Id = 4,
                FirstName = "Charlie",
                LastName = "Parker",
                Position = EmployeePosition.Cashier,
                RestaurantId = 2
            },
            new Employee
            {
                Id = 5,
                FirstName = "Dizzy",
                LastName = "Gillespie",
                Position = EmployeePosition.Waiter,
                RestaurantId = 2
            }
        };
    }

    private static List<MenuItem> GetMenuItems()
    {
        return new List<MenuItem>
        {
            new MenuItem
            {
                Id = 1,
                Name = "Classic Burger",
                Description = "A juicy beef patty with lettuce, tomato, and our special sauce.",
                Price = 8.99m,
                RestaurantId = 1
            },
            new MenuItem
            {
                Id = 2,
                Name = "Veggie Burger",
                Description = "A delicious and hearty vegetarian burger loaded with fresh vegetables.",
                Price = 9.50m,
                RestaurantId = 1
            },
            new MenuItem
            {
                Id = 3,
                Name = "Chicken Caesar Salad",
                Description = "Crisp romaine lettuce with grilled chicken breast, shaved parmesan, and croutons.",
                Price = 7.75m,
                RestaurantId = 2
            },
            new MenuItem
            {
                Id = 4,
                Name = "Margherita Pizza",
                Description = "Classic pizza with fresh mozzarella, tomatoes, and basil.",
                Price = 12.00m,
                RestaurantId = 2
            },
            new MenuItem
            {
                Id = 5,
                Name = "Pasta Carbonara",
                Description = "Creamy pasta with pancetta, parmesan cheese, and a touch of egg.",
                Price = 11.00m,
                RestaurantId = 3
            }
        };
    }

    private static List<Order> GetOrders()
    {
        return new List<Order>
        {
            new Order
            {
                Id = 1,
                OrderDate = DateTime.Now.AddDays(-1),
                TotalAmount = 45,
                EmployeeId = 5,
                ReservationId = 1
            },
            new Order
            {
                Id = 2,
                OrderDate = DateTime.Now.AddDays(-2),
                TotalAmount = 30,
                EmployeeId = 3,
                ReservationId = 2
            },
            new Order
            {
                Id = 3,
                OrderDate = DateTime.Now.AddDays(-3),
                TotalAmount = 60,
                EmployeeId = 3,
                ReservationId = 3
            },
            new Order
            {
                Id = 4,
                OrderDate = DateTime.Now.AddDays(-4),
                TotalAmount = 22,
                EmployeeId = 5,
                ReservationId = 4
            },
            new Order
            {
                Id = 5,
                OrderDate = DateTime.Now.AddDays(-5),
                TotalAmount = 80,
                EmployeeId = 3,
                ReservationId = 5
            }
        };
    }

    private static List<OrderItem> GetOrderItems()
    {
        return new List<OrderItem>
        {
            new OrderItem
            {
                Id = 1,
                OrderId = 1,
                MenuItemId = 1,
                Quantity = 2
            },
            new OrderItem
            {
                Id = 2,
                OrderId = 1,
                MenuItemId = 2,
                Quantity = 1
            },
            new OrderItem
            {
                Id = 3,
                OrderId = 2,
                MenuItemId = 3,
                Quantity = 3
            },
            new OrderItem
            {
                Id = 4,
                OrderId = 2,
                MenuItemId = 4,
                Quantity = 1
            },
            new OrderItem
            {
                Id = 5,
                OrderId = 3,
                MenuItemId = 5,
                Quantity = 1
            },
            new OrderItem
            {
                Id = 6,
                OrderId = 3,
                MenuItemId = 1,
                Quantity = 2
            },
            new OrderItem
            {
                Id = 7,
                OrderId = 4,
                MenuItemId = 2,
                Quantity = 4
            },
            new OrderItem
            {
                Id = 8,
                OrderId = 4,
                MenuItemId = 3,
                Quantity = 2
            },
            new OrderItem
            {
                Id = 9,
                OrderId = 5,
                MenuItemId = 4,
                Quantity = 3
            },
            new OrderItem
            {
                Id = 10,
                OrderId = 5,
                MenuItemId = 5,
                Quantity = 1
            }
        };
    }

    private static List<Reservation> GetReservations()
    {
        return new List<Reservation>
        {
            new Reservation
            {
                Id = 1,
                ReservationDate = DateTime.Today.AddDays(3),
                PartySize = 4,
                CustomerId = 1,
                RestaurantId = 1,
                TableId = 1
            },
            new Reservation
            {
                Id = 2,
                ReservationDate = DateTime.Today.AddDays(4),
                PartySize = 2,
                CustomerId = 2,
                RestaurantId = 1,
                TableId = 2
            },
            new Reservation
            {
                Id = 3,
                ReservationDate = DateTime.Today.AddDays(5),
                PartySize = 6,
                CustomerId = 3,
                RestaurantId = 2,
                TableId = 3
            },
            new Reservation
            {
                Id = 4,
                ReservationDate = DateTime.Today.AddDays(6),
                PartySize = 3,
                CustomerId = 4,
                RestaurantId = 2,
                TableId = 4
            },
            new Reservation
            {
                Id = 5,
                ReservationDate = DateTime.Today.AddDays(7),
                PartySize = 5,
                CustomerId = 5,
                RestaurantId = 3,
                TableId = 5
            }
        };
    }

    private static List<Restaurant> GetRestaurants()
    {
        return new List<Restaurant>
        {
            new Restaurant
            {
                Id = 1,
                Name = "Gourmet Hub",
                Address = "1234 Culinary Blvd, Foodie Town",
                PhoneNumber = "555-1234",
                openingHours = "9:00 AM - 11:00 PM"
            },
            new Restaurant
            {
                Id = 2,
                Name = "The Italian Corner",
                Address = "5678 Pasta Lane, Little Italy",
                PhoneNumber = "555-5678",
                openingHours = "11:00 AM - 10:00 PM"
            },
            new Restaurant
            {
                Id = 3,
                Name = "Sushi Sushi",
                Address = "135 Sushi St, Downtown",
                PhoneNumber = "555-1357",
                openingHours = "12:00 PM - 10:00 PM"
            },
            new Restaurant
            {
                Id = 4,
                Name = "Curry Leaf",
                Address = "2468 Curry Ave, Spice City",
                PhoneNumber = "555-2468",
                openingHours = "10:00 AM - 9:00 PM"
            },
            new Restaurant
            {
                Id = 5,
                Name = "The Burger Joint",
                Address = "7890 Burger Blvd, Greasy Corner",
                PhoneNumber = "555-7890",
                openingHours = "10:00 AM - 12:00 AM"
            }
        };
    }
    private static List<Table> GetTables()
    {
        return new List<Table>
        {
            new Table
            {
                Id = 1,
                Capacity = 4,
                RestaurantId = 1
            },
            new Table
            {
                Id = 2,
                Capacity = 2,
                RestaurantId = 1
            },
            new Table
            {
                Id = 3,
                Capacity = 6,
                RestaurantId = 2
            },
            new Table
            {
                Id = 4,
                Capacity = 4,
                RestaurantId = 2
            },
            new Table
            {
                Id = 5,
                Capacity = 8,
                RestaurantId = 3
            },
            new Table
            {
                Id = 6,
                Capacity = 4,
                RestaurantId = 3
            },
            new Table
            {
                Id = 7,
                Capacity = 4,
                RestaurantId = 4
            },
            new Table
            {
                Id = 8,
                Capacity = 2,
                RestaurantId = 4
            },
            new Table
            {
                Id = 9,
                Capacity = 4,
                RestaurantId = 5
            },
            new Table
            {
                Id = 10,
                Capacity = 6,
                RestaurantId = 5
            }
        };
    }
}