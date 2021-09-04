using IdentityAdminPanel.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityAdminPanel.Areas.Admin.Models
{
    public class UserViewModel
    {
        public CreateUserViewModel CreateUser { get; set; }
        public EditViewModel EditUser { get; set; }

        public EFContext context { get; set; }
        public string FormName { get; set; }

    }
}
