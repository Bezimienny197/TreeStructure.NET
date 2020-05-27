using Microsoft.EntityFrameworkCore.Migrations;

namespace TreeStructure.NET.Data.Migrations
{
    public partial class ChangeNode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Node_Node_RootNodeId",
                table: "Node");

            migrationBuilder.DropIndex(
                name: "IX_Node_RootNodeId",
                table: "Node");

            migrationBuilder.DropColumn(
                name: "RootNodeId",
                table: "Node");

            migrationBuilder.AddColumn<int>(
                name: "RootId",
                table: "Node",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RootId",
                table: "Node");

            migrationBuilder.AddColumn<int>(
                name: "RootNodeId",
                table: "Node",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Node_RootNodeId",
                table: "Node",
                column: "RootNodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Node_Node_RootNodeId",
                table: "Node",
                column: "RootNodeId",
                principalTable: "Node",
                principalColumn: "NodeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
