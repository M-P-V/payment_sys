using Payment.System.Transactions.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();

var app = builder.Build();
app.MapGrpcService<GreeterService>();
app.MapGet("/health",() => "Ok");

app.Run();
