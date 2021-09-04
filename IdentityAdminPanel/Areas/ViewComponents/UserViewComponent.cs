using IdentityAdminPanel.Domain;
using IdentityAdminPanel.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityAdminPanel.Areas.ViewComponents
{
    public class UserViewComponent : ViewComponent
    {
        private EFContext _context { get; set; }

        public UserViewComponent(EFContext context)
        {
            _context = context;
        }
        
        public async Task<IViewComponentResult> InvokeAsync() 
        {
            return await Task.Run(() => { 
                var users =  _context.Users.ToList();
                return View("_UserCollection", users);
            });
        }
    }
}
