﻿using SocialovateDomainDTOs;
using SocialovateDomainModels.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialovateDomainModels.Abstraction
{
    public interface IAccount
    {
        string Password { get; set; }
        string Username { get; set; }
        int AccountId { get; }
        IUser User { get; set; }
        string ImageUrl { get; set; }
        List<ContactDTO> Contacts { get; set; }
        List<IMessage> Messages { get; set; }
    }
}
