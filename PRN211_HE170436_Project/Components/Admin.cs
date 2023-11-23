using Microsoft.AspNetCore.Mvc;
using PRN211_HE170436_Project.Data;

namespace PRN211_HE170436_Project.Components
{
    public class Admin : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public Admin(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {

            return View(_context.Products.ToList());

        }
    }
}
