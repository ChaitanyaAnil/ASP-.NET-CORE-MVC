using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoMvcFruitShop.Migrations
{
    public partial class fruitcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fruit_Type",
                table: "Fruits");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Fruits",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Fruits");

            migrationBuilder.AddColumn<string>(
                name: "Fruit_Type",
                table: "Fruits",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
