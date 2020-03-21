using Microsoft.EntityFrameworkCore.Migrations;

namespace AISvisualizer.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageType = table.Column<string>(nullable: true),
                    Repeat = table.Column<short>(nullable: false),
                    MMSI = table.Column<long>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    ROT = table.Column<short>(nullable: true),
                    SOG = table.Column<double>(nullable: true),
                    Accuracy = table.Column<string>(nullable: true),
                    Longitude = table.Column<double>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    COG = table.Column<double>(nullable: true),
                    HDG = table.Column<short>(nullable: true),
                    Timestamp = table.Column<string>(nullable: true),
                    Manuever = table.Column<string>(nullable: true),
                    RAIM = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");
        }
    }
}
