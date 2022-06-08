using Microsoft.AspNetCore.Mvc;
using MVC_5.Models;

namespace MVC_5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { Name = "Computer", Price = 4000, discountedPrice = 3000 });
            return View(products);
        }
    }
}
