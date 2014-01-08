using System;
using System.Net.Http;
using JE.Api.DogFood.Client.Model;

namespace JE.Api.DogFood.Client.ApiClients
{
    internal class YummyResource : IYummyResource
    {
        private readonly DogFoodClientApi _client;

        public YummyResource(DogFoodClientApi client)
        {
            _client = client;
        }

        public ThisDto Get()
        {
            var yummyUri = new Uri(_client.BaseUri, "yummy");

            var request = new HttpRequestMessage(HttpMethod.Get, yummyUri);

            var response = _client.Http.Get(request);
            var rawContent = response.Content.ReadAsStringAsync().Result;

            return _client.Serializer.Deserialize<ThisDto>(rawContent);
        }
    }
}