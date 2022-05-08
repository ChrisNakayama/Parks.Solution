using Microsoft.EntityFrameworkCore.Migrations;

namespace Parks.Migrations
{
    public partial class Jellystone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "StateAndNatParks",
                keyColumn: "StateAndNatParkId",
                keyValue: 2,
                column: "Name",
                value: "Jellystone");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "StateAndNatParks",
                keyColumn: "StateAndNatParkId",
                keyValue: 2,
                column: "Name",
                value: "Yellowstone");
        }
    }
}
