using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PRN211_HE170436_Project.Data;

namespace PRN211_HE170436_Project.Components
{
    public class JustArrived : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public JustArrived(ApplicationDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {

            return View(_context.Products.Where(p => p.IsArrived == true).ToList());

        }
    }
}
