using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Web.Infrastructure.Migrations
{
    public partial class AddedShoppingCartMobilePhoneRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cameras_MobilePhones_MobilePhoneId",
                table: "Cameras");

            migrationBuilder.DropForeignKey(
                name: "FK_Hardwares_MobilePhones_MobilePhoneId",
                table: "Hardwares");

            migrationBuilder.DropForeignKey(
                name: "FK_Screens_MobilePhones_MobilePhoneId",
                table: "Screens");

            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Screens",
                table: "Screens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hardwares",
                table: "Hardwares");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cameras",
                table: "Cameras");

            migrationBuilder.RenameTable(
                name: "Screens",
                newName: "Screen");

            migrationBuilder.RenameTable(
                name: "Hardwares",
                newName: "Hardware");

            migrationBuilder.RenameTable(
                name: "Cameras",
                newName: "Camera");

            migrationBuilder.RenameIndex(
                name: "IX_Screens_MobilePhoneId",
                table: "Screen",
                newName: "IX_Screen_MobilePhoneId");

            migrationBuilder.RenameIndex(
                name: "IX_Hardwares_MobilePhoneId",
                table: "Hardware",
                newName: "IX_Hardware_MobilePhoneId");

            migrationBuilder.RenameIndex(
                name: "IX_Cameras_MobilePhoneId",
                table: "Camera",
                newName: "IX_Camera_MobilePhoneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Screen",
                table: "Screen",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hardware",
                table: "Hardware",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Camera",
                table: "Camera",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ShoppingCartMobilePhone",
                columns: table => new
                {
                    ShoppingCartId = table.Column<int>(nullable: false),
                    MobilePhoneId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartMobilePhone", x => new { x.ShoppingCartId, x.MobilePhoneId });
                    table.ForeignKey(
                        name: "FK_ShoppingCartMobilePhone_MobilePhones_MobilePhoneId",
                        column: x => x.MobilePhoneId,
                        principalTable: "MobilePhones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCartMobilePhone_ShoppingCart_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartMobilePhone_MobilePhoneId",
                table: "ShoppingCartMobilePhone",
                column: "MobilePhoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Camera_MobilePhones_MobilePhoneId",
                table: "Camera",
                column: "MobilePhoneId",
                principalTable: "MobilePhones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hardware_MobilePhones_MobilePhoneId",
                table: "Hardware",
                column: "MobilePhoneId",
                principalTable: "MobilePhones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Screen_MobilePhones_MobilePhoneId",
                table: "Screen",
                column: "MobilePhoneId",
                principalTable: "MobilePhones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Camera_MobilePhones_MobilePhoneId",
                table: "Camera");

            migrationBuilder.DropForeignKey(
                name: "FK_Hardware_MobilePhones_MobilePhoneId",
                table: "Hardware");

            migrationBuilder.DropForeignKey(
                name: "FK_Screen_MobilePhones_MobilePhoneId",
                table: "Screen");

            migrationBuilder.DropTable(
                name: "ShoppingCartMobilePhone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Screen",
                table: "Screen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hardware",
                table: "Hardware");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Camera",
                table: "Camera");

            migrationBuilder.RenameTable(
                name: "Screen",
                newName: "Screens");

            migrationBuilder.RenameTable(
                name: "Hardware",
                newName: "Hardwares");

            migrationBuilder.RenameTable(
                name: "Camera",
                newName: "Cameras");

            migrationBuilder.RenameIndex(
                name: "IX_Screen_MobilePhoneId",
                table: "Screens",
                newName: "IX_Screens_MobilePhoneId");

            migrationBuilder.RenameIndex(
                name: "IX_Hardware_MobilePhoneId",
                table: "Hardwares",
                newName: "IX_Hardwares_MobilePhoneId");

            migrationBuilder.RenameIndex(
                name: "IX_Camera_MobilePhoneId",
                table: "Cameras",
                newName: "IX_Cameras_MobilePhoneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Screens",
                table: "Screens",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hardwares",
                table: "Hardwares",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cameras",
                table: "Cameras",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CartItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MobilePhoneId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItem_MobilePhones_MobilePhoneId",
                        column: x => x.MobilePhoneId,
                        principalTable: "MobilePhones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartItem_ShoppingCart_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MobilePhoneId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_MobilePhones_MobilePhoneId",
                        column: x => x.MobilePhoneId,
                        principalTable: "MobilePhones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_MobilePhoneId",
                table: "CartItem",
                column: "MobilePhoneId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_ShoppingCartId",
                table: "CartItem",
                column: "ShoppingCartId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_MobilePhoneId",
                table: "ShoppingCartItems",
                column: "MobilePhoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cameras_MobilePhones_MobilePhoneId",
                table: "Cameras",
                column: "MobilePhoneId",
                principalTable: "MobilePhones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hardwares_MobilePhones_MobilePhoneId",
                table: "Hardwares",
                column: "MobilePhoneId",
                principalTable: "MobilePhones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Screens_MobilePhones_MobilePhoneId",
                table: "Screens",
                column: "MobilePhoneId",
                principalTable: "MobilePhones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
