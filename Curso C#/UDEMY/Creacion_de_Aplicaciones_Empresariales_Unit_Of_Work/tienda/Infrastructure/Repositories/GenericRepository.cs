using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly TiendaContext _context;

        public GenericRepository(TiendaContext context)
        {
            _context = context;
        }


        public virtual async void Add(T entity)
        {
            // Recibe un tipo entity
            await _context.Set<T>().AddAsync(entity);
        }

        public virtual async void AddRange(IEnumerable<T> entities)
        {
            await _context.Set<T>().AddRangeAsync(entities);
        }

        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }
        
        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }
        
        public virtual async Task<(int totalRegistros, IEnumerable<T> registros)> GetAllAsync(int pageIndex, int pageSize, string search)//Paginacion basada en el numero de paginas y el total de registros
        {
            var totalRegistros = await _context.Set<T>().CountAsync();// Total de registros que hay en la base de datos
            var registros = await _context.Set<T>()
                // Salta (n) cantidad de elementos y devuelve una nueva cantidad con los elementos restantes
                .Skip((pageIndex - 1) * pageSize)
                // Toma (n) cantidad de elementos desde el inicio hasta la cantidad de elementos tomados
                .Take(pageSize)
                .ToListAsync();
            return (totalRegistros, registros);
        }

        public virtual async Task<T?> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public virtual void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public virtual void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }

        public virtual void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

    }
}