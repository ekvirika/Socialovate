using SocialovateDomainModels.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialovateDomainServices.Abstraction
{
    public interface IPasswordRecoveryService
    {
        Func<string, IAccount> SearchAccountDel { get; set; }
        bool SentForgotPasswordToUser(string userName);
    }
}
