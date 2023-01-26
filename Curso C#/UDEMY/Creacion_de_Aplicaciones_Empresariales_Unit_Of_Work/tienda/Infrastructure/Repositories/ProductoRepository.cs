using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ProductoRepository : GenericRepository<Producto>, IProductoRepository
    {
        private readonly TiendaContext _context;

        public ProductoRepository(TiendaContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Producto>> ObtenerProductosmasCaros(int cantidad) =>
            await _context.Productos!.OrderByDescending(p => p.Precio)
            .Take(cantidad).ToListAsync();

        public override async Task<Producto?> GetByIdAsync(int id)
        {
            // Se incluyen la marca y Categoria del producto
            return await _context.Productos!
                .Include(c => c.Categoria)
                .Include(m => m.Marca).Where(c => c.Id == id)
                .FirstOrDefaultAsync();
        }

        public override async Task<IEnumerable<Producto>> GetAllAsync()
        {
            return await _context.Productos!
                .Include(c => c.Categoria)
                .Include(m => m.Marca)
                .ToListAsync();
        }

        public override async Task<(int totalRegistros, IEnumerable<Producto> registros)> GetAllAsync(int pageIndex, int pageSize, string search)
        {
            var consulta = _context.Productos as IQueryable<Producto>;

            if(!String.IsNullOrEmpty(search))
            {
                consulta = consulta!.Where(p=>p.Nombre.Contains(search));
            }

            var totalRegistros = await consulta!.CountAsync();

            var registros = await consulta!
                .Include(m => m.Marca)
                .Include(c => c.Categoria)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return (totalRegistros, registros);
        }
    }
}
