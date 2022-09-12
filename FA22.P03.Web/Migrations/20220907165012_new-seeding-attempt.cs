using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA22.P03.Web.Migrations
{
    public partial class newseedingattempt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "Nintendo's retro console loved thoughout the ages", "Nintendo 64" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "Donkey Kong 64 cartridge for the N64", "Donkey Kong 64" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "Ocarina of Time cartridge for the N64", "Legend of Zelda: Ocarina of Time" });
        }
    }
}
