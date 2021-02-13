using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Web.Infrastructure.Migrations
{
    public partial class AddedQuantitytoShoppingCartMobilePhoneEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartMobilePhone_MobilePhones_MobilePhoneId",
                table: "ShoppingCartMobilePhone");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartMobilePhone_ShoppingCart_ShoppingCartId",
                table: "ShoppingCartMobilePhone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCartMobilePhone",
                table: "ShoppingCartMobilePhone");

            migrationBuilder.RenameTable(
                name: "ShoppingCartMobilePhone",
                newName: "ShoppingCartMobilePhones");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartMobilePhone_MobilePhoneId",
                table: "ShoppingCartMobilePhones",
                newName: "IX_ShoppingCartMobilePhones_MobilePhoneId");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "ShoppingCartMobilePhones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCartMobilePhones",
                table: "ShoppingCartMobilePhones",
                columns: new[] { "ShoppingCartId", "MobilePhoneId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartMobilePhones_MobilePhones_MobilePhoneId",
                table: "ShoppingCartMobilePhones",
                column: "MobilePhoneId",
                principalTable: "MobilePhones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartMobilePhones_ShoppingCart_ShoppingCartId",
                table: "ShoppingCartMobilePhones",
                column: "ShoppingCartId",
                principalTable: "ShoppingCart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartMobilePhones_MobilePhones_MobilePhoneId",
                table: "ShoppingCartMobilePhones");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartMobilePhones_ShoppingCart_ShoppingCartId",
                table: "ShoppingCartMobilePhones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCartMobilePhones",
                table: "ShoppingCartMobilePhones");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ShoppingCartMobilePhones");

            migrationBuilder.RenameTable(
                name: "ShoppingCartMobilePhones",
                newName: "ShoppingCartMobilePhone");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartMobilePhones_MobilePhoneId",
                table: "ShoppingCartMobilePhone",
                newName: "IX_ShoppingCartMobilePhone_MobilePhoneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCartMobilePhone",
                table: "ShoppingCartMobilePhone",
                columns: new[] { "ShoppingCartId", "MobilePhoneId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartMobilePhone_MobilePhones_MobilePhoneId",
                table: "ShoppingCartMobilePhone",
                column: "MobilePhoneId",
                principalTable: "MobilePhones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartMobilePhone_ShoppingCart_ShoppingCartId",
                table: "ShoppingCartMobilePhone",
                column: "ShoppingCartId",
                principalTable: "ShoppingCart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
