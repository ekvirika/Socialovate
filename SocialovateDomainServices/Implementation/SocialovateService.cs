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

        #region 
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
        #endregion

        #region User Services
        public IAccount SignInUser(LoginDTO user)
        {
            var searchedUser = _accountsDB
                .Read()
                ?.FirstOrDefault(o =>
                o.User.Email == user.Email || o.Username == user.UserName &&
                o.Password == user.Password);

            if (searchedUser != null)
            {
                LoginHelperService.LoginUser(searchedUser);
            }
            return searchedUser;
        }

        public bool RegisterNewUser(IAccount user)
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


        #endregion
        public ContactDTO SearchForContactInDB(string username)
        {
            var contactAccount = SearchAccount(username);
            var contact = new ContactDTO()
            {
                Name = contactAccount.User.Name,
                Surname = contactAccount.User.Surname,
                Email = contactAccount.User.Email,
                Username = contactAccount.Username
            };

            return contact;
        }

        public ContactDTO SearchUserContactByUsername(string username)
        {
            var contact = LoginHelperService
                .GetCurrentUser()
                .Contacts
                .FirstOrDefault(o => o.Username == username);
            return contact;
        }

        public void AddUserContact(IAccount account, ContactDTO contact)
        {
            account.Contacts.Add(SearchForContactInDB(contact.Username));
        }

        public List<ContactDTO> GetAllUserContacts(IAccount acc)
        {
            return acc.Contacts;
        }
    }
}
