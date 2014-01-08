using System;
using JE.Api.ClientBase.Http;

namespace JE.Api.DogFood.Client
{
    public static class DogFoodClient
    {
        public static IHttpChannel ConfiguredChannel { get; set; }

        public static IDogFoodClient Create(Uri baseUri, ClientConfiguration configuration = null)
        {
            configuration = configuration ?? new ClientConfiguration();
            var channel = ConfiguredChannel ?? new HttpChannel();

            return new DogFoodClientApi(baseUri, configuration, channel);
        }

        public static void ConfigureChannel(IHttpChannel channel)
        {
            ConfiguredChannel = channel;
        }
    }
}
