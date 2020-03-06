using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoMvcFruitShop.Migrations
{
    public partial class intialmode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fruits",
                columns: table => new
                {
                    Fruit_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fruit_Name = table.Column<string>(nullable: true),
                    Fruit_Type = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fruits", x => x.Fruit_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fruits");
        }
    }
}
