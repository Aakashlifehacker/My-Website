using Microsoft.EntityFrameworkCore.Migrations;

namespace Zachariasz_Jankowski.Migrations
{
    public partial class NewModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "like",
                columns: table => new
                {
                    username = table.Column<string>(nullable: false),
                    post = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_like", x => new { x.username, x.post });
                });

            migrationBuilder.CreateTable(
                name: "posts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Time = table.Column<string>(nullable: true),
                    ProfilePhoto = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    content = table.Column<string>(nullable: true),
                    source = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    Likes = table.Column<int>(nullable: true),
                    type = table.Column<int>(nullable: false),
                    liked = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posts", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "like");

            migrationBuilder.DropTable(
                name: "posts");
        }
    }
}
