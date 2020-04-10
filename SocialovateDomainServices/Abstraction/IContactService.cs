using SocialovateDomainDTOs;
using SocialovateDomainModels.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialovateDomainServices.Abstraction
{
    public interface IContactService
    {
        //Action<IAccount> DeleteContactDel { get; set; }
        Action<IAccount, ContactDTO> AddContactDel { get; set; }
        Func<IAccount, List<ContactDTO>> GetAllContactsDel { get; set; }
        Func<string, ContactDTO> SearchInAllAcountsDel { get; set; }
        Func<string, ContactDTO> FilterContactsByUsernameDel {get;set;}



        //Methods
        List<ContactDTO> GetUserContacts(IAccount acc);
        void AddUserContact(IAccount acc, ContactDTO contact);
        ContactDTO FilterByUsername(string username);
        ContactDTO SearchInAllAccounts(string username);

    }
}
