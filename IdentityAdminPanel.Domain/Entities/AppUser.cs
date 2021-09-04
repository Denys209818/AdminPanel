using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityAdminPanel.Domain.Entities
{
    public class AppUser : IdentityUser<long>
    {
        public virtual ICollection<AppUserRole> UserRoles { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }
}
