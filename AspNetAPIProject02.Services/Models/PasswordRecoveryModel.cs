using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetAPIProject02.Services.Models
{
    public class PasswordRecoveryModel
    {
        [EmailAddress(ErrorMessage = "Please, inform a valid email.")]
        [Required(ErrorMessage = "Please, inform the email.")]
        public string Email { get; set; }
    }
}
