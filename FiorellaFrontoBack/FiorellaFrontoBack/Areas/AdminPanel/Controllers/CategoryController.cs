using FiorellaFrontoBack.DataAccessLayer;
using FiorellaFrontoBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaFrontoBack.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _dbContext;
        public CategoryController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult>  Index()
        {
            var categories = await _dbContext.Categories.ToListAsync();
            return View(categories);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var existCategory = await _dbContext.Categories.FindAsync(id);
            if(existCategory == null)
            {
                return NotFound();
            }
            return View(existCategory);


        }
        public IActionResult Create()
        {
          
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var existCategory = await _dbContext.Categories.AnyAsync(x => x.Name.ToLower() == category.Name.ToLower());
            if (existCategory)
            {
                ModelState.AddModelError("Name", "Bu adda category artiq movcuddur");
                return View();
            }
            await _dbContext.Categories.AddAsync(category);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var existCategory = await _dbContext.Categories.FindAsync(id);
            if (existCategory == null)
            {
                return NotFound();
            }
            return View(existCategory);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,Category category)
        {
            if(id == null)
            {
                return NotFound();
            }
            if(id != category.Id)
            {
                return BadRequest();
            }
            if(!ModelState.IsValid)
            {
                return View();
            }
            var existCategoryInDb = await _dbContext.Categories.FindAsync(id);
            if (existCategoryInDb == null)
            {
                return NotFound();
            }
            var existCategory = await _dbContext.Categories.AnyAsync(x => x.Name.ToLower() == category.Name.ToLower() && x.Id != category.Id);
            if(existCategory)
            {
                ModelState.AddModelError("Name", "Bele bir category artiq movcuddur");
                return View();
            }
            existCategoryInDb.Name = category.Name;
            existCategoryInDb.Description = category.Description;

            await  _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var existCategory = await _dbContext.Categories.FindAsync(id);
            if (existCategory == null)
            {
                return NotFound();
            }
            return View(existCategory);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> Delete2(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var existItemInDb = await _dbContext.Categories.FindAsync(id);
            if(existItemInDb == null)
            {
                return NotFound();
            }

             _dbContext.Categories.Remove(existItemInDb);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


        }
    }
}
