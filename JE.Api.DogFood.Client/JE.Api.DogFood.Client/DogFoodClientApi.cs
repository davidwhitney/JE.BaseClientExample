using System;
using JE.Api.ClientBase;
using JE.Api.ClientBase.Http;
using JE.Api.ClientBase.Serialization;
using JE.Api.DogFood.Client.ApiClients;

namespace JE.Api.DogFood.Client
{
    public class DogFoodClientApi : BaseClient<ClientConfiguration>, IDogFoodClient
    {
        public IYummyResource Yummy { get; private set; }

        internal DogFoodClientApi(Uri baseUri, ClientConfiguration configuration, IHttpChannel httpChannel = null, ISerializer serializer = null)
            : base(baseUri, configuration, httpChannel, serializer)
        {
            Yummy = new YummyResource(this);
        }
    }
}