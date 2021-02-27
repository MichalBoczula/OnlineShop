using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Web.Infrastructure.Migrations
{
    public partial class OrderModelsDone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_ShippingAddress_ShippingAddressId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_ShippingAddress_AspNetUsers_ApplicationUserId",
                table: "ShippingAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShippingAddress",
                table: "ShippingAddress");

            migrationBuilder.RenameTable(
                name: "ShippingAddress",
                newName: "ShippingAddresses");

            migrationBuilder.RenameIndex(
                name: "IX_ShippingAddress_ApplicationUserId",
                table: "ShippingAddresses",
                newName: "IX_ShippingAddresses_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShippingAddresses",
                table: "ShippingAddresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_ShippingAddresses_ShippingAddressId",
                table: "Orders",
                column: "ShippingAddressId",
                principalTable: "ShippingAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShippingAddresses_AspNetUsers_ApplicationUserId",
                table: "ShippingAddresses",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_ShippingAddresses_ShippingAddressId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_ShippingAddresses_AspNetUsers_ApplicationUserId",
                table: "ShippingAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShippingAddresses",
                table: "ShippingAddresses");

            migrationBuilder.RenameTable(
                name: "ShippingAddresses",
                newName: "ShippingAddress");

            migrationBuilder.RenameIndex(
                name: "IX_ShippingAddresses_ApplicationUserId",
                table: "ShippingAddress",
                newName: "IX_ShippingAddress_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShippingAddress",
                table: "ShippingAddress",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_ShippingAddress_ShippingAddressId",
                table: "Orders",
                column: "ShippingAddressId",
                principalTable: "ShippingAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShippingAddress_AspNetUsers_ApplicationUserId",
                table: "ShippingAddress",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
