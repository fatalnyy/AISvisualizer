using Microsoft.EntityFrameworkCore.Migrations;

namespace AISvisualizer.Migrations
{
    public partial class RemovedForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MessagesType1_MessagesType5_MessageType5_Id",
                table: "MessagesType1");

            migrationBuilder.DropIndex(
                name: "IX_MessagesType1_MessageType5_Id",
                table: "MessagesType1");

            migrationBuilder.DropColumn(
                name: "MessageType5_Id",
                table: "MessagesType1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MessageType5_Id",
                table: "MessagesType1",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MessagesType1_MessageType5_Id",
                table: "MessagesType1",
                column: "MessageType5_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MessagesType1_MessagesType5_MessageType5_Id",
                table: "MessagesType1",
                column: "MessageType5_Id",
                principalTable: "MessagesType5",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
