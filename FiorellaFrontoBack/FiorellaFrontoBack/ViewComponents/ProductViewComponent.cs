using FiorellaFrontoBack.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaFrontoBack.ViewComponents
{
    public class ProductViewComponent:ViewComponent
    {
        private readonly AppDbContext _dbcontext;
        public ProductViewComponent(AppDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync(int take = 8 )
        {
            var products = await _dbcontext.Products.Take(take).Include(x => x.Category).ToListAsync();
            return View(products);
        }
    }
}
