﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ZooIdentityApplication.Models
{
    public class User : IdentityUser<int>
    {
        public string Breed { get; set; }
    }

    public class Role : IdentityRole<int>
    {

    }
}
