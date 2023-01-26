using API.Extensions;
using API.Helpers.Errors;
using AspNetCoreRateLimit;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Reflection;
var builder = WebApplication.CreateBuilder(args);

// Creo la variable logger, la cual se va a leer desde appsettings la configuracion
var logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .Enrich.FromLogContext()
    .CreateLogger();
// Finalmente lo agrego al sistema de loggin integrado a NetCore
builder.Logging.AddSerilog(logger);

builder.Services.AddAutoMapper(Assembly.GetEntryAssembly());
builder.Services.ConfigureRateLimitiong();
builder.Services.ConfigureCors(); //! Configuración CORS
// Versionado
builder.Services.ConfigureApiVersioning();
// Configuracion TOken
builder.Services.AddJwt(builder.Configuration);

// Add services to the container.
builder.Services.AddControllers(options=>{
    // Opciones de configuración para recibir el header *Accept* del navegador
    options.RespectBrowserAcceptHeader = true;
    // Enviará un error en caso de que mi servidor no soporte el formato que el cliente solicita
    options.ReturnHttpNotAcceptable = true;

    })
    //Añadimos el formato XML
    .AddXmlSerializerFormatters();


// Agregando servicio para model State
builder.Services.AddValidationErrors();



// Servicio de conexion a la base de datos
var serverVersion = new MySqlServerVersion(new Version(8,0,30));
builder.Services.AddDbContext<TiendaContext>(options => {
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"), serverVersion);
});




// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplicationServices();

var app = builder.Build();
// Middleware Excepciones
app.UseMiddleware<ExceptionMiddleware>();

// Este método utiliza un controlador que se encarga de enviar el mensaje de error.
// En este caso el controlador se llamará errors el cual recibira un codigo
app.UseStatusCodePagesWithReExecute("/errors/{0}");


app.UseIpRateLimiting();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// Se creara la migracion pendiente cada vez que se ejecute la aplicacion
ApplicationServicesExtensions.ConfigureMigrations(app);

app.UseCors("CorsPolicy");//! Canalizacion de Peticiones
app.UseHttpsRedirection();
//Middleware de Autenticación
app.UseAuthentication();
app.UseAuthorization();

app.UseAuthorization();

app.MapControllers();

app.Run();
