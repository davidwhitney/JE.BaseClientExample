using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace JE.Api.DogFood.Client.Test.Unit
{
    [TestFixture]
    public class WhenCreatingClient
    {
        private readonly Uri _uri = new Uri("http://uk-dogfood-iapi.just-eat.co.uk");
        

        [Test]
        public void Create_ValidUriSupplied_DoesntThrow()
        {
            var instance = DogFoodClient.Create(_uri);

            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void Create_NullSupplied_Throws()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => DogFoodClient.Create(null));

            Assert.That(ex.ParamName, Is.EqualTo("baseUri"));
        }

        [Test]
        public void Create_ValidUriSupplied_UrlCorrectlySetOnReturnedClient()
        {
            var instance = DogFoodClient.Create(_uri);

            Assert.That(instance.BaseUri, Is.EqualTo(_uri));
        }

        [Test]
        public void Create_ConfigurationSupplied_DoesntThrow()
        {
            var instance = DogFoodClient.Create(_uri, new ClientConfiguration());

            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void Create_ConfigurationSupplied_ConfigurationIsSetOnClient()
        {
            var config = new ClientConfiguration();

            var instance = DogFoodClient.Create(_uri, config);

            Assert.That(instance.Configuration, Is.EqualTo(config));
        }

        [Test]
        public void Create_ConfigurationNotSupplied_ConfigurationStillPresentWithDefaults()
        {
            var instance = DogFoodClient.Create(_uri, null);

            Assert.That(instance.Configuration, Is.Not.Null);
        }
    }
}
