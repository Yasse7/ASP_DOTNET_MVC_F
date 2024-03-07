using First_MVC_APP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace First_MVC_APP.Controllers
{
    
    [Route("ProductController")]
    public class ProductController : Controller
    {
      


       private List<Product> products = new List<Product>()
        {
            new Product { Name = "pc", Description = "d1", Price = 2225 },
            new Product { Name = "pc2", Description = "d1", Price = 2226 },
            new Product { Name = "pc3", Description = "d1", Price = 2227 },
            new Product { Name = "pc4", Description = "d1", Price = 2228 },
            new Product { Name = "tele", Description = "d2", Price = 2229 }
        };

        public IActionResult Index()
        {
            ViewBag.TotalProducts = products.Count;
            foreach (var product in products)
            {
                Console.WriteLine($"Product: {product.Name}");
            }
            return View(products);
        }
    }
}
