using FiorellaFrontoBack.DataAccessLayer;
using FiorellaFrontoBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaFrontoBack.ViewComponents
{
    public class BlogItemViewComponent:ViewComponent
    {
        private readonly AppDbContext _dbcontext;
        public BlogItemViewComponent(AppDbContext dbContext)
        {
            _dbcontext=dbContext;
        }
        public async Task<IViewComponentResult> InvokeAsync(int take = 3)
        {
            var blogs = await _dbcontext.Blog.Take(take).ToListAsync();
            return View(blogs);
        }
    }
}
