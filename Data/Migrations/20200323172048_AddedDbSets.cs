using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AISvisualizer.Migrations
{
    public partial class AddedDbSets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "MessagesType21",
                columns: table => new
                {
                    MMSI = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageType = table.Column<string>(nullable: true),
                    Repeat = table.Column<short>(nullable: false),
                    AidType = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Accuracy = table.Column<string>(nullable: true),
                    Longitude = table.Column<double>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    DimensionToBow = table.Column<string>(nullable: true),
                    DimensionToStern = table.Column<string>(nullable: true),
                    DimensionToPort = table.Column<string>(nullable: true),
                    DimensionToStarboard = table.Column<string>(nullable: true),
                    EPFD = table.Column<string>(nullable: true),
                    Second = table.Column<string>(nullable: true),
                    OffPosition = table.Column<string>(nullable: true),
                    RAIM = table.Column<string>(nullable: true),
                    VirtualAidFlag = table.Column<string>(nullable: true),
                    Assigned = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessagesType21", x => x.MMSI);
                });

            migrationBuilder.CreateTable(
                name: "MessagesType4",
                columns: table => new
                {
                    MMSI = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageType = table.Column<string>(nullable: true),
                    Repeat = table.Column<short>(nullable: false),
                    Date = table.Column<DateTime>(nullable: true),
                    FixQuality = table.Column<string>(nullable: true),
                    Longitude = table.Column<double>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    EPFD = table.Column<string>(nullable: true),
                    RAIM = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessagesType4", x => x.MMSI);
                });

            migrationBuilder.CreateTable(
                name: "MessagesType5",
                columns: table => new
                {
                    MMSI = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageType = table.Column<string>(nullable: true),
                    Repeat = table.Column<short>(nullable: false),
                    AISversion = table.Column<string>(nullable: true),
                    IMOnumber = table.Column<long>(nullable: false),
                    CallSign = table.Column<string>(nullable: true),
                    VesselName = table.Column<string>(nullable: true),
                    ShipType = table.Column<string>(nullable: true),
                    DimensionToBow = table.Column<string>(nullable: true),
                    DimensionToStern = table.Column<string>(nullable: true),
                    DimensionToPort = table.Column<string>(nullable: true),
                    DimensionToStarboard = table.Column<string>(nullable: true),
                    EPFD = table.Column<string>(nullable: true),
                    Month = table.Column<short>(nullable: true),
                    Day = table.Column<short>(nullable: true),
                    Hour = table.Column<short>(nullable: true),
                    Minute = table.Column<short>(nullable: true),
                    Draught = table.Column<double>(nullable: false),
                    Destination = table.Column<string>(nullable: true),
                    DTE = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessagesType5", x => x.MMSI);
                });

            migrationBuilder.CreateTable(
                name: "MessagesType9",
                columns: table => new
                {
                    MMSI = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageType = table.Column<string>(nullable: true),
                    Repeat = table.Column<short>(nullable: false),
                    Altitude = table.Column<string>(nullable: true),
                    SOG = table.Column<double>(nullable: true),
                    Accuracy = table.Column<string>(nullable: true),
                    Longitude = table.Column<double>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    COG = table.Column<double>(nullable: true),
                    Timestamp = table.Column<string>(nullable: true),
                    DTE = table.Column<string>(nullable: true),
                    Assigned = table.Column<string>(nullable: true),
                    RAIM = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessagesType9", x => x.MMSI);
                });

            migrationBuilder.CreateTable(
                name: "MessagesType123",
                columns: table => new
                {
                    MMSI = table.Column<long>(nullable: false),
                    MessageType = table.Column<string>(nullable: true),
                    Repeat = table.Column<short>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    ROT = table.Column<short>(nullable: true),
                    SOG = table.Column<double>(nullable: true),
                    Accuracy = table.Column<string>(nullable: true),
                    Longitude = table.Column<double>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    COG = table.Column<double>(nullable: true),
                    HDG = table.Column<short>(nullable: true),
                    Timestamp = table.Column<string>(nullable: true),
                    Maneuver = table.Column<string>(nullable: true),
                    RAIM = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessagesType123", x => x.MMSI);
                    table.ForeignKey(
                        name: "FK_MessagesType123_MessagesType5_MMSI",
                        column: x => x.MMSI,
                        principalTable: "MessagesType5",
                        principalColumn: "MMSI",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MessagesType123");

            migrationBuilder.DropTable(
                name: "MessagesType21");

            migrationBuilder.DropTable(
                name: "MessagesType4");

            migrationBuilder.DropTable(
                name: "MessagesType9");

            migrationBuilder.DropTable(
                name: "MessagesType5");

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Accuracy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COG = table.Column<double>(type: "float", nullable: true),
                    HDG = table.Column<short>(type: "smallint", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    MMSI = table.Column<long>(type: "bigint", nullable: false),
                    Maneuver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RAIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ROT = table.Column<short>(type: "smallint", nullable: true),
                    Repeat = table.Column<short>(type: "smallint", nullable: false),
                    SOG = table.Column<double>(type: "float", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timestamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });
        }
    }
}
