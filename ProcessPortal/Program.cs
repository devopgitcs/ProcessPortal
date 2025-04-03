// ProcessPortal/Program.cs
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Define a simple GET endpoint
app.MapGet("/", () => "Hello from .NET 8 Minimal API!");

app.Run();

