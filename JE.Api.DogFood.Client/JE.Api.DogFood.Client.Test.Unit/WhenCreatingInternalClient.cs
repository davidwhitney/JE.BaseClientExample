using System;
using JE.Api.DogFood.Client.ApiClients;
using NUnit.Framework;

namespace JE.Api.DogFood.Client.Test.Unit
{
    [TestFixture]
    public class WhenCreatingInternalClient
    {
        [Test]
        public void Constructed_YummyResourceNotNull()
        {
            var uri = new Uri("http://uk-dogfood-iapi.just-eat.co.uk");
            var configuration = new ClientConfiguration();
            var instance = new DogFoodClientApi(uri, configuration, null);
            
            Assert.That(instance.Yummy, Is.Not.Null);
        }
    }
}