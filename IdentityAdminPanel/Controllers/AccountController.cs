using IdentityAdminPanel.Domain.Entities;
using IdentityAdminPanel.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityAdminPanel.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<AppUser> _userManager { get; set; }
        private SignInManager<AppUser> _signInManager { get; set; }

        public AccountController(UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet, Route("login")]
        public IActionResult Login() 
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken, Route("login")]
        public async Task<IActionResult> Login(LoginViewModel model) 
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else 
                    {
                        ModelState.AddModelError("", "Пароль вказано не вірно!");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Користувач не зареєстрований!");
                }
            }
            else 
            {
                ModelState.AddModelError("", "Дані введено не коректно!");
            }

            return View(model);
        }

        [HttpGet, Route("register")]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken, Route("register")]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                string dirPath = Path.Combine(Directory.GetCurrentDirectory(), "images");
                string fileName = Path.GetRandomFileName() + Path.GetExtension(model.Image.FileName);
                using (var fileCreate = System.IO.File.Create(Path.Combine(dirPath, fileName))) 
                {
                    model.Image.CopyTo(fileCreate);
                }


                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null)
                {
                    var us = new AppUser
                    {
                        UserName = model.Email,
                        Email = model.Email,
                        Name = model.Name,
                        Image = fileName
                    };
                    var result = await _userManager.CreateAsync(us, model.Password);
                    if (result.Succeeded)
                    {
                        var authRes = await _signInManager.PasswordSignInAsync(await _userManager.FindByEmailAsync(model.Email),
                            model.Password, false, false);
                        return RedirectToAction("Index", "Home");
                    }
                    else 
                    {
                        ModelState.AddModelError("", "Під час створення аккаунту виникла помилка!");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Користувач вже зареєстрований!");
                }
            }
            else
            {
                ModelState.AddModelError("", "Дані введено не коректно!");
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout() 
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


    }
}
