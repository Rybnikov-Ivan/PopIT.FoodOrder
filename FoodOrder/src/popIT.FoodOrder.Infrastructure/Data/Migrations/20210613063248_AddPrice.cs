using Microsoft.EntityFrameworkCore.Migrations;

namespace popIT.FoodOrder.Infrastructure.Data.Migrations
{
    public partial class AddPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Soups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Meats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Garnishes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Beverages",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Soups");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Meats");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Garnishes");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Beverages");
        }
    }
}
