var builder = DistributedApplication.CreateBuilder(args);

var bigService = builder.AddProject<Projects.BigService_Api>("bigservice-api")
    .WithHttpHealthCheck("/health");
builder.Build().Run();