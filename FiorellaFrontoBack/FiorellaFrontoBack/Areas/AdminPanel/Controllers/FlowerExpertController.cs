using FiorellaFrontoBack.Areas.AdminPanel.Data;
using FiorellaFrontoBack.DataAccessLayer;
using FiorellaFrontoBack.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
    public class FlowerExpertController : Controller
    {
        private readonly AppDbContext _dbcontext;
        private readonly IWebHostEnvironment _hostEnvironment;
        public FlowerExpertController(AppDbContext dbContext, IWebHostEnvironment hostEnvironment )
        {
            _dbcontext = dbContext;
            _hostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {
            var flowerExperts = _dbcontext.FlowerItems.ToList();
            return View(flowerExperts);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FlowerItem flowerItem)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            if (!flowerItem.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Please,choose photo");
                return View();
            }
            if(!flowerItem.Photo.IsSizeAllowed(4))
            {
                ModelState.AddModelError("Photo", "Photo 4mb artiqdir");
                return View();
            }
            var existExpertInDb = await _dbcontext.FlowerItems.AnyAsync(x => x.ExpertName.ToLower() == flowerItem.ExpertName.ToLower());
            if(existExpertInDb)
            {
                ModelState.AddModelError("ExpertName", "Bele bir expertimiz artiq var");
                return View();
            }
          
             

            var fileName = await FileUtil.GenerateFile(Constants.ImageFolderPath, flowerItem.Photo);

            flowerItem.ImageName = fileName;
            await _dbcontext.FlowerItems.AddAsync(flowerItem);
            await _dbcontext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


        }
        public async Task<IActionResult> Delete (int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var deletedExpert = await _dbcontext.FlowerItems.FindAsync(id);
            if (deletedExpert == null)
            {
                return NotFound();
            }
            return View(deletedExpert);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteExpert(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var deletedExpert = await _dbcontext.FlowerItems.FindAsync(id);
            if(deletedExpert == null)
            {
                return NotFound();
            }

            var path = Path.Combine(Constants.ImageFolderPath, deletedExpert.ImageName);

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            _dbcontext.FlowerItems.Remove(deletedExpert);
            await _dbcontext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var detailExpert = await _dbcontext.FlowerItems.FindAsync(id);
            if(detailExpert == null)
            {
                return NotFound();
            }
            return View(detailExpert);

        }
        public async Task<IActionResult> Update (int? id)
        {
         
            if(id == null)
            {
                return NotFound();
            }
            var updatedExpert = await _dbcontext.FlowerItems.FindAsync(id);
            if(updatedExpert == null)
            {
                return NotFound();
            }
            return View(updatedExpert);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int? id,FlowerItem flowerItem)
        {
            if (id == null)
            {
                return NotFound();
            }
            if(id != flowerItem.Id)
            {
                return BadRequest();
            }
            var updatedItem = await _dbcontext.FlowerItems.FindAsync(id);
            if (updatedItem == null)
            {
                return NotFound();
            }
            if (ModelState["ExpertName"].ValidationState == ModelValidationState.Invalid && ModelState["ExpertProffesion"].ValidationState == ModelValidationState.Invalid)
            {
                return View();
            }
            if(flowerItem.Photo == null)
            {
                flowerItem.ImageName = updatedItem.ImageName;
            }
            else
            {
                if (!flowerItem.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Photo deyil");
                    return View();
                }
                if (!flowerItem.Photo.IsSizeAllowed(4))
                {
                    ModelState.AddModelError("Photo", "Photo 4mbdan boyukdur");
                    return View();
                }
                var fileName = await FileUtil.GenerateFile(Constants.ImageFolderPath, flowerItem.Photo);
                flowerItem.ImageName = fileName;
                updatedItem.ImageName = fileName;


            }          
            var existFlowerExpert = await _dbcontext.FlowerItems.AnyAsync(x => x.ExpertName.ToLower() == flowerItem.ExpertName.ToLower() && x.Id != flowerItem.Id);
            if (existFlowerExpert)
            {
                ModelState.AddModelError("ExpertName", "Bele bir expertimiz artiq artiq movcuddur");
                return View();
            }

          

         
            updatedItem.ExpertName = flowerItem.ExpertName;
            updatedItem.ExpertProfession = flowerItem.ExpertProfession;
            await _dbcontext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
           
         
         }

   

      

    } 
}
