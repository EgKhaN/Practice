using Microsoft.EntityFrameworkCore.Migrations;

namespace Alıştırma.Migrations
{
    public partial class SeedTickets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Description 1", "Title 1 *Seed" },
                    { 2, "Description 2", "Title 2 *Seed" },
                    { 3, "Description 3", "Title 3 *Seed" },
                    { 4, "Description 4", "Title 4 *Seed" },
                    { 5, "Description 5", "Title 5 *Seed" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
