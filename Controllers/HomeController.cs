using Microsoft.AspNetCore.Mvc;
using MyWebSiteMVC.Data;
using MyWebSiteMVC.Models;
using System.Diagnostics;

namespace MyWebSiteMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            List<Item> items = _context.items.ToList();

            return View(items);

            /*Category category = new Category { Name = "Potatoes" };   //Ca sa adaugi produsele in SQL prin Cod
            _context.categories.Add(category);
            _context.SaveChanges();

            Item item = new Item("Potato", 75, "Tasty Potato", "This high quality potato is grown in Russia using high quality level of care, having the length of approximately 15 cm and diameter of 7 cm", "potato.png", category.Id);
            _context.items.Add(item);
            _context.SaveChanges();*/
        }


        public IActionResult Product(int id) //int id pentru product.cshtml, putem adauga cati param vrem, daca ii folosim in product.cshtml
        {
            Item items = _context.items.Find(id) ?? new Item();
            return View(items);
        }

        public IActionResult Potatoes()
        {
            List<Item> items = _context.items.Where(el => el.CategoryID == 1).ToList();

            if (!items.Any())
                return View("Empty");
            else
                return View(items);
        }

        public IActionResult Napkins()
        {
            List<Item> items = _context.items.Where(el => el.CategoryID == 2).ToList();

            if (!items.Any())
                return View("Empty");
            else
                return View(items);
        }

        public IActionResult Apples()
        {
            List<Item> items = _context.items.Where(el => el.CategoryID == 3).ToList();

            if (!items.Any())
                return View("Empty");
            else
                return View(items);
        }

        public IActionResult Pies()
        {
            List<Item> items = _context.items.Where(el => el.CategoryID == 4).ToList();

            if (!items.Any())
                return View("Empty");
            else 
                return View(items);
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}