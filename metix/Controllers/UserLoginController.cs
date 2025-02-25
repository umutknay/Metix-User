﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using metix.Models;
using metix.Services;
using Microsoft.AspNetCore.Mvc;

namespace metix.Controllers
{
    
        [Route("api/[controller]")]
        [ApiController]
        public class UserLoginController : Controller
        {
            private readonly UserLoginService _UserService;
            public UserLoginController(UserLoginService UserService)
            {
                _UserService = UserService;
            }

            [HttpPost("Login")]
            public virtual async Task<ActionResult> Login(Authentication authentication)
            {
                return Ok(await this._UserService.LoginMethod(authentication));
            }
        }
    }

