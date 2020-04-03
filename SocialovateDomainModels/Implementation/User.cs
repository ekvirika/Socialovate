﻿using SocialovateDomainModels.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialovateDomainModels.Implementation
{
    public class User : IUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Image { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
}
