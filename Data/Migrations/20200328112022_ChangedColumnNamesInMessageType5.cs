using Microsoft.EntityFrameworkCore.Migrations;

namespace AISvisualizer.Migrations
{
    public partial class ChangedColumnNamesInMessageType5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IMOnumber",
                table: "MessagesType5",
                newName: "ImoNumber");

            migrationBuilder.RenameColumn(
                name: "AISversion",
                table: "MessagesType5",
                newName: "AisVersion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImoNumber",
                table: "MessagesType5",
                newName: "IMOnumber");

            migrationBuilder.RenameColumn(
                name: "AisVersion",
                table: "MessagesType5",
                newName: "AISversion");
        }
    }
}
