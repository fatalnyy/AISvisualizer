using Microsoft.EntityFrameworkCore.Migrations;

namespace AISvisualizer.Migrations
{
    public partial class ChangedColumnTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "Timestamp",
                table: "MessagesType9",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "DimensionToStern",
                table: "MessagesType5",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "DimensionToStarboard",
                table: "MessagesType5",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "DimensionToPort",
                table: "MessagesType5",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "DimensionToBow",
                table: "MessagesType5",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "Second",
                table: "MessagesType21",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "DimensionToStern",
                table: "MessagesType21",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "DimensionToStarboard",
                table: "MessagesType21",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "DimensionToPort",
                table: "MessagesType21",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "DimensionToBow",
                table: "MessagesType21",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "Timestamp",
                table: "MessagesType123",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "ROT",
                table: "MessagesType123",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Timestamp",
                table: "MessagesType9",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(short));

            migrationBuilder.AlterColumn<string>(
                name: "DimensionToStern",
                table: "MessagesType5",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(short));

            migrationBuilder.AlterColumn<string>(
                name: "DimensionToStarboard",
                table: "MessagesType5",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(short));

            migrationBuilder.AlterColumn<string>(
                name: "DimensionToPort",
                table: "MessagesType5",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(short));

            migrationBuilder.AlterColumn<string>(
                name: "DimensionToBow",
                table: "MessagesType5",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(short));

            migrationBuilder.AlterColumn<string>(
                name: "Second",
                table: "MessagesType21",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(short));

            migrationBuilder.AlterColumn<string>(
                name: "DimensionToStern",
                table: "MessagesType21",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(short));

            migrationBuilder.AlterColumn<string>(
                name: "DimensionToStarboard",
                table: "MessagesType21",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(short));

            migrationBuilder.AlterColumn<string>(
                name: "DimensionToPort",
                table: "MessagesType21",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(short));

            migrationBuilder.AlterColumn<string>(
                name: "DimensionToBow",
                table: "MessagesType21",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(short));

            migrationBuilder.AlterColumn<string>(
                name: "Timestamp",
                table: "MessagesType123",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(short));

            migrationBuilder.AlterColumn<short>(
                name: "ROT",
                table: "MessagesType123",
                type: "smallint",
                nullable: true,
                oldClrType: typeof(double),
                oldNullable: true);
        }
    }
}
