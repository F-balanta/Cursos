using Aplicacion.Contratos;
using Aplicacion.Cursos;
using Dominio;
using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Persistencia;
using Seguridad.TokenSeguridad;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using WebAPI.Middleware;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Se añade un servicio que permitira el uso de EntityFramework en el proyecto
            services.AddDbContext<CursosOnlineContext>(opt =>
            {
                opt.UseSqlServer(Configuration.GetConnectionString("DefaultConection"));
            });
            // Servicio SQRS
            services.AddMediatR(typeof(Consulta.Manejador).Assembly);

            // Este servicio permite el uso de controladores para el mapeo de rutas
            services.AddControllers(opt =>
            {
                // Se crea una regla que se aplicara en todos los metodos de los controladores.
                // Esta regla va a requerir que el usuario esté autenticado
                var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
                opt.Filters.Add(new AuthorizeFilter(policy));
                // Esto hara que el controlador tenga la autorizacion antes de procesar el request de un cliente
            });


            // Servicio para agregar validaciones Fluent
            services.AddFluentValidationAutoValidation();
            services.AddValidatorsFromAssemblyContaining<Nuevo>();

            // Agregar  CoreIdentity
            // Añadimos como servicio el IdentityCore, y le indicamos cuál será la clase que manejará el Usuario
            var builder = services.AddIdentityCore<Usuario>();
            var identityBuilder = new IdentityBuilder(builder.UserType, builder.Services);
            identityBuilder.AddEntityFrameworkStores<CursosOnlineContext>();
            identityBuilder.AddSignInManager<SignInManager<Usuario>>();

            services.TryAddSingleton<ISystemClock, SystemClock>();

            //variable llamada key y colocamos la palabra clave puesta dentro del Token
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Mi palabra sacreta"));
            // NO permite consumir los endpoints desde afuera
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
            {
                // En esta seccion indicamos que parametros se le van a dar al Token y tambien las restricciones
                opt.TokenValidationParameters = new TokenValidationParameters
                {
                    // Indica que cualquier tipo de request de un cliente debe ser validado.
                    ValidateIssuerSigningKey = true,
                    // Se le pasa la palabra clave que se designo en el proyecto aplicacion
                    IssuerSigningKey = key,
                    // QUien va a poder crear los tokens
                    ValidateAudience = false,
                    // La validacion y el token  se le envian a  cualquier persona
                    ValidateIssuer = false

                };
            });

            services.AddScoped<IJwtGenerador, JwtGenerador>();


            services.AddScoped<IUsuarioSesion, UsuarioSesion>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMiddleware<ManejadorErrorMiddleware>();
            if (env.IsDevelopment())
            {
                //app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            // Indica que la aplicacion usara la Autenticacion
            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
