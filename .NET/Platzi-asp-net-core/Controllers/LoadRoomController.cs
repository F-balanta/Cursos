using Microsoft.AspNetCore.Mvc;
using Platzi_asp_net_core.Context;
using Platzi_asp_net_core.Models;
using System.Linq;

namespace Platzi_asp_net_core.Controllers
{
    [Route("LoadRoom")]
    public class LoadRoomController : Controller
    {
        private CeappContext _context;
        public IActionResult Index()
        {
            var loadroom = _context.LoadRooms.FirstOrDefault();
            return View(loadroom);
        }
        public LoadRoomController(CeappContext context)
        {
            _context = context;
        }
    }
}
