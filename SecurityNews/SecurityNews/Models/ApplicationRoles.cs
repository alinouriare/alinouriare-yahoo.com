﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityNews.Models
{
    public class ApplicationRoles:IdentityRole
    {
        public string RoleLevel { get; set; }

        public string Description { get; set; }
    }
}
