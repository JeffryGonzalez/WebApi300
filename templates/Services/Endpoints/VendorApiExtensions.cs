

namespace YOUR_NAMESPACE

public static class YOUR_NAMEApiExtensions
{
    extension<TBuilder>(TBuilder source) where TBuilder : IHostApplicationBuilder
    {
        public TBuilder AddVendors()
        {
            return source;
        }
    }

    extension(IEndpointRouteBuilder endpoints)
    {
        public IEndpointRouteBuilder MapYOURNAME()
        {
            var group = endpoints.MapGroup("/YOUR_GROUP")
                .WithTags("YOUR TAG");


            // Your Endpoints Here
            return endpoints;
        }
    }
}