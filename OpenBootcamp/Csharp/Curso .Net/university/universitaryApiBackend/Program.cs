// 1. usings to work wit EntityFramework
using Microsoft.EntityFrameworkCore;
using universitaryApiBackend.DataAcces;

var builder = WebApplication.CreateBuilder(args);



// 2. Connection with SQL Server
const string CONNECTIONNAME = "universityDB";
// Obtener conexion
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);
// 3. Add Context
builder.Services.AddDbContext<UniversityDBContext>(options => options.UseSqlServer(connectionString));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//BUILDER Construye las configuraciones de la aplicacion
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
