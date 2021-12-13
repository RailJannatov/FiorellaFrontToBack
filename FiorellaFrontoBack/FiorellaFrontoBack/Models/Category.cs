﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaFrontoBack.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string Name { get; set; }
        [Required,MaxLength(50)] 
        public string Description { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
