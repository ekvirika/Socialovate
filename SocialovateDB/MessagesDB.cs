using SocialovateDomainModels.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialovateDB
{
    public class MessagesDB : TableDB<IMessage>
    {
        private MessagesDB() { _messages = new List<IMessage>(); }
        private static TableDB<IMessage> _instance = default;
        public static TableDB<IMessage> Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MessagesDB();
                }
                return _instance;
            }
        }

        List<IMessage> _messages = default;

        public override void Create(IMessage obj)
        {
            _messages.Add(obj);
        }

        public override void Delete(IMessage obj)
        {
            _messages.Remove(obj);
        }

        public override List<IMessage> Read()
        {
            return _messages;
        }

        public override void Update(IMessage obj)
        {
            var currentElement = _messages.FirstOrDefault(o => o.Id == obj.Id);
            var elemIndex = _messages.IndexOf(currentElement);
            _messages[elemIndex] = obj;
        }
    }
}
