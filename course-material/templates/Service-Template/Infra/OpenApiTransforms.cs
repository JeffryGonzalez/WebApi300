using Microsoft.AspNetCore.OpenApi;
using Microsoft.OpenApi;

using SoftwareCenter.Core.OpenApiDocumentTransforms;

namespace {{namespace}}.Infra;

public class ServiceOpenApiTransform : SoftwareCenterOAuth2DocumentTransformer
{
    public override IDictionary<string, string> NeededScopes { get; set; } = new Dictionary<string, string>
    {
        /* TODO: Add Claims Here
        { "vendors.api", "Access the Vendors API" },
        { "openid", "Access the OpenID Connect user profile" }
        */
    };

    public override OpenApiInfo Info { get; set; } = new()
    {
        /* Todo: Update Info Here
        Title = "Vendors API",
        Version = "v1",
        Description = "API for managing vendors"
        */
    };
}


public class ServiceBffPathTransformer : BffPathTransformer
{
    public override string PathPrefix => ""; // TODO: Set BFF Path Prefix Here e.g. "/api/tacos"
}