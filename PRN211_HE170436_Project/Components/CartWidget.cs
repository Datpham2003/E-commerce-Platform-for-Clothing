using Microsoft.AspNetCore.Mvc;
using PRN211_HE170436_Project.Data;
using PRN211_HE170436_Project.Infrastructure;
using PRN211_HE170436_Project.Models;

namespace PRN211_HE170436_Project.Components
{
    public class CartWidget : ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {

            return View(HttpContext.Session.getJson<Cart>("Cart"));

        }
    }
}
