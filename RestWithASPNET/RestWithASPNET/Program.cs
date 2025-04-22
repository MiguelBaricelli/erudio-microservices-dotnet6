var builder = WebApplication.CreateBuilder(args);

// Use a classe Startup para configurar a aplicação
var startup = new RestWithASPNET.Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);

var app = builder.Build();

startup.Configure(app, app.Environment);

app.Run();
