using FiorellaFrontoBack.DataAccessLayer;
using FiorellaFrontoBack.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaFrontoBack.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize(Roles = "Admin")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _dbcontext;
        private readonly IWebHostEnvironment _hostEnvironment;
        public BlogController(AppDbContext dbContext, IWebHostEnvironment webHostEnvironment)
        {
            _dbcontext = dbContext;
            _hostEnvironment = webHostEnvironment;
        }
        public async Task<IActionResult>  Index()
        {
            var blogCards = await _dbcontext.Blog.ToListAsync();
            return View(blogCards);
        }
        public  IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog blog)
        {
            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid)
            {
                return View();
            }

            var existBlog = await _dbcontext.Blog.AnyAsync(x => x.Title.ToLower() == blog.Title.ToLower());
            if (existBlog)
            {
                ModelState.AddModelError("Name", "Bu adda category artiq movcuddur");
                return View();
            }
            string wwwRootPath = _hostEnvironment.WebRootPath;
            string fileName = Guid.NewGuid().ToString() + "-" + blog.Photo.FileName;
            string path = Path.Combine(wwwRootPath, "img", fileName);
            var fileStream = new FileStream(path, FileMode.Create);
            await blog.Photo.CopyToAsync(fileStream);
            blog.Image = fileName;
            await _dbcontext.AddAsync(blog);
            await _dbcontext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var existCardInDb = await _dbcontext.Blog.FindAsync(id);
            if(existCardInDb == null)
            {
                return NotFound();
            }

           
            return View(existCardInDb);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteItem(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var existItemInDb = await _dbcontext.Blog.FindAsync(id);
            if(existItemInDb == null)
            {
                return NotFound();
            }
             _dbcontext.Blog.Remove(existItemInDb);
            await _dbcontext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }
}
