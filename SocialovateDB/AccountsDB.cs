using Newtonsoft.Json;
using SocialovateDomainModels.Abstraction;
using SocialovateDomainModels.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialovateDB
{
    public class AccountsDB : TableDB<IAccount>
    {
        private string _path = "Accounts.json";
        public FileWorkerService _fileWorker = default;
        private AccountsDB() { 
            _accounts = new List<IAccount>();
            _fileWorker = new FileWorkerService();
        }
        private static TableDB<IAccount> _instance = null;
        public static TableDB<IAccount> Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AccountsDB();
                }

                return _instance;
            }
        }
        private List<IAccount> _accounts = null;
        public override void Create(IAccount account)
        {
            var userExistence = _accounts
                .FirstOrDefault(o => o.Username == account.Username || o.User.Email == account.User.Email);
            if (userExistence != null)
            {
                throw new Exception();
            }

            _accounts = Read();
            _accounts.Add(account);
            _fileWorker.WriteInFile(JsonConvert.SerializeObject(_accounts), _path);

        }

        public override List<IAccount> Read()
        {
            var accountsFromFile = _fileWorker.ReadFromFile(_path);
            if (accountsFromFile.Length > 0)
            {
                _accounts = (JsonConvert.DeserializeObject<List<Account>>(accountsFromFile)).ToList<IAccount>();
            }
            return _accounts;
        }

        public override void Update(IAccount account)
        {
            var currentElement = _accounts.FirstOrDefault(o => o.AccountId == account.AccountId);
            var elemIndex = _accounts.IndexOf(currentElement);
            _accounts[elemIndex] = account;
        }

        public override void Delete(IAccount account)
        {
            _accounts.Remove(account);
        }
    }
}
