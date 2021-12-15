using FiorellaFrontoBack.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Context = Microsoft.EntityFrameworkCore.DbContext;

namespace FiorellaFrontoBack.DataAccessLayer
{
    public class AppDbContext:IdentityDbContext<User>
    {
 
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
           
        }

        public DbSet<Slider> Slider { get; set; }
        public DbSet<SliderImage> SliderImages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Bio> Bio { get; set; }
        public DbSet<Logo> Logo { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<BlogTitle> BlogTitle { get; set; }
        public DbSet<FlowerTitle> FlowerTitle{ get; set; }
        public DbSet<FlowerItem> FlowerItems { get; set; }


    }
}
