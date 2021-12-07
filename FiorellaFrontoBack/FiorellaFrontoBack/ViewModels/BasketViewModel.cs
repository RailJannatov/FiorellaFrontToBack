using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaFrontoBack.ViewModels
{
    public class BasketViewModel
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; } = 1;
    }
}
