﻿using Microsoft.AspNetCore.Mvc;
using PRN211_HE170436_Project.Data;

namespace PRN211_HE170436_Project.Components
{
    public class Trendy : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public Trendy(ApplicationDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {

            return View(_context.Products.Where(p => p.IsTrendy == true).ToList());

        }
    }
}
