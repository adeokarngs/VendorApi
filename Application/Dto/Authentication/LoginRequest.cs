﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Authentication
{
    public class LoginRequest
    {
        public string password { get; set; }

        public string email { get; set; }
    }
}
