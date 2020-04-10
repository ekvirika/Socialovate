using SocialovateDomainDTOs;
using SocialovateDomainModels.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialovateDomainServices.Abstraction
{
    public interface ISocialovateService
    {
        // User
        bool RegisterNewUser(IAccount user);
        IAccount SignInUser(LoginDTO user);
        //void DeleteCurrentUser(IAccount user);
        IAccount SearchAccount(string userName);
        void SignOutUser();

        // Contact
        ContactDTO SearchForContactInDB(string username);
        ContactDTO SearchUserContactByUsername(string username);
        void AddUserContact(IAccount account, ContactDTO contact);
        List<ContactDTO> GetAllUserContacts(IAccount acc);
        //void RegisterNewContact();
    }
}
