using System.Linq.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        // Obtiene un registro por Identificador
        Task<T?> GetByIdAsync(int id);
        //? Obtiene todos los registros 
        Task<IEnumerable<T>> GetAllAsync();

        // Obtiene un conjunto de registros de acuedo a la exprecion LINQ que se utilice
        // Devuelve una lista de registros dependiendo de un criterio
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);

        // Metodo que obtiene de forma paginada los registros, así como el total de registros de contiene una paginacion
        Task<(int totalRegistros, IEnumerable<T> registros)> GetAllAsync(int pageIndex, int pageSize, string search);

        // Agrega un elemento al contexto
        void Add(T entity);

        // Agrega un lista de registros al contexto
        void AddRange(IEnumerable<T> entities);

        // Remueve un elemento o registro del contexto
        void Remove(T entity);

        // Remueve una lista de entidades del contexto
        void RemoveRange(IEnumerable<T> entities);
        //Actualiza un registro
        void Update(T entity);
    }
}