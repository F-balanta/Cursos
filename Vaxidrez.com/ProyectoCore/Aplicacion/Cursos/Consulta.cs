 using System;
using System.Collections.Generic;
 using System.Linq;
 using System.Net;
 using System.Text;
 using System.Threading;
 using System.Threading.Tasks;
 using Aplicacion.ManejadorError;
 using Dominio;
 using MediatR;
 using Microsoft.EntityFrameworkCore;
 using Persistencia;

 namespace Aplicacion.Cursos
{
    public class Consulta
    {
        // Clase que representa los datos a retornar
        public class ListaCursos : IRequest<List<Curso>>{}


        public class Manejador : IRequestHandler<ListaCursos, List<Curso>>
        {
            private readonly CursosOnlineContext _context;

            public Manejador(CursosOnlineContext context)
            {
                _context = context;
            }

            public async Task<List<Curso>> Handle(ListaCursos request, CancellationToken cancellationToken)
            {
                var cursos = await _context.Curso.ToListAsync();
                return cursos;
            }
        }
    }
}
