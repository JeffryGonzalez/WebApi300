var builder = WebApplication.CreateBuilder(args);
builder.AddServiceDefaults();

var app = builder.Build();

var customersGroup = app.MapGroup("/customers");
customersGroup.MapGet("/", () => "Get all customers");
customersGroup.MapGet("/{id}", (int id) => $"Get customer with ID {id}");
customersGroup.MapPost("/", () => "Create a new customer"); 


var products = app.MapGroup("/products");
products.MapGet("/", () => "Get all products");
products.MapGet("/{id}", (int id) => $"Get product with ID {id}");
products.MapPost("/", () => "Create a new product");

await Task.Delay(10);
app.MapDefaultEndpoints();
app.Run();