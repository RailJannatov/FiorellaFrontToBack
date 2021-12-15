using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaFrontoBack.ViewModels
{
    public class LoginViewModel
    {
        [Required,StringLength(50),DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required,StringLength(20),DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name ="Remember me?" )]
        public bool RememberMe { get; set; }
    }
}
