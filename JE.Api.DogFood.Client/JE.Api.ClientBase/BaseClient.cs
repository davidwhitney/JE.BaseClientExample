using System;
using JE.Api.ClientBase.Http;
using JE.Api.ClientBase.Serialization;

namespace JE.Api.ClientBase
{
    public class BaseClient<TConfigurationType> : IBaseClient<TConfigurationType>
    {
        public Uri BaseUri { get; private set; }
        public TConfigurationType Configuration { get; private set; }

        public IHttpChannel Http { get; set; }
        public ISerializer Serializer { get; set; }

        public BaseClient(Uri baseUri, TConfigurationType configuration, IHttpChannel httpChannel = null, ISerializer serializer = null)
        {
            if (baseUri == null) throw new ArgumentNullException("baseUri");

            BaseUri = baseUri;
            Configuration = configuration;

            Http = httpChannel ?? new HttpChannel();
            Serializer = serializer ?? new JsonDotNetSerializer();

        }
    }
}