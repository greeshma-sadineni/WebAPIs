﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_with_Identity.Models
{
    public class LoginModel
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
