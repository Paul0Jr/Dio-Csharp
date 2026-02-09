using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi;
using Microsoft.EntityFrameworkCore;
using API.Context;

var builder = WebApplication.CreateBuilder();

builder.Services.AddDbContext<ScheduleContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("BaseConnection")));
builder.Services.AddOpenApi();
builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "v1");
    });
}

//app.UseHttpsRedirection();
app.MapControllers();
app.Run();