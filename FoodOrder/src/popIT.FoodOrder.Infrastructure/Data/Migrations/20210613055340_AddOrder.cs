using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace popIT.FoodOrder.Infrastructure.Data.Migrations
{
    public partial class AddOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentTicket = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentTicket);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsСompleted = table.Column<bool>(type: "bit", nullable: false),
                    BeverageId = table.Column<int>(type: "int", nullable: false),
                    GarnishId = table.Column<int>(type: "int", nullable: false),
                    MeatId = table.Column<int>(type: "int", nullable: false),
                    SoupId = table.Column<int>(type: "int", nullable: false),
                    StudentTicket = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Beverages_BeverageId",
                        column: x => x.BeverageId,
                        principalTable: "Beverages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Garnishes_GarnishId",
                        column: x => x.GarnishId,
                        principalTable: "Garnishes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Meats_MeatId",
                        column: x => x.MeatId,
                        principalTable: "Meats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Soups_SoupId",
                        column: x => x.SoupId,
                        principalTable: "Soups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Students_StudentTicket",
                        column: x => x.StudentTicket,
                        principalTable: "Students",
                        principalColumn: "StudentTicket",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BeverageId",
                table: "Orders",
                column: "BeverageId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_GarnishId",
                table: "Orders",
                column: "GarnishId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_MeatId",
                table: "Orders",
                column: "MeatId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SoupId",
                table: "Orders",
                column: "SoupId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StudentTicket",
                table: "Orders",
                column: "StudentTicket");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
