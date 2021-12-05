using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaFrontoBack.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Subtitle { get; set; }
        [Required]
        public string Image { get; set; }
      
       
        public DateTime Date { get; set; } 
    }
}
