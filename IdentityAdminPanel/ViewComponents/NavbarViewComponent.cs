using IdentityAdminPanel.Domain.Entities;
using IdentityAdminPanel.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityAdminPanel.ViewComponents
{
    [Authorize]
    public class NavbarViewComponent : ViewComponent
    {
        private UserManager<AppUser> _userManager { get; set; }
        public NavbarViewComponent(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync() 
        {
            var user = await _userManager.FindByEmailAsync(User.Identity.Name);
            UserDataViewModel model = new UserDataViewModel { 
                Image = user.Image,
                Name = user.Name
            };

            return View("_NavbarData", model);
        }   
    }
}
