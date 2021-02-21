using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Web.Infrastructure.Migrations
{
    public partial class ToAlliPhoneAddediOSAsSystem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hardware",
                keyColumn: "Id",
                keyValue: 23,
                column: "OperationSystem",
                value: "iOS");

            migrationBuilder.UpdateData(
                table: "Hardware",
                keyColumn: "Id",
                keyValue: 24,
                column: "OperationSystem",
                value: "iOS");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hardware",
                keyColumn: "Id",
                keyValue: 23,
                column: "OperationSystem",
                value: "Android");

            migrationBuilder.UpdateData(
                table: "Hardware",
                keyColumn: "Id",
                keyValue: 24,
                column: "OperationSystem",
                value: "Android");
        }
    }
}
