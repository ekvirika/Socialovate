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
        bool RegisterNewUser(IAccount user);
        IAccount SignInUser(LoginDTO user);
        //void DeleteCurrentUser(IAccount user);
        IAccount SearchAccount(string userName);
        void SignOutUser();

        //void RegisterNewContact();
    }
}
