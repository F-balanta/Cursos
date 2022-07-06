using Microsoft.AspNetCore.Mvc;
using Platzi_asp_net_core.Context;
using Platzi_asp_net_core.Models;
using System.Linq;
using System.Collections.Generic;

namespace Platzi_asp_net_core.Controllers
{
    [Route("User")]
    public class UserController : Controller
    {
        private CeappContext _context;
        [Route("{id}")]
        public IActionResult Index(int id)
        {
            var user = from u in _context.Users
                       where u.Id == id
                       select u;
            return View(user.FirstOrDefault());
        }
        [Route("Multi")]
        public IActionResult MultiUsers()
        {
            var Users = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    Role = Role.Student,
                    DNI = 11970347,
                    Nombres = "Juan Felipe",
                    Apellidos = "Balanta Rentería",
                },
                new User()
                {
                    Id = 2,
                    DNI = 1151970348,
                    Role = Role.Administrator,
                    Nombres = "Juan David",
                    Apellidos = "Balanta Renteria",
                },
                new User()
                {
                    Id = 3,
                    DNI = 1151970348,
                    Role = Role.Concierge,
                    Nombres = "Victor David",
                    Apellidos = "Perea Perea"
                }
            };
            return View("MultiUsers", Users);

        }
        [Route("Create")]
        public IActionResult Create()
        {
            return View();
        }
        public UserController(CeappContext context)
        {
            _context = context;
        }
    }

}
