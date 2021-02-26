using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Web.Infrastructure.Migrations
{
    public partial class UpdatedOrderModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_AspNetUsers_ApplicationUserId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_ShippingAddress_ShippingAddressId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderMobilePhone_MobilePhones_MobilePhoneId",
                table: "OrderMobilePhone");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderMobilePhone_Order_OrderId",
                table: "OrderMobilePhone");

            migrationBuilder.DropTable(
                name: "ApplicationUserOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderMobilePhone",
                table: "OrderMobilePhone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.RenameTable(
                name: "OrderMobilePhone",
                newName: "OrderMobilePhones");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameIndex(
                name: "IX_OrderMobilePhone_MobilePhoneId",
                table: "OrderMobilePhones",
                newName: "IX_OrderMobilePhones_MobilePhoneId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_ShippingAddressId",
                table: "Orders",
                newName: "IX_Orders_ShippingAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_ApplicationUserId",
                table: "Orders",
                newName: "IX_Orders_ApplicationUserId");

            migrationBuilder.AddColumn<string>(
                name: "OrderNumber",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderMobilePhones",
                table: "OrderMobilePhones",
                columns: new[] { "OrderId", "MobilePhoneId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderMobilePhones_MobilePhones_MobilePhoneId",
                table: "OrderMobilePhones",
                column: "MobilePhoneId",
                principalTable: "MobilePhones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderMobilePhones_Orders_OrderId",
                table: "OrderMobilePhones",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_ApplicationUserId",
                table: "Orders",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_ShippingAddress_ShippingAddressId",
                table: "Orders",
                column: "ShippingAddressId",
                principalTable: "ShippingAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderMobilePhones_MobilePhones_MobilePhoneId",
                table: "OrderMobilePhones");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderMobilePhones_Orders_OrderId",
                table: "OrderMobilePhones");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_ApplicationUserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_ShippingAddress_ShippingAddressId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderMobilePhones",
                table: "OrderMobilePhones");

            migrationBuilder.DropColumn(
                name: "OrderNumber",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "OrderMobilePhones",
                newName: "OrderMobilePhone");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ShippingAddressId",
                table: "Order",
                newName: "IX_Order_ShippingAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ApplicationUserId",
                table: "Order",
                newName: "IX_Order_ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderMobilePhones_MobilePhoneId",
                table: "OrderMobilePhone",
                newName: "IX_OrderMobilePhone_MobilePhoneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderMobilePhone",
                table: "OrderMobilePhone",
                columns: new[] { "OrderId", "MobilePhoneId" });

            migrationBuilder.CreateTable(
                name: "ApplicationUserOrder",
                columns: table => new
                {
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserOrder", x => new { x.ApplicationUserId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserOrder_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserOrder_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserOrder_OrderId",
                table: "ApplicationUserOrder",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AspNetUsers_ApplicationUserId",
                table: "Order",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_ShippingAddress_ShippingAddressId",
                table: "Order",
                column: "ShippingAddressId",
                principalTable: "ShippingAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderMobilePhone_MobilePhones_MobilePhoneId",
                table: "OrderMobilePhone",
                column: "MobilePhoneId",
                principalTable: "MobilePhones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderMobilePhone_Order_OrderId",
                table: "OrderMobilePhone",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
