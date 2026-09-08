using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ajuste_sobre_los_datos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Firstname", "Lastname" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 9, 8, 17, 59, 33, 400, DateTimeKind.Unspecified).AddTicks(391), new TimeSpan(0, -3, 0, 0, 0)), "Maria", "Longoni" });

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_at",
                value: new DateTimeOffset(new DateTime(2026, 9, 8, 17, 59, 33, 400, DateTimeKind.Unspecified).AddTicks(473), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_at",
                value: new DateTimeOffset(new DateTime(2026, 9, 8, 17, 59, 33, 400, DateTimeKind.Unspecified).AddTicks(481), new TimeSpan(0, -3, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Firstname", "Lastname" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 9, 8, 17, 41, 0, 620, DateTimeKind.Unspecified).AddTicks(7346), new TimeSpan(0, -3, 0, 0, 0)), "Juan", "Pérez" });

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_at",
                value: new DateTimeOffset(new DateTime(2026, 9, 8, 17, 41, 0, 620, DateTimeKind.Unspecified).AddTicks(7393), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_at",
                value: new DateTimeOffset(new DateTime(2026, 9, 8, 17, 41, 0, 620, DateTimeKind.Unspecified).AddTicks(7397), new TimeSpan(0, -3, 0, 0, 0)));
        }
    }
}
