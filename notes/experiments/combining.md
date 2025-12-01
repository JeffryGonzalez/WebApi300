


```csharp
if (app.Environment.IsDevelopment())
{
   
    app.MapGet("/docs", async (CombiningFilesTransform t,  HttpContext context, CancellationToken ct) =>
    {

        var docs = await t.GetOpenApiDocumentAsync(ct);

        var sb = new StringBuilder();
        var sw = new StringWriter(sb);
        
        var stream = new IndentedTextWriter(sw, "    ");

        var writer = new OpenApiJsonWriter(stream, new OpenApiJsonWriterSettings(), false);
        
        docs.SerializeAsV3(writer);
        
       
      
        await writer.FlushAsync(ct);
        
        return Results.Text(sb.ToString(), "application/json");

    });
}
```


```csharp
public class CombiningFilesTransform : IOpenApiDocumentProvider
{
    public async Task<OpenApiDocument> GetOpenApiDocumentAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        var settings = new OpenApiReaderSettings()
        {
        };
        var vendorsApi =
            await OpenApiDocument.LoadAsync("https://localhost:15100/openapi/bff.json", settings, cancellationToken);
        
        var catalogApi = await OpenApiDocument.LoadAsync("https://localhost:14100/openapi/bff.json", settings, cancellationToken);
        var bffApi = await OpenApiDocument.LoadAsync("https://gateway-dashboard.dev.localhost:9000/openapi/bff.json", settings, cancellationToken);
        
        var newPaths = bffApi.Document.Paths;
        foreach (var path in vendorsApi.Document.Paths)
        {
            if (newPaths.ContainsKey(path.Key)) continue;
            newPaths.Add(path.Key, path.Value);
        }   
        foreach (var path in catalogApi.Document.Paths)
        {
            if (newPaths.ContainsKey(path.Key)) continue;
            newPaths.Add(path.Key, path.Value);
        }
        bffApi.Document.Paths = newPaths;
        return bffApi.Document;
    }
}
```
