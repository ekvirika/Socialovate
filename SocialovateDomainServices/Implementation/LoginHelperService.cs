﻿using SocialovateDomainModels.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialovateDomainServices.Implementation
{
    public class LoginHelperService
    {
        private static IAccount _loggedInUser = default;
        public static void LoginUser(IAccount obj) => _loggedInUser = obj;
        public static void LogOutUser() => _loggedInUser = default;
        public static IAccount GetCurrentUser() => _loggedInUser;
    }

}
