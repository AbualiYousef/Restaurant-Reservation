using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Db.Migrations
{
    /// <inheritdoc />
    public partial class AddFindCustomersWithPartySizeStoredProcedure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"CREATE PROCEDURE sp_FindCustomersWithPartySize
                    @PartySize INT
                AS
                BEGIN
                     SELECT DISTINCT c.*
                     FROM Customers c
                     JOIN Reservations r ON c.Id = r.CustomerId
                     WHERE r.PartySize > @PartySize
                END");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROCEDURE sp_FindCustomersWithPartySize");
        }
    }
}
