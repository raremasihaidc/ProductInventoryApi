using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProductsInventory;
using ProductsInventory.AutoMapper;
using ProductsInventory.Data;
using ProductsInventory.Handlers;
using ProductsInventory.Handlers.Interface;
using ProductsInventory.Repositories;
using ProductsInventory.Repositories.Interface;
using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient<IMapper, Mapper>();
builder.Services.AddHttpClient<IUnitOfWork, UnitOfWork>();
builder.Services.AddHttpClient<IProductRepository, ProductRepository>();
builder.Services.AddHttpClient<IProductReportRepository, ProductReportRepository>();
builder.Services.AddHttpClient<IProductRecieptRepository, ProductRecieptRepository>();
builder.Services.AddHttpClient<IProductGruopRepository, ProductGruopRepository>();
builder.Services.AddHttpClient<IProductTokrnRepository, ProductTokrnRepository>();
builder.Services.AddHttpClient<IProuductVoucherRepository, ProuductVoucherRepository>();
builder.Services.AddHttpClient<IProductGruopHandler, ProductGruopHandler>();
builder.Services.AddHttpClient<IProductHandler, ProductHandler>();
builder.Services.AddHttpClient<IProductRecieptHandler, ProductRecieptHandler>();
builder.Services.AddHttpClient<IProductReportHandler, ProductReportHandler>();
builder.Services.AddHttpClient<IProuductVoucherHandler, ProuductVoucherHandler>();
builder.Services.AddHttpClient<IProductTokrnHandler, ProductTokrnHandler>();

builder.Services.AddControllers();
builder.Services.AddDbContext<ProductDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString"), sqlServerOptionsAction: sqlOptions =>
    {
        sqlOptions.EnableRetryOnFailure();
        options.EnableSensitiveDataLogging();
    });
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program).Assembly);

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
