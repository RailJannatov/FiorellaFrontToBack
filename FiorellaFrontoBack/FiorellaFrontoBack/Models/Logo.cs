using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaFrontoBack.Models
{
    public class Logo
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string LogoName { get; set; }
    }
}
