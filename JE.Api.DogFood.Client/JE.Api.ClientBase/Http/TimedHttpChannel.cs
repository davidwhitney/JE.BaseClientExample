using System.Diagnostics;
using System.Net.Http;

namespace JE.Api.ClientBase.Http
{
    public class TimedHttpChannel : IHttpChannel
    {
        private readonly IHttpChannel _inner;

        public TimedHttpChannel(IHttpChannel inner)
        {
            _inner = inner;
        }

        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var response = _inner.Get(request);

            stopwatch.Stop();

            return response;
        }
    }
}