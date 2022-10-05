using CursoArquitectura.Net.Application.Interfaces;
using CursoArquitectura.Net.Application.Services;
using CursoArquitectura.Net.Core.Repository;
using CursoArquitectura.Net.Core.Repository.Base;
using CursoArquitectura.Net.Infraestructure.Data;
using CursoArquitectura.Net.Infraestructure.Repository;
using CursoArquitectura.Net.Infraestructure.Repository.Base;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//COnfiguracion de implementacion del repository
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IProductRepository, ProductRepository>();
    //            (Interfaz de contrato )    (Clase de Implementacion)
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


//Utilizará una  base de datos en memoria
builder.Services.AddDbContext<CursoArquitecturaNetContext>(c =>
    // Y usara esta cadena de conexion
    c.UseInMemoryDatabase("CursoArquitecturaNetConnection"));

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
