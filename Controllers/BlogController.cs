using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebSiteMVC.Data;
using MyWebSiteMVC.Models;
using System.Collections;
using System.Linq;

namespace MyWebSiteMVC.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context) => _context = context;

        public IActionResult Index() //blog/index
        {
            List<Blog> posts = _context.posts.ToList();
            return View(posts);
        }

        public ActionResult Add()
        {
            return View(); //dupa adaugarea se duce la pagina blog/add.cshtml
        }

        [HttpPost]
        public IActionResult Add(Blog post) 
        {
            if(ModelState.IsValid)
            {
                _context.posts.Add(post);
                _context.SaveChanges();

                return Redirect("/blog");
            }

            return View();
        }

        [HttpPost]
        //[Route("blog/{id:int}/edit")]
        public ActionResult Edit(int id)
        {
            return View(); //dupa adaugarea se duce la pagina blog/edit.cshtml
        }

        [HttpPost]
        [Route("blog/edit/{id:int}")]
        public IActionResult Edit(Blog post, int id)
        {
            if (ModelState.IsValid)
            {
                Blog edited_blog = _context.posts.FirstOrDefault(x => x.Id == id);

                edited_blog.Title = post.Title;
                edited_blog.Anons = post.Anons;
                edited_blog.FullText = post.FullText;

                _context.posts.Update(edited_blog);
                _context.SaveChanges();

                return Redirect("/blog");
            }

            return View(post);
        }

        [HttpPost]
        //[Route("blog/{id:int}/delete")]
        public RedirectResult Delete(int id)
        {
            Blog blog_to_delete = _context.posts.FirstOrDefault(x => x.Id == id);

            _context.posts.Remove(blog_to_delete);
            _context.SaveChanges();

            return Redirect("/blog");
        }
    }
}
