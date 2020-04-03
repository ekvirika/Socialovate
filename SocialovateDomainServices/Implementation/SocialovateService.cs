using SocialovateDB;
using SocialovateDomainDTOs;
using SocialovateDomainModels.Abstraction;
using SocialovateDomainModels.Implementation;
using SocialovateDomainServices.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialovateDomainServices.Implementation
{
    public class SocialovateService : ISocialovateService
    {
        public readonly DBWorkerService<IMessage> _messagesDB = default;
        public readonly DBWorkerService<IAccount> _accountsDB = default;
        private SocialovateService()
        {
            _messagesDB = new DBWorkerService<IMessage>(MessagesDB.Instance);
            _accountsDB = new DBWorkerService<IAccount>(AccountsDB.Instance);
        }
        private static ISocialovateService _instance = default;
        public static ISocialovateService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SocialovateService();
                }
                return _instance;
            }
        }

        public IAccount SignInUser(LoginDTO user)
        {
            var searchedUser = _accountsDB
                .Read()
                ?.FirstOrDefault(o => 
                o.User.Email == user.Email || o.Username == user.UserName && 
                o.Password == user.Password);

            if(searchedUser != null)
            {
                LoginHelperService.LoginUser(searchedUser);
            }
            return searchedUser;
        }

        bool ISocialovateService.RegisterNewUser(IAccount user)
        {
            return _accountsDB.Create(user);
        }

        public IAccount SearchAccount(string userName)
        {
            var user = _accountsDB
                           .Read()
                           .FirstOrDefault(o => o.Username == userName);
            return user;
        }

        public void SignOutUser()
        {
            LoginHelperService.LogOutUser();
        }
    }
}
