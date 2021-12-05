using FiorellaFrontoBack.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaFrontoBack.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        private readonly AppDbContext _dbcontext;
        public FooterViewComponent(AppDbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var bio = await _dbcontext.Bio.SingleOrDefaultAsync();
            return View(bio);
        }
    }
}
