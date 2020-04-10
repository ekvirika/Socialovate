using MailKit.Net.Smtp;
using MimeKit;
using SocialovateDomainModels.Abstraction;
using SocialovateDomainServices.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialovateDomainServices.Implementation
{
    public class PasswordRecoveryService : IPasswordRecoveryService
    {
        public Func<string, IAccount> SearchAccountDel { get; set; }

        public bool SentForgotPasswordToUser(string userName)
        {
            try
            {
                var account = SearchAccountDel.Invoke(userName);
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(account.Username, account.User.Email));
                message.To.Add(new MailboxAddress(account.Username, account.User.Email));
                message.Subject = "Facebook password";
                message.Body = new TextPart("plain") { Text = $"Your password is {account.Password}" };

                using (SmtpClient client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false);
                    client.Authenticate("ekvirika8@gmail.com", "@");
                    client.Send(message);
                    client.Disconnect(true);
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
