using SocialovateDomainDTOs;
using SocialovateDomainModels.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialovateDomainModels.Implementation
{
    public class Account : IAccount
    {
        private static int _id = 0;
        public Account() { AccountId = _id; _id++; }


        public string Password { get; set; }
        public int AccountId { get; set; }
        public IUser User { get; set; }
        public string ImageUrl { get; set; }
        public List<ContactDTO> Contacts { get; set; } = new List<ContactDTO>();
        public List<IMessage> Messages { get; set; } = new List<IMessage>();
        public string Username { get; set; }
    }
}
