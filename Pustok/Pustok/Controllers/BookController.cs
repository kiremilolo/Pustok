using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Pustok.DAL;
using Pustok.Models;

namespace Pustok.Controllers
{
    public class BookController : Controller
    {
        private readonly PustokDbContext _context;
        public BookController(PustokDbContext context)
        {
                _context = context; 
        }

        public IActionResult GetBookModal(int id)
        {
            var book = _context.Books.
                Include(x=> x.Author).
                Include(x=> x.Genre).
                Include(x=> x.BookImages)
                .FirstOrDefault(x=> x.Id== id);
            return PartialView("_BookModalView", book);
        }


        public IActionResult SetBasket(int Id)
        {
            List<BasketItemViewModel> basketItems;
            
            var basket = HttpContext.Request.Cookies["basket"];

            if(basket == null)
                basketItems = new List<BasketItemViewModel>();
            else
                basketItems = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(basket); 

            var WantedBook= basketItems.FirstOrDefault(x=>x.BookId==Id);    

            if(WantedBook == null)
                basketItems.Add(new BasketItemViewModel { Count=1,BookId=Id}); 
            else
                WantedBook.Count++;
            basketItems.Add(new BasketItemViewModel { Count = 1, BookId=Id }) ;

            HttpContext.Response.Cookies.Append("basket", JsonConvert.SerializeObject(basketItems));
            return RedirectToAction("index", "home");
        }
            
        public IActionResult GetBasket(string key)
        {
            var value = HttpContext.Request.Cookies["basket"];

            return Content(value);  
        }
    }


}

