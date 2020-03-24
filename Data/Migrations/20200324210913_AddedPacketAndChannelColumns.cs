using Microsoft.EntityFrameworkCore.Migrations;

namespace AISvisualizer.Migrations
{
    public partial class AddedPacketAndChannelColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Channel",
                table: "MessagesType9",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Packet",
                table: "MessagesType9",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Channel",
                table: "MessagesType5",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Packet",
                table: "MessagesType5",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Channel",
                table: "MessagesType4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Packet",
                table: "MessagesType4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Channel",
                table: "MessagesType21",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Packet",
                table: "MessagesType21",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Channel",
                table: "MessagesType123",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Packet",
                table: "MessagesType123",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Channel",
                table: "MessagesType9");

            migrationBuilder.DropColumn(
                name: "Packet",
                table: "MessagesType9");

            migrationBuilder.DropColumn(
                name: "Channel",
                table: "MessagesType5");

            migrationBuilder.DropColumn(
                name: "Packet",
                table: "MessagesType5");

            migrationBuilder.DropColumn(
                name: "Channel",
                table: "MessagesType4");

            migrationBuilder.DropColumn(
                name: "Packet",
                table: "MessagesType4");

            migrationBuilder.DropColumn(
                name: "Channel",
                table: "MessagesType21");

            migrationBuilder.DropColumn(
                name: "Packet",
                table: "MessagesType21");

            migrationBuilder.DropColumn(
                name: "Channel",
                table: "MessagesType123");

            migrationBuilder.DropColumn(
                name: "Packet",
                table: "MessagesType123");
        }
    }
}
