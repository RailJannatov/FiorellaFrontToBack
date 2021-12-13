using FiorellaFrontoBack.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaFrontoBack.ViewComponents
{
    public class FlowerExpertItemViewComponent:ViewComponent
    {
        private readonly AppDbContext _dbcontext;
        public FlowerExpertItemViewComponent(AppDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync(int take  = 3)
        {
            var flowerItems = await _dbcontext.FlowerItems.Take(take).ToListAsync();
            return View(flowerItems);
        }
    }
}
