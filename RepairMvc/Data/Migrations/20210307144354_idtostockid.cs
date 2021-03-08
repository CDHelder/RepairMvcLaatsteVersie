using Microsoft.EntityFrameworkCore.Migrations;

namespace RepairMvc.Data.Migrations
{
    public partial class idtostockid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_Part1ProductId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_Part2ProductId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_Part3ProductId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_Part4ProductId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_Part5ProductId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_Part6ProductId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_Part7ProductId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_Part8ProductId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_Part1ProductId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_Part2ProductId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_Part3ProductId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_Part4ProductId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_Part5ProductId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_Part6ProductId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_Part7ProductId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_Part8ProductId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Part1ProductId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Part1Quantity",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Part2ProductId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Part2Quantity",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Part3ProductId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Part3Quantity",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Part4ProductId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Part4Quantity",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Part5ProductId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Part5Quantity",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Part6ProductId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Part6Quantity",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Part7ProductId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Part7Quantity",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Part8ProductId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Part8Quantity",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PartID1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PartID2",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PartID3",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PartID4",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PartID5",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PartID6",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PartID7",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PartID8",
                table: "Orders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Part1ProductId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Part1Quantity",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Part2ProductId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Part2Quantity",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Part3ProductId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Part3Quantity",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Part4ProductId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Part4Quantity",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Part5ProductId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Part5Quantity",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Part6ProductId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Part6Quantity",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Part7ProductId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Part7Quantity",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Part8ProductId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Part8Quantity",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PartID1",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PartID2",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PartID3",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PartID4",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PartID5",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PartID6",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PartID7",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PartID8",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Part1ProductId",
                table: "Orders",
                column: "Part1ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Part2ProductId",
                table: "Orders",
                column: "Part2ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Part3ProductId",
                table: "Orders",
                column: "Part3ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Part4ProductId",
                table: "Orders",
                column: "Part4ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Part5ProductId",
                table: "Orders",
                column: "Part5ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Part6ProductId",
                table: "Orders",
                column: "Part6ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Part7ProductId",
                table: "Orders",
                column: "Part7ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Part8ProductId",
                table: "Orders",
                column: "Part8ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_Part1ProductId",
                table: "Orders",
                column: "Part1ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_Part2ProductId",
                table: "Orders",
                column: "Part2ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_Part3ProductId",
                table: "Orders",
                column: "Part3ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_Part4ProductId",
                table: "Orders",
                column: "Part4ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_Part5ProductId",
                table: "Orders",
                column: "Part5ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_Part6ProductId",
                table: "Orders",
                column: "Part6ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_Part7ProductId",
                table: "Orders",
                column: "Part7ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_Part8ProductId",
                table: "Orders",
                column: "Part8ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
