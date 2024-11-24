using Microsoft.EntityFrameworkCore;
using phancongnhanvien.DataContext;
using phancongnhanvien.Payload.Converter;
using phancongnhanvien.Payload.DTO;
using phancongnhanvien.Payload.Response;
using phancongnhanvien.service.Inplement;
using phancongnhanvien.service.Interface;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();



builder.Services.AddScoped<IService_DuAn, Service_DuAn>();
builder.Services.AddScoped<AppDbContext>();
builder.Services.AddScoped<Converter_DuAn>();
builder.Services.AddScoped<ResponseBase>(); 
builder.Services.AddScoped<ResponseObject<DTO_DuAn>>();


builder.Services.AddScoped<IService_NhanVien, Service_NhanVien>();
builder.Services.AddScoped<Converter_NhanVien>();
builder.Services.AddScoped<ResponseObject<DTO_NhanVien>>();



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
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
