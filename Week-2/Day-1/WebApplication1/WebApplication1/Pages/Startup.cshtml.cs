using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Other service configurations
    }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // Other app configurations
        app.UseMiddleware<LoggingMiddleware>();
        // Other middleware or routing configurations
        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapGet("/", async context =>
            {
                await context.Response.WriteAsync("Hello, Middleware!");
            });
        });
    }
}
public class LoggingMiddleware
{
    private readonly RequestDelegate _next;
    public LoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task InvokeAsync(HttpContext context)
    {
        // Log request details
        Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");
        await _next(context);
    }
}















