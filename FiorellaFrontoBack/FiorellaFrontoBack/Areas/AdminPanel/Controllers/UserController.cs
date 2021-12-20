using FiorellaFrontoBack.Areas.AdminPanel.Data;
using FiorellaFrontoBack.Models;
using FiorellaFrontoBack.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaFrontoBack.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize(Roles = RoleConstants.AdminRole)]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public UserController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.Select(x => new UserViewModel
            {
                Id = x.Id,
                FullName = x.FullName,
                UserName = x.UserName,
                Email = x.Email,
                User = x

            }).ToListAsync();
            foreach (var item in users)
            {
                item.Role = (await _userManager.GetRolesAsync(item.User))[0];
                item.User = null;

            }
            return View(users);
        }
        public async Task<IActionResult> ChangePassword(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }
            var existUser = await _userManager.FindByIdAsync(id);
            if (existUser == null)
            {
                return NotFound();
            }
            return View(new ChangePasswordViewModel
            {
                Username = existUser.UserName
            });


        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(string id, ChangePasswordViewModel passwordModel)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return View();
            }
            var existUser = await _userManager.FindByIdAsync(id);
            if (existUser == null)
            {
                return NotFound();
            }
            if (!await _userManager.CheckPasswordAsync(existUser, passwordModel.OldPassword))
            {
                ModelState.AddModelError("", "qeyd etdiyiniz shifre sehdir");
                return View();
            }
            var result = await _userManager.ChangePasswordAsync(existUser, passwordModel.OldPassword, passwordModel.NewPassword);
            {
                if (!result.Succeeded)
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                        return View();
                    }
                }

            }
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> ChangeRole(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            var existUser = await _userManager.FindByIdAsync(id);
            if (existUser == null)
            {
                return NotFound();
            }

            var exist = await _userManager.GetRolesAsync(existUser);
            return View(new ChangeRoleViewModel
            {
                Username = existUser.UserName,
                OldRole = exist[0]
            });

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeRole(string id, ChangeRoleViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (id == null)
            {
                return NotFound();
            }
          

            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return View();
            }
            var roles = await _userManager.GetRolesAsync(user);
            var result = await _userManager.RemoveFromRolesAsync(user, roles);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot remove user existing roles");
                return View(model);
            }
            await _roleManager.CreateAsync(new IdentityRole(model.NewRole));
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot add selected roles to user");
                return View(model);
            }
            return RedirectToAction("Index");
        }
    }

}
