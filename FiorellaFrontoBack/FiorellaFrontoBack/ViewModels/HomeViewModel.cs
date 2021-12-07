using FiorellaFrontoBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaFrontoBack.ViewModels
{
    public class HomeViewModel
    {
        public Slider Slider { get; set; }
        public List<SliderImage> SliderImages { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public BlogTitle BlogTitle { get; set; }
        public FlowerTitle  FlowerTitle { get; set; }
        public List<FlowerItem> FlowerItems { get; set; }
    }
}
