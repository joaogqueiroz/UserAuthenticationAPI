using AspNetAPIProject02.Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetAPIProject02.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost]
        [Route("Login")] // Account/Login(User authentication)
        public IActionResult Login(LoginModel model)
        {
            return Ok();
        }

        [HttpPost]
        [Route("Register")] // Account/Register(User register)
        public IActionResult Register()
        {
            return Ok();
        }

        [HttpPost]
        [Route("PasswordRecovery")] // Account/Register (User recovery password)
        public IActionResult PasswordRecovery()
        {
            return Ok();
        }
    }
}
