using Microsoft.AspNetCore.Mvc;
using PRN211_HE170436_Project.Data;
using PRN211_HE170436_Project.Infrastructure;
using PRN211_HE170436_Project.Models;

namespace PRN211_HE170436_Project.Controllers
{
    public class CartController : Controller
    {
        public Cart? Cart { get; set; }
        private readonly ApplicationDbContext _context;

        public CartController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View("Cart", HttpContext.Session.getJson<Cart>("Cart"));
        }
        public IActionResult AddToCart(int productID)
        {
            Product? product = _context.Products.FirstOrDefault(p => p.ProductId == productID);
            if (product != null) { 
                Cart = HttpContext.Session.getJson<Cart>("Cart") ?? new Cart();
                Cart.AddItem(product, 1);
                HttpContext.Session.SetJson("Cart",Cart);
            }
            return View("Cart", Cart);
        }

        public IActionResult DecreaseCart(int productID)
        {
            Product? product = _context.Products.FirstOrDefault(p => p.ProductId == productID);
            if (product != null)
            {
                Cart = HttpContext.Session.getJson<Cart>("Cart");
                Cart.AddItem(product, -1);
                HttpContext.Session.SetJson("Cart", Cart);
            }
            return View("Cart", Cart);
        }

        public IActionResult RemoveFromCart(int productID)
        {
            Product? product = _context.Products.FirstOrDefault(p => p.ProductId == productID);
            if (product != null)
            {
                Cart = HttpContext.Session.getJson<Cart>("Cart");
                Cart.RemoveItem(product);
                HttpContext.Session.SetJson("Cart", Cart);
            }
            return View("Cart", Cart);
        }
    }
}
