using Hangfire;
using Hangfire.MemoryStorage;
using ApiHangMail.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHangfire(cfg => cfg.UseMemoryStorage());
builder.Services.AddHangfireServer();

builder.Services.AddSingleton<EmailService>();

builder.Services.AddControllers();
var app = builder.Build();

app.UseHangfireDashboard();

app.MapControllers();
app.MapGet("/", () => "API com Hangfire no ar!");

app.Run();

