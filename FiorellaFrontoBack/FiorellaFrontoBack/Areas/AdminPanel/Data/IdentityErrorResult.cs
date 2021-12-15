using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaFrontoBack.Areas.AdminPanel.Data
{
    public class IdentityErrorResult:IdentityErrorDescriber
    {
      
            public override IdentityError DuplicateEmail(string email)
            {
                return new IdentityError
                {
                    Code = nameof(DuplicateEmail),
                    Description = "Bu email movcuddur"
                };
            }
        
    }
}
