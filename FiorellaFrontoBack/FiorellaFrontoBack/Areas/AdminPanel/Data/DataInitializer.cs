using FiorellaFrontoBack.DataAccessLayer;using FiorellaFrontoBack.Models;using Microsoft.AspNetCore.Identity;using Microsoft.EntityFrameworkCore;
using System;using System.Collections.Generic;using System.Linq;using System.Threading.Tasks;namespace FiorellaFrontoBack.Areas.AdminPanel.Data{    public class DataInitializer    {        private readonly AppDbContext _dbcontext;        private readonly UserManager<User> _userManager;        private readonly RoleManager<IdentityRole> _roleManager;
        public DataInitializer(AppDbContext dbContext, UserManager<User> userManager,RoleManager<IdentityRole> roleManager)
        {
            _dbcontext = dbContext;
            _userManager = userManager;
            _roleManager = roleManager;

        }
        public async Task SeedDataAsync()
        {
            await _dbcontext.Database.MigrateAsync();
            var roles = new List<string>
            {
                RoleConstants.AdminRole,
                RoleConstants.MemberRole,
                RoleConstants.ModeratorRole

            };
            foreach(var role in roles)
            {
                if(!await _roleManager.RoleExistsAsync(role))
                {
                    await _roleManager.CreateAsync(new IdentityRole(role));
                }
            }
            var user = new User
            {
                UserName = "Admin",
                FullName = "Admin Admin",
                Email = "admin@code.edu.az"
            };
            if(await _userManager.FindByNameAsync(user.UserName) == null)
            {
                await _userManager.CreateAsync(user,"1234@Admin");
                await _userManager.AddToRoleAsync(user, RoleConstants.AdminRole);
            }
            
            
        }    }}