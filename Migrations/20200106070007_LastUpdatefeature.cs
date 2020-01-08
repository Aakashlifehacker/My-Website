using Microsoft.EntityFrameworkCore.Migrations;

namespace Zachariasz_Jankowski.Migrations
{
    public partial class LastUpdatefeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "project",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    remoteAddress = table.Column<string>(nullable: true),
                    daysAgo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_project", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "project");
        }
    }
}
