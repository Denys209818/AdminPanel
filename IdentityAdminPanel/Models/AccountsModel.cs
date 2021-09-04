using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityAdminPanel.Models
{
    public class LoginViewModel
    {
        [EmailAddress(ErrorMessage ="Не коректна пошта"), Display(Name = "E-mail"), 
            Required(ErrorMessage ="Поле обов'язкове!")]
        public string Email { get; set; }
        [DataType(DataType.Password), Display(Name = "Пароль"),
            Required(ErrorMessage = "Поле обов'язкове!")]
        public string Password { get; set; }
    }

    public class RegisterViewModel
    {
        [Display(Name = "Ім'я"),
            Required(ErrorMessage = "Поле обов'язкове!")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "Не коректна пошта"), Display(Name = "E-mail"),
            Required(ErrorMessage = "Поле обов'язкове!")]
        public string Email { get; set; }
        [DataType(DataType.Password), Display(Name = "Пароль"),
            Required(ErrorMessage = "Поле обов'язкове!")]
        public string Password { get; set; }
        [Display(Name = "Фотографія")]
        public IFormFile Image { get; set; }
    }

    public class UserDataViewModel
    {
        public string Name { get; set; }
        public string Image { get; set; }
    }
}
