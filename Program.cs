using Microsoft.EntityFrameworkCore;
using Tech_Potential_Challenge_Payment_API.Contexts;
using Tech_Potential_Challenge_Payment_API.Repositories;
using Tech_Potential_Challenge_Payment_API.Repositories.Interfaces;
using Tech_Potential_Challenge_Payment_API.Services;
using Tech_Potential_Challenge_Payment_API.Services.Interfaces;
using Tech_Potential_Challenge_Payment_API.UoW;
using Tech_Potential_Challenge_Payment_API.UoW.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddDbContext<DataContext>(options => options.UseInMemoryDatabase("dbSellers"));
builder.Services.AddScoped<DataContext, DataContext>();

builder.Services.AddScoped<IUnityOfWork, UnityOfWork>();

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ISellerRepository, SellerRepository>();
builder.Services.AddScoped<ISaleRepository, SaleRepository>();
builder.Services.AddScoped<ISaleItemsRepository, SaleItemsRepository>();

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ISellerService, SellerService>();
builder.Services.AddScoped<ISaleService, SaleService>();

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
