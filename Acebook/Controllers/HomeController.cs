using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Acebook.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Acebook.Controllers
{
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
        
        public IActionResult Signup()
        {
            return View();
        }
        
        [HttpPost("post")]
        public async Task<ActionResult<string>> PostUser(User user)
        {
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            _context.User.Add(user);
            await _context.SaveChangesAsync();

            return "Welcome!";
        }

        [HttpPost("signin")]
        public ActionResult<string> SignIn(User user)
        {
            string inputEmail = user.Email;
            string inputPassword = user.Password;
            User validUser = _context.User.Where(u => u.Email == inputEmail).FirstOrDefault();
            if(validUser != null) {
                bool verifiedPass = BCrypt.Net.BCrypt.Verify(inputPassword, validUser.Password);
                if(verifiedPass) {
                    byte[] bytes = BitConverter.GetBytes(validUser.Id); 
                    HttpContext.Session.Set("userId", bytes);
                    long theId = BitConverter.ToInt64(bytes);
                    return Redirect("/");
                }
                else 
                {
                    return "Password failed";
                }
            } 
            else 
            {
                return "User email is invalid";
            }
        }

        [HttpDelete("{id}")]
           public async Task<ActionResult<string>> DeletePost(long id) {
           var item = _context.Post.Find(id);
           _context.Post.Remove(item);
           await _context.SaveChangesAsync();
           return "Post has been successfully deleted";
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}