using Microsoft.EntityFrameworkCore.Migrations;

namespace TreeStructure.NET.Data.Migrations
{
    public partial class AddNode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Node",
                columns: table => new
                {
                    NodeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RootNodeId = table.Column<int>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Node", x => x.NodeId);
                    table.ForeignKey(
                        name: "FK_Node_Node_RootNodeId",
                        column: x => x.RootNodeId,
                        principalTable: "Node",
                        principalColumn: "NodeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Node_RootNodeId",
                table: "Node",
                column: "RootNodeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Node");
        }
    }
}
