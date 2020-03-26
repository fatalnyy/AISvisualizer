using Microsoft.EntityFrameworkCore.Migrations;

namespace AISvisualizer.Migrations
{
    public partial class ChangedColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MessagesType1_MessagesType5_messageType5_id",
                table: "MessagesType1");

            migrationBuilder.RenameColumn(
                name: "messageType5_id",
                table: "MessagesType1",
                newName: "MessageType5_Id");

            migrationBuilder.RenameIndex(
                name: "IX_MessagesType1_messageType5_id",
                table: "MessagesType1",
                newName: "IX_MessagesType1_MessageType5_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MessagesType1_MessagesType5_MessageType5_Id",
                table: "MessagesType1",
                column: "MessageType5_Id",
                principalTable: "MessagesType5",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MessagesType1_MessagesType5_MessageType5_Id",
                table: "MessagesType1");

            migrationBuilder.RenameColumn(
                name: "MessageType5_Id",
                table: "MessagesType1",
                newName: "messageType5_id");

            migrationBuilder.RenameIndex(
                name: "IX_MessagesType1_MessageType5_Id",
                table: "MessagesType1",
                newName: "IX_MessagesType1_messageType5_id");

            migrationBuilder.AddForeignKey(
                name: "FK_MessagesType1_MessagesType5_messageType5_id",
                table: "MessagesType1",
                column: "messageType5_id",
                principalTable: "MessagesType5",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
