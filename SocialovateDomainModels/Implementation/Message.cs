using SocialovateDomainDTOs;
using SocialovateDomainModels.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialovateDomainModels.Implementation
{
    public class Message : IMessage
    {
        public string MessageText { get; set ; }
        public DateTime Time { get ; set ; }
        public int Id { get; set; }
        public MessagingUserDTO From { get; set; }
        public MessagingUserDTO To { get; set; }
    }
}
