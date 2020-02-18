using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Market.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    iId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(maxLength: 30, nullable: false),
                    Itemprice = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.iId);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "Date", nullable: true),
                    ArrDate = table.Column<DateTime>(type: "Date", nullable: false),
                    iId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OId);
                    table.ForeignKey(
                        name: "FK_Order_Item_iId",
                        column: x => x.iId,
                        principalTable: "Item",
                        principalColumn: "iId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_iId",
                table: "Order",
                column: "iId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Item");
        }
    }
}
