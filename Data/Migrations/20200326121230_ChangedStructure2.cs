using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AISvisualizer.Migrations
{
    public partial class ChangedStructure2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MessagesType21",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Accuracy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AidType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Assigned = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Channel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DimensionToBow = table.Column<short>(type: "smallint", nullable: false),
                    DimensionToPort = table.Column<short>(type: "smallint", nullable: false),
                    DimensionToStarboard = table.Column<short>(type: "smallint", nullable: false),
                    DimensionToStern = table.Column<short>(type: "smallint", nullable: false),
                    EPFD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    MMSI = table.Column<long>(type: "bigint", nullable: false),
                    MessageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OffPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Packet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RAIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Repeat = table.Column<short>(type: "smallint", nullable: false),
                    Reserved = table.Column<short>(type: "smallint", nullable: false),
                    Second = table.Column<short>(type: "smallint", nullable: false),
                    Spare = table.Column<short>(type: "smallint", nullable: false),
                    VirtualAidFlag = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessagesType21", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MessagesType4",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Channel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EPFD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FixQuality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    MMSI = table.Column<long>(type: "bigint", nullable: false),
                    MessageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Packet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RAIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RadioStatus = table.Column<int>(type: "int", nullable: false),
                    Repeat = table.Column<short>(type: "smallint", nullable: false),
                    Spare = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessagesType4", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MessagesType5",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AISversion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CallSign = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Channel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DTE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    MMSI = table.Column<long>(type: "bigint", nullable: false),
                    MessageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Minute = table.Column<short>(type: "smallint", nullable: true),
                    Month = table.Column<short>(type: "smallint", nullable: true),
                    Packet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Repeat = table.Column<short>(type: "smallint", nullable: false),
                    ShipType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Spare = table.Column<short>(type: "smallint", nullable: false),
                    VesselName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessagesType5", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MessagesType9",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Accuracy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Altitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Assigned = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COG = table.Column<double>(type: "float", nullable: true),
                    Channel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DTE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    MMSI = table.Column<long>(type: "bigint", nullable: false),
                    MessageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Packet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RAIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RadioStatus = table.Column<int>(type: "int", nullable: false),
                    Repeat = table.Column<short>(type: "smallint", nullable: false),
                    Reserved = table.Column<short>(type: "smallint", nullable: false),
                    SOG = table.Column<double>(type: "float", nullable: true),
                    Spare = table.Column<short>(type: "smallint", nullable: false),
                    Timestamp = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessagesType9", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MessagesType1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Accuracy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COG = table.Column<double>(type: "float", nullable: true),
                    Channel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HDG = table.Column<short>(type: "smallint", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    MMSI = table.Column<long>(type: "bigint", nullable: false),
                    Maneuver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Packet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RAIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ROT = table.Column<double>(type: "float", nullable: true),
                    Repeat = table.Column<short>(type: "smallint", nullable: false),
                    SOG = table.Column<double>(type: "float", nullable: true),
                    Spare = table.Column<short>(type: "smallint", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timestamp = table.Column<short>(type: "smallint", nullable: false),
                    messageType5_id = table.Column<int>(type: "int", nullable: false)
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
    }
}
