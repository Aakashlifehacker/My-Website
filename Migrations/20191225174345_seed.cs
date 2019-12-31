using Microsoft.EntityFrameworkCore.Migrations;

namespace Zachariasz_Jankowski.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("posts",
                  new[] { "Time", "profilePhoto", "Username", "content", "source", "Likes", "type", "Photo" },
                  new object[] { "03.12.2019", "/Posts/profiles/instagram.jpg", "zaqlean", "<p>Summer flashback from Germany 😎</p>", "https://www.instagram.com/p/B5nwj2ylIk1/", 0, 0, "/Posts/img/post2.PNG" }, null);

            migrationBuilder.InsertData("posts",
                new[] { "Time", "profilePhoto", "Username", "content", "source", "Likes", "type", "Photo" },
                new object[] { "14.11.2019", "/Posts/profiles/instagram.jpg", "zaqlean", "<p>Skype as imagined by people in 1879 😮 #book #design #history</p>", "https://www.instagram.com/p/B41ZRi-l9gx/", 0, 0, "/Posts/img/post1.PNG" }, null);

            migrationBuilder.InsertData("posts",
               new[] { "Time", "profilePhoto", "Username", "content", "source", "Likes", "type", "Photo" },
               new object[] { "26.11.2019", "/Posts/profiles/google.jpg", "Zachariasz Jankowski", "<h4>Reuse-oriented software engineering</h4><p>Reuse-oriented software engineering – Nowadays, developing new software almost always involves reusing an already existing one. Be it in a form of libraries or frameworks – it’s almost inevitable to use some 3rd party’s code while developing a new application. Sometimes, however, the amount of external code is so significant that developers are mainly focused on integrating all the components together, rather than on writing new code. In such a case significant amounts of time and effort must be devoted to finding the suitable components, analysing their structure and evaluating what are the missing parts of code that need to be developed. One software Engineer describes it this way: “Basically we have two kinds of jobs. One kind involves working on core technologies … etc. The other one is taking a bunch of core technologies and applying some duct tape to make them work together.” </p>", "https://computersciencebypolishguy.blogspot.com/2019/11/reuse-oriented-software-engineering.html", 0, 1, "NaN" }, null);

            migrationBuilder.InsertData("posts",
                new[] { "Time", "profilePhoto", "Username", "content", "source", "Likes", "type", "Photo" },
                new object[] { "18.08.2018", "/Posts/profiles/twitter.jpg", "Zachariasz Jankowski", "<p><a href='https://twitter.com/BrunelCompSci'>@BrunelCompSci</a> My dream job is the AI Research Engineer in <a href='https://twitter.com/DeepMindAI'>@DeepMindAI</a> research project. What a great idea to focus on developing the required skills today!</p>", "https://twitter.com/Zachari39380267/status/1041994447968522241", 0, 2, "NaN" }, null);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
