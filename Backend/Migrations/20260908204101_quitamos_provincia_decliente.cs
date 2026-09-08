using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class quitamos_provincia_decliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Provincias_ProvinciaId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_ProvinciaId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ProvinciaId",
                table: "Clientes");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_at",
                value: new DateTimeOffset(new DateTime(2026, 9, 8, 17, 41, 0, 620, DateTimeKind.Unspecified).AddTicks(7346), new TimeSpan(0, -3, 0, 0, 0)));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProvinciaId",
                table: "Clientes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "ProvinciaId" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 9, 3, 16, 47, 3, 626, DateTimeKind.Unspecified).AddTicks(6941), new TimeSpan(0, -3, 0, 0, 0)), 1 });

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "ProvinciaId" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 9, 3, 16, 47, 3, 626, DateTimeKind.Unspecified).AddTicks(6993), new TimeSpan(0, -3, 0, 0, 0)), 3 });

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "ProvinciaId" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 9, 3, 16, 47, 3, 626, DateTimeKind.Unspecified).AddTicks(6997), new TimeSpan(0, -3, 0, 0, 0)), 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ProvinciaId",
                table: "Clientes",
                column: "ProvinciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Provincias_ProvinciaId",
                table: "Clientes",
                column: "ProvinciaId",
                principalTable: "Provincias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
