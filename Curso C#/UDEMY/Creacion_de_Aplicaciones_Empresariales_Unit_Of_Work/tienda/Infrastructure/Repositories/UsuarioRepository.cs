using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
    {
        private readonly TiendaContext _context;

        public UsuarioRepository(TiendaContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Usuario?> GetByRefreshTokenAsync(string refreshToken)
        {
           var usuario = await _context.Usuarios!
                .Include(u => u.Roles)
                .Include(u => u.RefreshTokens)
                // Verificamos si este token pertenece a algún usuario
                .FirstOrDefaultAsync(u => u.RefreshTokens!.Any(t=>t.Token == refreshToken));
            // En caso de que exista  devolverá el usuario que es dueño de ese refreshToken
            return usuario;
        }

        public async Task<Usuario?> GetByUsernameAsync(string username)
        {
            return await _context.Usuarios!
                .Include(u=>u.Roles)
                .Include(u=>u.RefreshTokens)
                .FirstOrDefaultAsync(u => u.Username.ToLower() == username.ToLower());
        }
    }
}
