using Microsoft.OpenApi.Models;
using ProductApi.Interfaces;
using ProductApi.Middlewares;
using ProductApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Product API", Version = "v1" });
});

var app = builder.Build();

app.UseSwagger();

app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Product API V1");
    c.RoutePrefix = "swagger";
});

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseMiddleware<ErrorHandlerMiddleware>();

app.Run();