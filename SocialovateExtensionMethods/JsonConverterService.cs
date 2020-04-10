using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialovateExtensionMethods
{
    public static class JsonConverterService
    {
        public static string Stringify<T>(this T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static T ParseSingleObject<T>(this string jsonText)
        {
            return JsonConvert.DeserializeObject<T>(jsonText);
        }

        public static List<T> ParseList<T>(this string jsonText)
        {
            return JsonConvert.DeserializeObject<List<T>>(jsonText);
        }
    }
}
