using First_MVC_APP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace First_MVC_APP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private List<Product> products = new List<Product>()
        {
            new Product { Name = "pc", Description = "d1", Price = 2225 },
            new Product { Name = "pc2", Description = "d1", Price = 2226 },
            new Product { Name = "pc3", Description = "d1", Price = 2227 },
            new Product { Name = "pc4", Description = "d1", Price = 2228 },
            new Product { Name = "tele", Description = "d2", Price = 2229 }
        };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.TotalProducts = products.Count;
            foreach (var product in products)
            {   
                Console.WriteLine($"Product: {product.Name}");
            }
            return View(products);
        }

        public IActionResult Privacy()
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
