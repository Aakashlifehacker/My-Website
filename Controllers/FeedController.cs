using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Zachariasz_Jankowski.Models;
using Zachariasz_Jankowski.Data;
using System.Diagnostics;



namespace MVC.Controllers
{
    public class FeedController : Controller
    {

        public FeedController()
        {
            
            var optionsBuilder = new DbContextOptionsBuilder<DataDbContext>();
            optionsBuilder.UseSqlite("Data Source=data.db");
            _context = new DataDbContext(optionsBuilder.Options);

        }
        private DataDbContext _context;

        protected override void Dispose(bool disposing)
        {
            //garbage collector won't dispose datbase connection properly
            _context.Dispose();
        }
        public IActionResult Index()
        {
            ViewBag.Message = "Feed";
            return View();

        }

        //This method sends new posts in the form of JSON files
        public async Task<ActionResult> Json(int id)
        {
            
            var x = _context.posts.Count();//how many posts in the database
            int dbId = x - id+1;//translating incremental numbers from the client into DB ids (the newest post should be sent first and it has the biggest number as it's id)
            if (id > x) return Json(new { id = -1 });//"-1" is a code that dispalys "You've seen it all" message
            var posts = await _context.posts.FirstAsync(a => a.id == dbId); //getting the post with the given id from the database
            posts.ol = id;//to enable client to distinguish posst and keep them in the correct order
            posts.liked = await (_context.like.Where(b => b.post == dbId && b.username == User.Identity.Name).AnyAsync());//checking if the post has been liked by the current user
            return Json(posts);
        }
        //counting likes
        public async Task<int> ResolveLikes(int id)
        {
            var c = await _context.posts.FirstAsync(a => a.id == id);
            c.Likes = await _context.like.CountAsync(b => b.post == id);
            await _context.SaveChangesAsync();
            return c.Likes;

        }
        public async Task<int> AddLike(int id)
        {
            if (!await _context.like.Where(b => b.post == id && b.username == User.Identity.Name).AnyAsync())
            {
                
                Like like = new Like { post = id, username = User.Identity.Name, };
                await _context.AddAsync(like);
                await _context.SaveChangesAsync();
                return await ResolveLikes(id);
            }
            else return await ResolveLikes(id);
        }
        public async Task<int> DeleteLike(int id)
        {
            if (await _context.like.Where(b => b.post == id && b.username == User.Identity.Name).AnyAsync())
            {


                var dbLike = await _context.like.Where(b => b.post == id && b.username == User.Identity.Name).FirstAsync();
                _context.like.Remove(dbLike);
                await _context.SaveChangesAsync();
                return await ResolveLikes(id);

            }
            else return await ResolveLikes(id);
        }

        public async Task<ActionResult> Like(int id)
        {
            if (User.Identity.IsAuthenticated)
            {

                return Json(new { count = await AddLike(id) });

            }
            else
            {

                return Json(new { count = -2 });
            }
        }
        public async Task<ActionResult> Dislike(int id)
        {
            if (User.Identity.IsAuthenticated)
            {

                return Json(new { count = await DeleteLike(id) });

            }
            else
            {
                return Json(new { count = -2 });
            }
        }
        public ActionResult Issignedin(int id)
        {
            if (User.Identity.IsAuthenticated)
                return Json(new { signed = 1 });
            else
                return Json(new { signed = 0 });
            
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}