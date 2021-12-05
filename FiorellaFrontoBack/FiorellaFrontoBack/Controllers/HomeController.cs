using FiorellaFrontoBack.DataAccessLayer;
using FiorellaFrontoBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaFrontoBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbcontext;
        public HomeController(AppDbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        public IActionResult Index()
        {
            var slider = _dbcontext.Slider.SingleOrDefault();
            var sliderImage = _dbcontext.SliderImages.ToList();
            var products = _dbcontext.Products.Include(x=>x.Category).ToList();
            var category = _dbcontext.Categories.ToList();
            return View(new HomeViewModel
            {
                Slider = slider,
                SliderImages =sliderImage,
                Categories =category,
                Products = products
            }
            );
        }
    }
}
