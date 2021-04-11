using Microsoft.EntityFrameworkCore.Migrations;

namespace Bounce.Migrations
{
    public partial class Player : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "TotalGames",
                table: "Players");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalGames",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
