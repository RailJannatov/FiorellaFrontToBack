using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaFrontoBack.Models
{
    public class FlowerItem
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string ExpertName { get; set; }
        [Required]
        [StringLength(50)]
        public string ExpertProfession { get; set; } 
        public string ImageName { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
