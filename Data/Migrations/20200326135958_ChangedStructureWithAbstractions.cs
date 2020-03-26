using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AISvisualizer.Migrations
{
    public partial class ChangedStructureWithAbstractions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MessagesType21",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: true),
                    MessageType = table.Column<string>(nullable: true),
                    Repeat = table.Column<short>(nullable: false),
                    MMSI = table.Column<long>(nullable: false),
                    Packet = table.Column<string>(nullable: true),
                    Channel = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    AidType = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Accuracy = table.Column<string>(nullable: true),
                    Longitude = table.Column<double>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    DimensionToBow = table.Column<short>(nullable: false),
                    DimensionToStern = table.Column<short>(nullable: false),
                    DimensionToPort = table.Column<short>(nullable: false),
                    DimensionToStarboard = table.Column<short>(nullable: false),
                    EPFD = table.Column<string>(nullable: true),
                    Second = table.Column<short>(nullable: false),
                    OffPosition = table.Column<string>(nullable: true),
                    Reserved = table.Column<short>(nullable: false),
                    Spare = table.Column<short>(nullable: false),
                    RAIM = table.Column<string>(nullable: true),
                    VirtualAidFlag = table.Column<string>(nullable: true),
                    Assigned = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessagesType21", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MessagesType4",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: true),
                    MessageType = table.Column<string>(nullable: true),
                    Repeat = table.Column<short>(nullable: false),
                    MMSI = table.Column<long>(nullable: false),
                    Packet = table.Column<string>(nullable: true),
                    Channel = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    FixQuality = table.Column<string>(nullable: true),
                    Longitude = table.Column<double>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    EPFD = table.Column<string>(nullable: true),
                    RAIM = table.Column<string>(nullable: true),
                    Spare = table.Column<short>(nullable: false),
                    RadioStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessagesType4", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MessagesType5",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: true),
                    MessageType = table.Column<string>(nullable: true),
                    Repeat = table.Column<short>(nullable: false),
                    MMSI = table.Column<long>(nullable: false),
                    Packet = table.Column<string>(nullable: true),
                    Channel = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    AISversion = table.Column<string>(nullable: true),
                    IMOnumber = table.Column<long>(nullable: false),
                    CallSign = table.Column<string>(nullable: true),
                    VesselName = table.Column<string>(nullable: true),
                    ShipType = table.Column<string>(nullable: true),
                    DimensionToBow = table.Column<short>(nullable: false),
                    DimensionToStern = table.Column<short>(nullable: false),
                    DimensionToPort = table.Column<short>(nullable: false),
                    DimensionToStarboard = table.Column<short>(nullable: false),
                    EPFD = table.Column<string>(nullable: true),
                    Month = table.Column<short>(nullable: true),
                    Day = table.Column<short>(nullable: true),
                    Hour = table.Column<short>(nullable: true),
                    Minute = table.Column<short>(nullable: true),
                    Draught = table.Column<double>(nullable: false),
                    Destination = table.Column<string>(nullable: true),
                    Spare = table.Column<short>(nullable: false),
                    DTE = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessagesType5", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MessagesType9",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: true),
                    MessageType = table.Column<string>(nullable: true),
                    Repeat = table.Column<short>(nullable: false),
                    MMSI = table.Column<long>(nullable: false),
                    Packet = table.Column<string>(nullable: true),
                    Channel = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Altitude = table.Column<string>(nullable: true),
                    SOG = table.Column<double>(nullable: true),
                    Accuracy = table.Column<string>(nullable: true),
                    Longitude = table.Column<double>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    COG = table.Column<double>(nullable: true),
                    Timestamp = table.Column<short>(nullable: false),
                    Reserved = table.Column<short>(nullable: false),
                    DTE = table.Column<string>(nullable: true),
                    Assigned = table.Column<string>(nullable: true),
                    RAIM = table.Column<string>(nullable: true),
                    Spare = table.Column<short>(nullable: false),
                    RadioStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessagesType9", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MessagesType1",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: true),
                    MessageType = table.Column<string>(nullable: true),
                    Repeat = table.Column<short>(nullable: false),
                    MMSI = table.Column<long>(nullable: false),
                    Packet = table.Column<string>(nullable: true),
                    Channel = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    ROT = table.Column<double>(nullable: true),
                    SOG = table.Column<double>(nullable: true),
                    Accuracy = table.Column<string>(nullable: true),
                    Longitude = table.Column<double>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    COG = table.Column<double>(nullable: true),
                    HDG = table.Column<short>(nullable: true),
                    Timestamp = table.Column<short>(nullable: false),
                    Maneuver = table.Column<string>(nullable: true),
                    Spare = table.Column<short>(nullable: false),
                    RAIM = table.Column<string>(nullable: true),
                    RadioStatus = table.Column<int>(nullable: false),
                    messageType5_id = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessagesType1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MessagesType1_MessagesType5_messageType5_id",
                        column: x => x.messageType5_id,
                        principalTable: "MessagesType5",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MessagesType1_messageType5_id",
                table: "MessagesType1",
                column: "messageType5_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MessagesType1");

            migrationBuilder.DropTable(
                name: "MessagesType21");

            migrationBuilder.DropTable(
                name: "MessagesType4");

            migrationBuilder.DropTable(
                name: "MessagesType9");

            migrationBuilder.DropTable(
                name: "MessagesType5");
        }
    }
}
