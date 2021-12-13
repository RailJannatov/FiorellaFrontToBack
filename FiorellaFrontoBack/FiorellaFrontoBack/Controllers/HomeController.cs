using FiorellaFrontoBack.DataAccessLayer;
using FiorellaFrontoBack.Models;
using FiorellaFrontoBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
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
            var blogTitle = _dbcontext.BlogTitle.SingleOrDefault();
            var experts = _dbcontext.FlowerItems.Select(x => x.Id).ToList();
            var flowerTitle = _dbcontext.FlowerTitle.SingleOrDefault();

            return View(new HomeViewModel
            {
                Slider = slider,
                SliderImages = sliderImage,
                Categories = category,
                Products = products,
                BlogTitle = blogTitle,
               FlowerTitle = flowerTitle
            }
            );
        }
        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var basket = Request.Cookies["basket"];
            var basketViewModel = JsonConvert.DeserializeObject<List<BasketViewModel>>(basket);
            var deletedItem =  basketViewModel.Find(x=>x.Id == id);
            if(deletedItem == null)
            {
                return NotFound();
            }
            basketViewModel.Remove(deletedItem);
            basket = JsonConvert.SerializeObject(basketViewModel);
            Response.Cookies.Append("basket", basket);
            return RedirectToAction("Basket");

        }
        public async Task<IActionResult> Basket()
        {
            var basket =  Request.Cookies["basket"];
            if(string.IsNullOrEmpty(basket))
            {
                return Content("boshdur");
            }
          
            var newBasket = new List<BasketViewModel>();
            var basketViewModel =  JsonConvert.DeserializeObject<List<BasketViewModel>>(basket);
            foreach(var item in basketViewModel)
            {
                var existItemInDatabase = await _dbcontext.Products.FindAsync(item.Id);
                if (existItemInDatabase == null)
                    continue;

                newBasket.Add(new BasketViewModel
                {
                    Id = item.Id,
                    Name = existItemInDatabase.Name,
                    Price = existItemInDatabase.Price,
                    Image = existItemInDatabase.Image,
                    Count = item.Count

                });
               
            }
            return View(basketViewModel);

        }
        public async Task<IActionResult> AddToBasket(int? id)
        {
            if (id == null)
            {
                return Content("Error");
            }
            var product = await _dbcontext.Products.FindAsync(id);
            if(product == null)
            {
                return Content("Error");
            }
            List<BasketViewModel> basketViewModels;
            var existBasket = Request.Cookies["basket"];
            if (string.IsNullOrEmpty(existBasket))
            {
                basketViewModels = new List<BasketViewModel>();
            }
            else
            {
                basketViewModels = JsonConvert.DeserializeObject<List<BasketViewModel>>(existBasket);
            }

            var existItemInBasket = basketViewModels.Find(x => x.Id == product.Id);
            if(existItemInBasket == null)
            {
                existItemInBasket = new BasketViewModel
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Image = product.Image
                };
                basketViewModels.Add(existItemInBasket);
            }
            else
            {
                existItemInBasket.Count++;
            }

            var basket = JsonConvert.SerializeObject(basketViewModels);
            Response.Cookies.Append("basket", basket);

           
         

            return RedirectToAction("Index");
        }
    }
}
