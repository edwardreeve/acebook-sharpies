using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Acebook.Models;
using Microsoft.AspNetCore.Mvc;

namespace Acebook.Controllers {

    public class HomeController : Controller {
        private readonly AcebookContext _context;
        public HomeController (AcebookContext context) {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index () {
            List<Post> posts = _context.Post.OrderByDescending (x => x.CreatedAt).ToList ();
            return View (posts);
        }

        [HttpPost]
        public async Task<ActionResult> CreatePost(string body, long userId = 1)
        {
            Post post = new Post();
            Post newPost = post.CreatePost(body, userId);

            _context.Post.Add(newPost);
            await _context.SaveChangesAsync();

            return Redirect("/");
        }

        public IActionResult Privacy () {
            return View ();
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}