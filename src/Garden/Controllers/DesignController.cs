using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Garden.Models;
using Garden.Repository;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Garden.Controllers
{
    public class DesignController : Controller
    {
        private IVegtableRepository vegRepo;

        public DesignController(IVegtableRepository repo)
        {
            vegRepo = repo;
            
        }
        public IActionResult Design()
        {
            return View(new GardenBed());
        }
    }
}
