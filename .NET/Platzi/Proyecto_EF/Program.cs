using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_EF;
using Proyecto_EF.Models;

var builder = WebApplication.CreateBuilder(args);
// Configuracion para la base de datos en memoria
// String de conexion para entity framework utilizando una base de datos en memoria
//builder.Services.AddDbContext<TareasContext>(p => p.UseInMemoryDatabase("TareasDB"));

// Base de datos en servidor
//String de conexion para entity Framework utilizando una base de datos con todas sus credenciales desde un servidor
//Data Source Data source=BALANTIK\\SQLSERVER           (SERVIDOR)
// Initial Catalog=TareasDb                             (Nombre de la base de datos)
// User id=sa                                           (Usuario para la base de datos)
// password=2534                                        (Contraseña para la base de datos)
builder.Services.AddSqlServer<TareasContext>(builder.Configuration.GetConnectionString("cnTareas"));
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
// Mapeo de rutas
app.MapGet("/dbconexion", async ([FromServices] TareasContext dbContext) =>
{
    dbContext.Database.EnsureCreated();
    // Mensaje de la api
    return Results.Ok("Base de datos en memoria: " + dbContext.Database.IsInMemory());  
});
// Obtener Registros
app.MapGet("/api/tareas", async ([FromServices] TareasContext dbContext)=>
{
    return Results.Ok(dbContext.Tareas.Include(p=>p.Categoria));
});

// Agregar un Registro
app.MapPost("/api/tareas", async ([FromServices] TareasContext dbContext, [FromBody] Tarea tarea) =>
{
    tarea.TareaId = Guid.NewGuid();
    tarea.FechaCreacion = DateTime.Now;
    await dbContext.AddAsync(tarea);
    //await dbContext.Tareas.AddAsync(tarea);

    await dbContext.SaveChangesAsync();

    return Results.Ok();
});

//Actualizar Registros
app.MapPut("/api/tareas/{id}", async ([FromServices] TareasContext dbContext, [FromBody] Tarea tarea, [FromRoute] Guid id) =>
{
    var tareaActual = dbContext.Tareas.Find(id);

    if(tareaActual != null)
    {
        tareaActual.CategoriaId = tarea.CategoriaId;
        tareaActual.Titulo = tarea.Titulo;
        tareaActual.PropridadTarea = tarea.PropridadTarea;
        tareaActual.Descriptcion = tarea.Descriptcion;

        await dbContext.SaveChangesAsync();
        return Results.Ok();
    }
    return Results.NotFound();

});

app.MapDelete("/api/tareas/{id}", async ([FromServices]TareasContext dbContext, [FromRoute] Guid id) =>
{
    var tareaActual = dbContext.Tareas.Find(id);

    if(tareaActual != null)
    {
        dbContext.Remove(tareaActual);
        await dbContext.SaveChangesAsync();
        return Results.Ok();
    }
    return Results.NotFound();
});
// Corre la aplicacion
app.Run();
