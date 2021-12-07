using FiorellaFrontoBack.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaFrontoBack.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _dbcontext;
        private readonly int _productCount;
        public ProductController(AppDbContext dbContext)
        {
            _productCount = dbContext.Products.Count();
            _dbcontext = dbContext;
        }
        public IActionResult Index()
        {
            ViewBag.ProductCount = _productCount;
            var products = _dbcontext.Products.Take(4).Include(x=>x.Category).ToList();
            return View(products);
        }
        public IActionResult Load(int skip)
        {

            var products = _dbcontext.Products.Skip(skip).Take(4).Include(x => x.Category).ToList();

            return PartialView("_ProductPartial", products);

        }
    } 
}
