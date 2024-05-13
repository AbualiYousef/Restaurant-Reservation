# Restaurant Reservation System

This repository hosts the `RestaurantReservation` system, a .NET 8 console application for managing restaurant reservations, orders, and employee data.

## Prerequisites

- .NET 8 SDK
- SQL Server Management Studio (SSMS)

## Setup Instructions

1. **Clone the Repository:
  ```
git clone [repository-url]
cd RestaurantReservation
  ```

2. **Database Setup:**
- Create a database named `RestaurantReservationCore` using SSMS.
- Apply EF Core migrations from the `RestaurantReservation.Db` project to set up and seed the database.

3. **Running the Application:**
- Navigate to the project directory and run the application:
  ```
  dotnet run
  ```

## Project Structure

- `RestaurantReservation`: Console application entry point.
- `RestaurantReservation.Db`: Library containing the DbContext, models, and repositories.

## Database Schema

Below is the schema for the `RestaurantReservation` database:

![Database Schema](images/database_schema.png)


## Implementation Details

- **CRUD Operations**: Methods for creating, updating, and deleting records.
- **Queries**: Functions for complex queries like listing managers or retrieving specific reservations.
- **Database Operations**: Includes views, functions, and stored procedures managed through EF Core.

## Version Control

- Make frequent commits with clear messages.
- Push to GitHub after completing tasks or phases.
