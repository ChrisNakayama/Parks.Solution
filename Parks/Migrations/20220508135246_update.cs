using Microsoft.EntityFrameworkCore.Migrations;

namespace Parks.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "StateAndNatParks",
                type: "varchar(13) CHARACTER SET utf8mb4",
                maxLength: 13,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "StateAndNatParks",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LocationByState",
                table: "StateAndNatParks",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "StateAndNatParks",
                keyColumn: "StateAndNatParkId",
                keyValue: 1,
                column: "Name",
                value: "Yosemite");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "StateAndNatParks",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(13) CHARACTER SET utf8mb4",
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "StateAndNatParks",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "LocationByState",
                table: "StateAndNatParks",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.UpdateData(
                table: "StateAndNatParks",
                keyColumn: "StateAndNatParkId",
                keyValue: 1,
                column: "Name",
                value: "Yosimite");
        }
    }
}
