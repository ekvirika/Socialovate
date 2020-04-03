using SocialovateDomainDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialovateDomainModels.Abstraction
{
    public interface IMessage
    {
        int Id { get; set; }
        MessagingUserDTO From { get; set; }
        MessagingUserDTO To { get; set; }
        string MessageText { get; set; }
        DateTime Time { get; set; }
    }
}
