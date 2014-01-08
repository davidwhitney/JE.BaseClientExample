using System;
using Newtonsoft.Json;

namespace JE.Api.ClientBase.Serialization
{
    public class JsonDotNetSerializer : ISerializer
    {
        public T Deserialize<T>(string data)
        {
            return JsonConvert.DeserializeObject<T>(data);
        }

        public string Serialize(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
