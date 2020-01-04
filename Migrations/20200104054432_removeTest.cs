using Microsoft.EntityFrameworkCore.Migrations;

namespace Zachariasz_Jankowski.Migrations
{
    public partial class removeTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "test");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "test",
                columns: table => new
                {
                    username = table.Column<string>(type: "TEXT", nullable: false),
                    post = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_test", x => new { x.username, x.post });
                });
        }
    }
}
