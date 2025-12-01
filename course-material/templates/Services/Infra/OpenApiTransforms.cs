using Microsoft.AspNetCore.OpenApi;
using Microsoft.OpenApi;

using SoftwareCenter.Core.OpenApiDocumentTransforms;

namespace **NameSpace**.Api.Infra;

public class **ApiName**OpenApiTransform : SoftwareCenterOAuth2DocumentTransformer
{
    public override IDictionary<string, string> NeededScopes { get; set; } = new Dictionary<string, string>
    {
    /*    { "vendors.api", "Access the Vendors API" },
        { "openid", "Access the OpenID Connect user profile" } */
    };

    public override OpenApiInfo Info { get; set; } = new()
    {
        Title = "",
        Version = "",
        Description = ""
    };
}

public class BffPathTransformer(string prefix) : IOpenApiDocumentTransformer
{
    public Task TransformAsync(OpenApiDocument document, OpenApiDocumentTransformerContext context,
        CancellationToken cancellationToken)
    {
        var newPaths = new OpenApiPaths();
        foreach (var newPath in document.Paths) newPaths.Add($"{prefix}{newPath.Key}", newPath.Value);
        document.Paths = newPaths;
        return Task.CompletedTask;
    }
}
