using System.Net.Http;

namespace JE.Api.ClientBase.Http
{
    public interface IHttpChannel
    {
        HttpResponseMessage Get(HttpRequestMessage request);
    }
}
