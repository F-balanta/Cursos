using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CursoArquitectura.Net.Core.Entities.Base;
using CursoArquitectura.Net.Core.Repository.Base;
using CursoArquitectura.Net.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CursoArquitectura.Net.Infraestructure.Repository.Base
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly CursoArquitecturaNetContext dbContext;

        // Se inyecta el contexto
        // Esto permitira hacer las diferentes acciones de o hacia la base de datos
        public Repository(CursoArquitecturaNetContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // Set<T>()  Usa en su momento la entidad que se le pase
        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            // Devuelve una Lista o Coleccion de datos correspondiente a su entidad
            return await dbContext.Set<T>().ToListAsync();
        }
        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate)
        {
            // Obtendra un dato
            return await dbContext.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            // Realiza una consulta de los datos en la bd por ID corespondiente  entidad que se le ha pasado
            return await dbContext.Set<T>().FindAsync(id);
        }

        public async Task<T> AddAsync(T entity)
        {
            //Agrega un nuevo valor correspondiente a la entidad que se le pase
            dbContext.Set<T>().Add(entity);
            // Se guardan los cambios
            await dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            // Solo cambiaran las entidades cuyo estado se ha modificado
            // Solo detecta las entidades cuyos valores han sido modificados y los actualiza
            dbContext.Entry(entity).State = EntityState.Modified;
            // Se guardan los cambios
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            // Remueve la entidad que lleve
            dbContext.Set<T>().Remove(entity);
            // Se guardan los cambios
            await dbContext.SaveChangesAsync();
        }
    }
}
