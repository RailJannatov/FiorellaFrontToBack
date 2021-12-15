using FiorellaFrontoBack.Models;
using FiorellaFrontoBack.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaFrontoBack.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public AccountController(UserManager<User> userManager,SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            var existUser = await _userManager.FindByEmailAsync(login.Email);
            if (existUser == null)
            {
                ModelState.AddModelError("", "Credentials Invalid");
                return View();
            }
            var checkPass = await _signInManager.PasswordSignInAsync(existUser, login.Password,login.RememberMe,true);
            if(!checkPass.Succeeded )
            {
                ModelState.AddModelError("", "Credentials invalid");
                return View();
            }
            
            return RedirectToAction("Index","Home");
        }
        [HttpPost]
        [ValidateAntiForgeryToken] 
        public async  Task<IActionResult> Register(RegisterViewModel register)
        { 
            if(!ModelState.IsValid)
            {
                return View();
            }
            User existUser = await _userManager.FindByNameAsync(register.UserName);
            if(existUser != null)
            {
                ModelState.AddModelError("Username", "Bele bir username movcuddur");
                return View();
            }

            User user = new User
            {
                UserName = register.UserName,
                Email = register.Email,
                FullName = register.FullName
            };

            var existIdentity = await _userManager.CreateAsync(user, register.Password);
            if(!existIdentity.Succeeded)
            {
                foreach(var item in existIdentity.Errors)
                {
                    ModelState.AddModelError("", item.Description);
           
                }
                return View();
            }
            await _signInManager.SignInAsync(user, true);


            return RedirectToAction("Index","Home");

           
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
