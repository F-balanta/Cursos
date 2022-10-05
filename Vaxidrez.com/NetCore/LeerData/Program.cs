using LeerData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new AppVentaCursosContext())
            {
                var cursos = db.Curso.Include(c => c.InstructorLink).ThenInclude(ci=>ci.Instructor);

                foreach(var curso in cursos)
                {
                    Console.WriteLine(curso.Titulo);
                    foreach(var insLink in curso.InstructorLink)
                    {
                        Console.WriteLine("**********" + insLink.Instructor.Nombre);
                    }
                }


                //var cursos = db.Curso.Include(c => c.ComentarioLista).AsNoTracking();
                //foreach (var curso in cursos)
                //{
                //    Console.WriteLine(curso.Titulo);
                //    foreach (var comentario in curso.ComentarioLista)
                //    {
                //        Console.WriteLine("*********************" + comentario.ComentarioTexto);
                //    }
                //}
                
                
                
                //var cursos = db.Curso.Include(p => p.PrecioPromocion).AsNoTracking();
                //foreach(var curso in cursos)
                //{
                //    Console.WriteLine(curso.Titulo + "------" + curso.PrecioPromocion.PrecioActual);
                //}





                //// Almacenara toda la data que venga del sqlserver
                //var cursos = db.Curso.AsNoTracking(); // Devuelve un arreglo de Iqueryable
                //foreach(var curso in cursos)
                //{
                //    Console.WriteLine(curso.Titulo + "------" + curso.Descripcion);
                //}

            }

        }
    }
}
