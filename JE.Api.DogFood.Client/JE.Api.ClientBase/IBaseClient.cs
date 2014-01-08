using System;
using JE.Api.ClientBase.Http;
using JE.Api.ClientBase.Serialization;

namespace JE.Api.ClientBase
{
    public interface IBaseClient<out TConfigurationType>
    {
        Uri BaseUri { get; }
        TConfigurationType Configuration { get; }
        IHttpChannel Http { get; set; }
        ISerializer Serializer { get; set; }
    }
}