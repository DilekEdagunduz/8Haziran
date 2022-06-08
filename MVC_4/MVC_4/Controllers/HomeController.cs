using Microsoft.AspNetCore.Mvc;
using MVC_4.Models;

namespace MVC_4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>();
            Product product = new Product();
            product.Name = "milk";
            product.UnitPrice = 10;
            product.discountedPrice = 5;
            products.Add(product);
            return View(products);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Product()
        {
            return View();
        }
        public IActionResult Store()
        {
            return View();
        }
    }
}
