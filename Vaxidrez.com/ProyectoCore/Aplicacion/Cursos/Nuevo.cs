using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Dominio;
using FluentValidation;
using MediatR;
using Persistencia;

namespace Aplicacion.Cursos
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            public string Titulo { get; set; }
            public string Descripcion { get; set; }
            public DateTime FechaPublicacion { get; set; }

            public List<Guid> ListaInstructor { get; set; }
        }

        public class EjecutaValidacion : AbstractValidator<Ejecuta>
        {
            public EjecutaValidacion()
            {
                RuleFor(x => x.Titulo).NotEmpty();
                RuleFor(x => x.Descripcion).NotEmpty();
                RuleFor(x => x.FechaPublicacion).NotEmpty();
            }
        }

        public class Manejador : IRequestHandler<Ejecuta>
        {
            private readonly CursosOnlineContext _context;

            public Manejador(CursosOnlineContext context)
            {
                _context = context;
            }


            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                // Creamos un nuevo Id (Guid)
                Guid _cursoId = Guid.NewGuid();

                // Aquí estamos creando un nuevo curso
                var curso = new Curso
                {
                    // _cursoId es un nuevo Guid que generamos desde el código
                    CursoId = _cursoId,
                    Titulo = request.Titulo,
                    Descripcion = request.Descripcion,
                    FechaPublicacion = request.FechaPublicacion
                };

                _context.Curso.Add(curso);

                // Insertando lista de instructores
                // Si desde Postman, enviamos la lista de instructores que queremos que estén regitrados
                // en el curso, entonces
                if (request.ListaInstructor != null)
                {
                    // Por cada ID de instructor que recibamos de Postman, haremos un registro en la tabla
                    // muchos a muchos CursoInstructor
                    foreach (var id in request.ListaInstructor)
                    {
                        var cursoInstructor = new CursoInstructor
                        {
                            // el ID que Detalle
                            CursoId = _cursoId,
                            // Añadimos el Id del instructor que nos llegó
                            InstructorId = id,
                        };
                        _context.CursoInstructor.Add(cursoInstructor);
                    }
                }


                var valor = await _context.SaveChangesAsync();
                Console.WriteLine("EL CODIGO DEL ERROR AL GUARDAR ES: " + valor);
                if (valor > 0)
                    return Unit.Value;
                throw new Exception("No se guardaron los cambios en el curso");
            }
        }

    }
}
