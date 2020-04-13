using SocialovateDomainDTOs;
using SocialovateDomainModels.Abstraction;
using SocialovateDomainServices.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialovateDomainServices.Implementation
{
    public class ContactService : IContactService
    {


        public Func<IAccount, ContactDTO, bool> AddContactDel { get; set; }        
        public Func<IAccount, List<ContactDTO>> GetAllContactsDel { get; set; } //

        // Filtration
        //public Func<string, ContactDTO> FilterContactsByNameDel { get; set; }
        public Func<string, ContactDTO> FilterContactsByUsernameDel { get ; set; }
        public Func<string, ContactDTO> SearchInAllAcountsDel { get; set; }

        public List<ContactDTO> GetUserContacts(IAccount acc)
        {
            return GetAllContactsDel.Invoke(acc);
        }

        public bool AddUserContact(IAccount acc, ContactDTO contact)
        {
            return AddContactDel.Invoke(acc, contact);
        }

        public ContactDTO FilterByUsername(string username)
        {
            return FilterContactsByUsernameDel.Invoke(username);

        }
        public ContactDTO SearchInAllAccounts(string username)
        {
            return SearchInAllAcountsDel.Invoke(username);
        }
    }
}
