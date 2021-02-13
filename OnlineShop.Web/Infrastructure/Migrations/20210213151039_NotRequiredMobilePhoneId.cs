using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Web.Infrastructure.Migrations
{
    public partial class NotRequiredMobilePhoneId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MobilePhones_Multimedia_MultimediaId",
                table: "MobilePhones");

            migrationBuilder.AlterColumn<int>(
                name: "MultimediaId",
                table: "MobilePhones",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_MobilePhones_Multimedia_MultimediaId",
                table: "MobilePhones",
                column: "MultimediaId",
                principalTable: "Multimedia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MobilePhones_Multimedia_MultimediaId",
                table: "MobilePhones");

            migrationBuilder.AlterColumn<int>(
                name: "MultimediaId",
                table: "MobilePhones",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MobilePhones_Multimedia_MultimediaId",
                table: "MobilePhones",
                column: "MultimediaId",
                principalTable: "Multimedia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
