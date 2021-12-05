using FiorellaFrontoBack.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaFrontoBack.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly AppDbContext _dbcontext;
        public HeaderViewComponent(AppDbContext dbContext )
        {
            _dbcontext = dbContext;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var logo = await _dbcontext.Logo.SingleOrDefaultAsync();
            return View(logo);
        }
    }
}
