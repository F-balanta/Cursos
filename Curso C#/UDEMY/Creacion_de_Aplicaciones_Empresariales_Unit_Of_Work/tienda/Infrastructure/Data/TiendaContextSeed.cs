using System.Runtime.CompilerServices;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using CsvHelper;
using Core.Entities;

namespace Infrastructure.Data;
public class TiendaContextSeed
{
    public static async Task SeedAsync(TiendaContext context, ILoggerFactory loggerFactory)
    {
        try
        {
            // Obtiene la ubicacion de la aplicacion
            var ruta = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (!context.Marcas!.Any())
            {
                using (var readerMarcas = new StreamReader(ruta + @"/Data/Csvs/marcas.csv"))
                {
                    using (var csvMarcas = new CsvReader(readerMarcas, CultureInfo.InvariantCulture))
                    {
                        // Convertir el contenido del archivo  a Entity [Marca.cs]
                        var marcas = csvMarcas.GetRecords<Marca>();
                        // Agregamos el listado  de marcas
                        context.Marcas!.AddRange(marcas);
                        // Guardamos los cambios 
                        await context.SaveChangesAsync();
                    }
                }
            }

            if (!context.Categorias!.Any())
            {
                using (var readerCategorias = new StreamReader(ruta + @"/Data/Csvs/categorias.csv"))
                {
                    using (var csvCategorias = new CsvReader(readerCategorias, CultureInfo.InvariantCulture))
                    {
                        // Convertir el contenido del archivo  a Entity [Categorias.cs]
                        var categorias = csvCategorias.GetRecords<Categoria>();
                        // Agregamos el listado  de Categorias
                        context.Categorias!.AddRange(categorias);
                        // Guardamos los cambios 
                        await context.SaveChangesAsync();
                    }
                }
            }

            if (!context.Productos!.Any())
            {
                using (var readerProductos = new StreamReader(ruta + @"/Data/Csvs/productos.csv"))
                {
                    using (var csvProductos = new CsvReader(readerProductos, CultureInfo.InvariantCulture))
                    {
                        var listadoProductosCsv = csvProductos.GetRecords<Producto>();

                        List<Producto> productos = new List<Producto>();
                        foreach (var item in listadoProductosCsv) 
                        {
                            productos.Add(new Producto{
                                Id = item.Id,
                                Nombre = item.Nombre,
                                Precio = item.Precio,
                                FechaCreacion = item.FechaCreacion,
                                CategoriaId = item.CategoriaId,
                                MarcaId = item.MarcaId
                            });
                        }
                        context.Productos!.AddRange(productos);
                        await context.SaveChangesAsync();
                    }
                }
            }
        }
        catch (Exception ex)
        {

            var logger = loggerFactory.CreateLogger<TiendaContextSeed>();
            logger.LogError(ex.Message);
        }
    }

    public static async Task SeedRolesAsync(TiendaContext context, ILoggerFactory loggerFactory)
    {
        try
        {
            if (!context.Roles!.Any()) // Si no exixte ningún rol dentro de la base de datos
            {
                // Crearemos los siguientes
                var roles = new List<Rol>()
                {
                    new Rol {Id=1, Nombre="Administrador"},
                    new Rol {Id=2, Nombre="Gerente"},
                    new Rol {Id=3, Nombre="Empleado"},
                };
                context.Roles!.AddRange(roles);
                await context.SaveChangesAsync();
            }
        }
        catch (Exception ex)
        {

            var logger = loggerFactory.CreateLogger<TiendaContextSeed>();
            logger.LogError(ex.Message);
        }
    }
}