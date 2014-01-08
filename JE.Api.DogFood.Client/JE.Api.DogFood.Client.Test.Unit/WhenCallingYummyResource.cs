using System;
using System.Net.Http;
using JE.Api.ClientBase.Http;
using Moq;
using NUnit.Framework;

namespace JE.Api.DogFood.Client.Test.Unit
{
    [TestFixture]
    public class WhenCallingYummyResource
    {
        private ClientConfiguration _configuration;
        private Uri _uri;
        private DogFoodClientApi _instance;
        private Mock<IHttpChannel> _mockHttp;

        [SetUp]
        public void SetUp()
        {
            _mockHttp = new Mock<IHttpChannel>();

            _uri = new Uri("http://uk-dogfood-iapi.just-eat.co.uk");
            _configuration = new ClientConfiguration();
            _instance = new DogFoodClientApi(_uri, _configuration, _mockHttp.Object);
        }

        [Test]
        public void GetYummy_ReturnsDtoFromMockApi()
        {
            var httpResponse = new HttpResponseMessage {Content = new StringContent(ApiStubJunk.FakeResponse)};
            _mockHttp.Setup(x => x.Get(It.IsAny<HttpRequestMessage>())).Returns(httpResponse);

            var response = _instance.Yummy.Get();

            Assert.That(response.MyThing, Is.EqualTo("hello"));
        }
    }
}