using Microsoft.AspNetCore.Mvc;
using PRN211_HE170436_Project.Data;

namespace PRN211_HE170436_Project.Components
{
    public class ImageBar : ViewComponent    {
        private readonly ApplicationDbContext _context;

        public ImageBar(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {

            return View("Index",_context.Categories.ToList());

        }
    }
}
