
using EmailService;
using FiorellaFrontoBack.Areas.AdminPanel.Data;
using FiorellaFrontoBack.Models;
using FiorellaFrontoBack.ViewModels;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaFrontoBack.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IEmailSender _emailSender;
        private readonly IWebHostEnvironment _environment;


        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager,IEmailSender emailSender, IWebHostEnvironment environment)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _environment = environment;
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
            if (!ModelState.IsValid)
            {
                return View();
            }
            var existUser = await _userManager.FindByEmailAsync(login.Email);
            if (existUser == null)
            {
                ModelState.AddModelError("", "Credentials Invalid");
                return View();
            }
            var checkPass = await _signInManager.PasswordSignInAsync(existUser, login.Password, login.RememberMe, true);
            if (!checkPass.Succeeded)
            {
                ModelState.AddModelError("", "Credentials invalid");
                return View();
            }

            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel register)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            User existUser = await _userManager.FindByNameAsync(register.UserName);
            if (existUser != null)
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
            if (!existIdentity.Succeeded)
            {
                foreach (var item in existIdentity.Errors)
                {
                    ModelState.AddModelError("", item.Description);

                }
                return View();
            }

            await _userManager.AddToRoleAsync(user, RoleConstants.MemberRole);
            await _signInManager.SignInAsync(user, true);
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("test", "railtestemail@gmail.com"));
            message.To.Add(new MailboxAddress(user.UserName, user.Email));
            message.Subject = "Please Confirm Password";
            string emailBody = string.Empty;
            using (StreamReader stream = new StreamReader(Path.Combine(_environment.WebRootPath, "Templates", "emailConfirm.html")))
            {
                emailBody = stream.ReadToEnd();
            }
            string emailConfirmation = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            string url = Url.Action("confirmemail", "account", new { Id = user.Id, token = emailConfirmation }, Request.Scheme);
            emailBody = emailBody.Replace("{{fullname}}", $"{user.FullName}").Replace("{{url}}", $"{url}");
            message.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = emailBody };
            using var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
            smtp.Authenticate("railtestemail@gmail.com", "rail6124$$");
            smtp.Send(message);
            smtp.Disconnect(true);
            return RedirectToAction("Register", "Account");

        }
        public async Task<IActionResult> ConfirmEmail(string id,string token)
        {
            if(string.IsNullOrEmpty(id) || string.IsNullOrEmpty(token))
            {
                return NotFound();
            }
            var user = await _userManager.FindByIdAsync(id);
            if(user == null)
            {
                return Content("User is null");
            }
            var result = await _userManager.ConfirmEmailAsync(user, token);
            if (!result.Succeeded)
            {
                return NotFound();
            }
            return RedirectToAction("Login", "Account");
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
     

        public IActionResult ForgotPasswordConfirmation()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel forgotPasswordModel)
        {
            if (!ModelState.IsValid)
                return View(forgotPasswordModel);

            var user = await _userManager.FindByEmailAsync(forgotPasswordModel.Email);
            if (user == null)
                return RedirectToAction(nameof(ForgotPasswordConfirmation));
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Ibrahim Aslanli", "ibrahimra@code.edu.az"));
            message.To.Add(new MailboxAddress(user.UserName, user.Email));
            message.Subject = "Emaili Tesdiqleyin";

            string emailbody = string.Empty;

            using (StreamReader stream = new StreamReader(Path.Combine(_environment.WebRootPath, "Templates", "forgotPassword.html")))
            {
                emailbody = stream.ReadToEnd();
            };


            string forgotpasswordtoken = await _userManager.GeneratePasswordResetTokenAsync(user);

            string url = Url.Action("ResetPassword", "account", new { Id = user.Id, token = forgotpasswordtoken }, Request.Scheme);

            emailbody = emailbody.Replace("{{fullname}}", $"{user.FullName}").Replace("{{url}}", $"{url}");

            message.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = emailbody };

            using var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("railtestemail@gmail.com", "rail6124$$");
            smtp.Send(message);
            smtp.Disconnect(true);

            return View();
        }



        public async Task<IActionResult> ResetPassword(string Id, string token)
        {
            if (string.IsNullOrWhiteSpace(Id) || string.IsNullOrWhiteSpace(token))
            {
                return NotFound();
            }

            var user = await _userManager.FindByIdAsync(Id);
            if (user == null)
            {
                return NotFound();
            }

            ResetPasswordViewModel reset = new ResetPasswordViewModel
            {
                Id = Id,
                Token = token
            };
            return View(reset);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel reset)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            if (string.IsNullOrWhiteSpace(reset.Id) || string.IsNullOrWhiteSpace(reset.Token))
            {
                return NotFound();
            }

            var user = await _userManager.FindByIdAsync(reset.Id);
            if (user == null)
            {
                return NotFound();
            }

            IdentityResult result = await _userManager.ResetPasswordAsync(user, reset.Token, reset.Password);

            if (!result.Succeeded)
            {
                foreach (var eror in result.Errors)
                {
                    ModelState.AddModelError("", eror.Description);
                }
                return View(reset);
            }

            return RedirectToAction("login", "account");

        }

    
        public IActionResult ResetPasswordConfirmation()
        {
            return View();
        }
      

    
    }



   


}
