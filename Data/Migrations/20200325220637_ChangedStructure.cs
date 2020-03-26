using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AISvisualizer.Migrations
{
    public partial class ChangedStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MessagesType21",
                columns: table => new
                {
                    MMSI = table.Column<long>(type: "bigint", nullable: false),
                    Accuracy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AidType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Assigned = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Channel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DimensionToBow = table.Column<short>(type: "smallint", nullable: false),
                    DimensionToPort = table.Column<short>(type: "smallint", nullable: false),
                    DimensionToStarboard = table.Column<short>(type: "smallint", nullable: false),
                    DimensionToStern = table.Column<short>(type: "smallint", nullable: false),
                    EPFD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    MessageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OffPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Packet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RAIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Repeat = table.Column<short>(type: "smallint", nullable: false),
                    Second = table.Column<short>(type: "smallint", nullable: false),
                    VirtualAidFlag = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessagesType21", x => x.MMSI);
                });

            migrationBuilder.CreateTable(
                name: "MessagesType4",
                columns: table => new
                {
                    MMSI = table.Column<long>(type: "bigint", nullable: false),
                    Channel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EPFD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FixQuality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    MessageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Packet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RAIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Repeat = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessagesType4", x => x.MMSI);
                });

            migrationBuilder.CreateTable(
                name: "MessagesType5",
                columns: table => new
                {
                    MMSI = table.Column<long>(type: "bigint", nullable: false),
                    AISversion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CallSign = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Channel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DTE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day = table.Column<short>(type: "smallint", nullable: true),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DimensionToBow = table.Column<short>(type: "smallint", nullable: false),
                    DimensionToPort = table.Column<short>(type: "smallint", nullable: false),
                    DimensionToStarboard = table.Column<short>(type: "smallint", nullable: false),
                    DimensionToStern = table.Column<short>(type: "smallint", nullable: false),
                    Draught = table.Column<double>(type: "float", nullable: false),
                    EPFD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hour = table.Column<short>(type: "smallint", nullable: true),
                    IMOnumber = table.Column<long>(type: "bigint", nullable: false),
                    MessageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Minute = table.Column<short>(type: "smallint", nullable: true),
                    Month = table.Column<short>(type: "smallint", nullable: true),
                    Packet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Repeat = table.Column<short>(type: "smallint", nullable: false),
                    ShipType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VesselName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessagesType5", x => x.MMSI);
                });

            migrationBuilder.CreateTable(
                name: "MessagesType9",
                columns: table => new
                {
                    MMSI = table.Column<long>(type: "bigint", nullable: false),
                    Accuracy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Altitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Assigned = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COG = table.Column<double>(type: "float", nullable: true),
                    Channel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DTE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    MessageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Packet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RAIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Repeat = table.Column<short>(type: "smallint", nullable: false),
                    SOG = table.Column<double>(type: "float", nullable: true),
                    Timestamp = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessagesType9", x => x.MMSI);
                });

            migrationBuilder.CreateTable(
                name: "MessagesType123",
                columns: table => new
                {
                    MMSI = table.Column<long>(type: "bigint", nullable: false),
                    Accuracy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COG = table.Column<double>(type: "float", nullable: true),
                    Channel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HDG = table.Column<short>(type: "smallint", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    Maneuver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Packet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RAIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ROT = table.Column<double>(type: "float", nullable: true),
                    Repeat = table.Column<short>(type: "smallint", nullable: false),
                    SOG = table.Column<double>(type: "float", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timestamp = table.Column<short>(type: "smallint", nullable: false)
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
    }
}
