using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Zachariasz_Jankowski.Models;
using Newtonsoft.Json;
using Zachariasz_Jankowski.Data;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;


namespace MVC.Controllers
{
    public class FeedController : Controller
    {

        private readonly ILogger<FeedController> _logger;

        public FeedController(ILogger<FeedController> logger)
        {
            _logger = logger;
            var optionsBuilder = new DbContextOptionsBuilder<DataDbContext>();
            optionsBuilder.UseSqlite("Data Source=data.db");
            _context = new DataDbContext(optionsBuilder.Options);

        }
        private DataDbContext _context;

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public IActionResult Index()
        {
            ViewBag.Message = "Feed";
            return View();

        }

        public async Task<ActionResult> Json(int id)
        {
            var x = _context.posts.Count();
            if (id > x) return Json(new { id = -1 });
            var posts = await _context.posts.FirstAsync(a => a.id == id);
            posts.liked = await (_context.like.Where(b => b.post == id && b.username == User.Identity.Name).AnyAsync());
            return Json(posts);
        }
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
                //Like lik = new Like { post = id, username = User.Identity.Name,};
                Like like = new Like { post = id, username = User.Identity.Name, };
                await _context.AddAsync(like);
                //await _context.AddAsync(lik);
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