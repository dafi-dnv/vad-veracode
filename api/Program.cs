var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Ok(new { message = "Hello from .NET" }));

app.Run("http://localhost:5123");
