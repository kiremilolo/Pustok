using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok.DAL;
using Pustok.Models;
using Pustok.ViewModels;
using System.Diagnostics;

namespace Pustok.Controllers
{
    public class HomeController : Controller
    {

        private readonly PustokDbContext _context;

        public HomeController(PustokDbContext context)
        {
                _context = context;
        }

        public IActionResult Index()    
        {
            HomeViewModel VM = new HomeViewModel
            {
                    Sliders = _context.Sliders.ToList(),
                    Services = _context.Services.Take(4).ToList(),
                    BestSellerBooks = _context.Books.Include(x => x.Author).Include(x => x.BookImages).Where(x => x.IsBestSeller).Take(25).ToList(),
                    NewBooks = _context.Books.Include(x => x.Author).Include(x => x.BookImages).Where(x => x.IsNew).Take(25).ToList(),
                    DiscountedBooks = _context.Books.Include(x => x.Author).Include(x => x.BookImages).Where(x => x.DiscountPercent > 0).Take(25).ToList()

            };
            return View(VM);    
        }

        public IActionResult Contact()
        {
            return View();
        }


        public IActionResult SetSeccion(string key,string value)
        {
            HttpContext.Session.SetString(key, value);                              
            return RedirectToAction("Index");   
        }

        public IActionResult GetSeccion(string key)
        {
            var data = HttpContext.Session.GetString(key);
            return Content(data);
        }


        public IActionResult SetCookie(string key,string value)
        {
            HttpContext.Response.Cookies.Append(key, value);
            return RedirectToAction("Index");
        }

        public IActionResult GetCookie(string key)
        {
            var value = HttpContext.Request.Cookies[key];
            return Content(value);
        }




        
    }
}