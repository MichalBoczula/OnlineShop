using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Infrastructure.Migrations
{
    public partial class ModifiedMobilePhoneEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThirdImage",
                table: "MobilePhones");

            migrationBuilder.AlterColumn<long>(
                name: "BatteryCapacity",
                table: "Hardwares",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ThirdImage",
                table: "MobilePhones",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BatteryCapacity",
                table: "Hardwares",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));
        }
    }
}
