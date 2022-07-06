using Microsoft.AspNetCore.Mvc;
using Platzi_asp_net_core.Context;
using Platzi_asp_net_core.Models;
using System.Collections.Generic;
using System.Linq;

namespace Platzi_asp_net_core.Controllers
{
    [Route("EquipmentLoan")]
    public class EquipmentLoanController : Controller
    {
        private CeappContext _context;
        
        [Route("{id}")]
        public IActionResult Index(int id)
        {
            if (id != null)
            {
                var model = from e in _context.equipmentLoans
                            where e.User_Id == id
                            select e;
                return View(model.FirstOrDefault());
            }
            else{ return View(_context.equipmentLoans.FirstOrDefault()); }}
        public EquipmentLoanController(CeappContext context)
        {
            _context = context;
        }

        [Route("Multi")]
        public IActionResult MultiEquipmentLoan()
        {
            var devices = new List<EquipmentLoan>()
            {
                new EquipmentLoan{
                    Id = 1,
                    User_Id = 3015875,
                    Room_Id = 1,
                    DeliverDate = System.DateTime.Today,
                    DateReceived = System.DateTime.UtcNow,
                    Observation = "Faltaron los cables"
                },
                new EquipmentLoan{
                    Id = 2,
                    User_Id = 1151970349,
                    Room_Id = 2,
                    DeliverDate = System.DateTime.Today,
                    DateReceived = System.DateTime.UtcNow,
                    Observation = "Faltaron los cables"
                },
                new EquipmentLoan{
                    Id = 3,
                    User_Id = 32567457,
                    Room_Id = 3,
                    DeliverDate = System.DateTime.Today,
                    DateReceived = System.DateTime.UtcNow,
                    Observation = "Faltaron los cables"
                },
                new EquipmentLoan{
                    Id = 4,
                    User_Id = 456789123,
                    Room_Id = 4,
                    DeliverDate = System.DateTime.Today,
                    DateReceived = System.DateTime.UtcNow,
                    Observation = "Faltaron los cables"
                },
                new EquipmentLoan{
                    Id = 1,
                    User_Id = 321564899,
                    Room_Id = 5,
                    DeliverDate = System.DateTime.Today,
                    DateReceived = System.DateTime.UtcNow,
                    Observation = "Faltaron los cables"
            }};
            return View("MultiEquipmentLoan", devices);
        }
    }
}
