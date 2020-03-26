using Microsoft.EntityFrameworkCore.Migrations;

namespace AISvisualizer.Migrations
{
    public partial class AddedColumnsdoMessageType4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<short>(
                name: "Day",
                table: "MessagesType4",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "Hour",
                table: "MessagesType4",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "Minute",
                table: "MessagesType4",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "Month",
                table: "MessagesType4",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "Second",
                table: "MessagesType4",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "Year",
                table: "MessagesType4",
                nullable: false,
                defaultValue: (short)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Day",
                table: "MessagesType4");

            migrationBuilder.DropColumn(
                name: "Hour",
                table: "MessagesType4");

            migrationBuilder.DropColumn(
                name: "Minute",
                table: "MessagesType4");

            migrationBuilder.DropColumn(
                name: "Month",
                table: "MessagesType4");

            migrationBuilder.DropColumn(
                name: "Second",
                table: "MessagesType4");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "MessagesType4");
        }
    }
}
