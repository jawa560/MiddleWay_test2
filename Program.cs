using MiddleWay_test2.Middlewares;
using MiddleWay_test2.middleways;
using MiddleWay_test2.Models;

var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();

app.UseMiddleware<RequestLoggingMiddleware>();

app.UseMiddleware<FirstMiddleware>();
app.UseMiddleware<SecondMiddleware>();
app.UseMiddleware<ThirdMiddleware>();

app.MapGet("/", () => "Hello World!");

app.Run();
