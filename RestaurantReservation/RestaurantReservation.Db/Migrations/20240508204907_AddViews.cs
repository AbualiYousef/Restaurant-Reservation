using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Db.Migrations
{
    /// <inheritdoc />
    public partial class AddViews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 5, 7, 23, 49, 6, 780, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 5, 6, 23, 49, 6, 780, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2024, 5, 5, 23, 49, 6, 780, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2024, 5, 4, 23, 49, 6, 780, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2024, 5, 3, 23, 49, 6, 780, DateTimeKind.Local).AddTicks(7299));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 5, 7, 23, 34, 20, 424, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 5, 6, 23, 34, 20, 424, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2024, 5, 5, 23, 34, 20, 424, DateTimeKind.Local).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2024, 5, 4, 23, 34, 20, 424, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2024, 5, 3, 23, 34, 20, 424, DateTimeKind.Local).AddTicks(9618));
        }
    }
}
