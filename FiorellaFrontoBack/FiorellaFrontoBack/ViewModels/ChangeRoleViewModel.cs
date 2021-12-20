using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaFrontoBack.ViewModels
{
    public class ChangeRoleViewModel
    {
        public string   Username { get; set; }
  
        public string OldRole { get; set; }
        [Required]
        public string NewRole { get; set; }
    }
}
