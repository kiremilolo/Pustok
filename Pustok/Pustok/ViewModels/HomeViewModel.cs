﻿using Pustok.Models;

namespace Pustok.ViewModels
{
    public class HomeViewModel
    {
        public List<Slider> Sliders { get; set; }
        public List<Service> Services { get; set; } 
        public List<Book> BestSellerBooks { get; set; }   
        public List<Book> NewBooks { get; set; }
        public List<Book> DiscountedBooks { get; set; }


    }
}
