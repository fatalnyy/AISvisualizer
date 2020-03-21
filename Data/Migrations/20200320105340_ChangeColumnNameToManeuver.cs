using Microsoft.EntityFrameworkCore.Migrations;

namespace AISvisualizer.Migrations
{
    public partial class ChangeColumnNameToManeuver : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Manuever",
                table: "Messages");

            migrationBuilder.AddColumn<string>(
                name: "Maneuver",
                table: "Messages",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Maneuver",
                table: "Messages");

            migrationBuilder.AddColumn<string>(
                name: "Manuever",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
