using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class UnitOfWOrk : IUnitOfWork, IDisposable
    {
        // Como el contexto será compartido por todos los repositorios
        // creamos un contructor e inyectamos el contexto
        public UnitOfWOrk(TiendaContext context)
        {
            _context = context;
        }
        // En este punto creamos las propiedades privadas de cada repositorio
        private ProductoRepository? _productos;
        private TiendaContext? _context;
        private CategoriaRepository? _categorias;
        private MarcaRepository? _marcas;
        private UsuarioRepository? _usuarios;
        private RolRepository? _roles;

        // Al declarar la propiedad esta tendrá un valor nulo
        // por lo tanto ingresará en la condición inicializará la propiedad como repositorio y se le envía el contexto
        // Ya que cada repositorio hace uso de este
        // Es decir que cuando alguien intente ingresar el repositorio este será inicializado.
        // En caso contrario, si ya se está usando la devuelve
        public IProductoRepository Productos
        {
            get
            {
                if (_productos == null)
                    _productos = new ProductoRepository(_context!);
                return _productos;
            }
        }

        public ICategoriaRepository Categorias
        {
            get
            {
                if(_categorias == null)
                    _categorias = new CategoriaRepository(_context!);
                return _categorias;
            }
        }

        public IMarcaRepository Marcas
        {
            get
            {
                if(_marcas == null)
                    _marcas = new MarcaRepository(_context!);
                return _marcas;
            }
        }

        public IUsuarioRepository Usuarios
        {
            get
            {
                if (_usuarios == null)
                    _usuarios = new UsuarioRepository(_context!);
                return _usuarios;
            }
        }

        public IRolRepository Roles
        {
            get
            {
                if (_roles == null)
                    _roles = new RolRepository(_context!);
                return _roles;
            }
        }

        public async Task<int> Save()
        {
            return await _context?.SaveChangesAsync()!;
        }
        // Sirve para liberar los recursos de las memoria :(IDisposable)
        public async void Dispose()
        {
            await _context!.DisposeAsync();
        }
    }
}