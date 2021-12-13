using FiorellaFrontoBack.DataAccessLayer;
using FiorellaFrontoBack.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaFrontoBack.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _dbcontext;
        private readonly IWebHostEnvironment _hostEnvironment;
        public SliderController(AppDbContext dbContext, IWebHostEnvironment hostEnvironment)
        {
            _dbcontext = dbContext;
            _hostEnvironment = hostEnvironment;

        }
        public async Task<IActionResult> Index()
        {
            var sliderImages = await _dbcontext.SliderImages.ToListAsync();
            return View(sliderImages);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SliderImage sliderImage)
        {
 
            if (!ModelState.IsValid)
            {
                return View();
            }
            string wwwRootPath = _hostEnvironment.WebRootPath;
            string fileName = Guid.NewGuid().ToString() + "-" + sliderImage.Photo.FileName;
            string path = Path.Combine(wwwRootPath,"img", fileName);

            var fileStream = new FileStream(path, FileMode.Create);

            await sliderImage.Photo.CopyToAsync(fileStream);

            sliderImage.Image = fileName;
            await _dbcontext.AddAsync(sliderImage);
            await _dbcontext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

       


    }


}

