using System;

namespace JE.Api.DogFood.Client
{
    public interface IDogFoodClient
    {
        Uri BaseUri { get; }
        ClientConfiguration Configuration { get; }

        IYummyResource Yummy { get; }
    }
}