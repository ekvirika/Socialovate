using Newtonsoft.Json;
using SocialovateDomainDTOs;
using SocialovateDomainModels.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialovateDomainModels.Implementation
{
    public class Account : IAccount
    {
        private static int _id = 0;
        public Account() { AccountId = _id; _id++; }



        public string Password { get; set; }
        public int AccountId { get; set; }

        [JsonConverter(typeof(ConcreteConverter<User>))]
        public IUser User { get; set; }
        public string ImageUrl { get; set; }
        public List<ContactDTO> Contacts { get; set; } = new List<ContactDTO>(){};
        public List<IMessage> Messages { get; set; } = new List<IMessage>();
        public string Username { get; set; }
    }


    public class ConcreteConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType) => true;

        public override object ReadJson(JsonReader reader,
         Type objectType, object existingValue, JsonSerializer serializer)
        {
            return serializer.Deserialize<T>(reader);
        }

        public override void WriteJson(JsonWriter writer,
            object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}
