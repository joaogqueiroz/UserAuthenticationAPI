using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetAPIProject02.Services.Models
{
    public class RegisterModel
    {
        [MinLength(6, ErrorMessage = "You should inform a minimum of {1} characters ")]
        [MaxLength(100, ErrorMessage = "You should inform a maximum of {1} characters ")]
        [Required(ErrorMessage = "Please, inform your Name.")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Please, inform a valid email.")]
        [Required(ErrorMessage = "Please, inform the email.")]
        public string Email { get; set; }

        [StrongPassWord(ErrorMessage = "Inform a uppercase letter 1, 1 lowercase letter, 1 number and 1 special character(! @ # $ % & ).")]
        [MinLength(8, ErrorMessage = "You should inform a minimum of {1} characters ")]
        [MaxLength(20, ErrorMessage = "You should inform a maximum of {1} characters ")]
        [Required(ErrorMessage = "Please, inform the password.")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage ="The passwords don't match")]
        [Required(ErrorMessage = "Please, confirm the password.")]
        public string PasswordConfirm { get; set; }
    }

    public class StrongPassWord : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                var password = value.ToString();

                return password.Any(char.IsUpper)
                    && password.Any(char.IsLower)
                    && password.Any(char.IsDigit)
                    && (password.Contains("!")
                       || password.Contains("@")
                       || password.Contains("#")
                       || password.Contains("$")
                       || password.Contains("%")
                       || password.Contains("&"));
            };
            return false;

        }
    }
}
