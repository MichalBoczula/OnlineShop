using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Web.Infrastructure.Migrations
{
    public partial class AddedMTMModelForOrderMobilePhonAndOrderApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationUserOrder",
                columns: table => new
                {
                    ApplicationUserId = table.Column<string>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    OrderRefId = table.Column<string>(nullable: true)
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
                        name: "FK_ApplicationUserOrder_Order_OrderRefId",
                        column: x => x.OrderRefId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderMobilePhone",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false),
                    MobilePhoneId = table.Column<int>(nullable: false),
                    OrderRefId = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderMobilePhone", x => new { x.OrderId, x.MobilePhoneId });
                    table.ForeignKey(
                        name: "FK_OrderMobilePhone_MobilePhones_MobilePhoneId",
                        column: x => x.MobilePhoneId,
                        principalTable: "MobilePhones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderMobilePhone_Order_OrderRefId",
                        column: x => x.OrderRefId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserOrder_OrderRefId",
                table: "ApplicationUserOrder",
                column: "OrderRefId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderMobilePhone_MobilePhoneId",
                table: "OrderMobilePhone",
                column: "MobilePhoneId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderMobilePhone_OrderRefId",
                table: "OrderMobilePhone",
                column: "OrderRefId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserOrder");

            migrationBuilder.DropTable(
                name: "OrderMobilePhone");
        }
    }
}
