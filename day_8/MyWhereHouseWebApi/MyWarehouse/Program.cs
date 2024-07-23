using BusinessLayer;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using static System.Net.Mime.MediaTypeNames;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ProductRepository>(options=>options.UseNpgsql(builder.GetConnectionString("DbConnection")));// Здесь ошибка

builder.Services.AddScoped<IProductRepository,ProductRepository>();


//builder.Services.AddSingleton<IProductRepository, ProductRepository>();
//builder.Services.AddSingleton<ICommandLineStrategyResolver, CommandLineStrategyResolver>();
//builder.Services.AddSingleton<ICommandLineStrategy, GetProductsStrategy>();
//builder.Services.AddSingleton<ICommandLineStrategy, AddProductStrategy>();
//builder.Services.AddSingleton<ICommandLineStrategy, SellProductStrategy>();
//builder.Services.AddSingleton<ICommandLineStrategy, DeleteProductStrategy>();
//builder.Services.AddSingleton<ICommandLineStrategy, CloseApplicationStrategy>();
var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
