using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Garden.Repository;
using Garden.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Garden.Controllers
{
    public class ListController : Controller
    {
        private IVegtableRepository vegRepo;
        private IVegVarietyRepository varRepo;

        public ListController(IVegtableRepository repo, IVegVarietyRepository vRepo)
        {
            vegRepo = repo;
            varRepo = vRepo;
        }


        public IActionResult YourVeg()
        {
            return View(vegRepo.GetAllVegtables().ToList());
        }

        [HttpGet]
        public ViewResult EditVeg(int vegID) => View(vegRepo.GetAllVegtables()
            .FirstOrDefault(v => v.VegId == vegID));

        [HttpPost]
        public ViewResult EditVeg(Vegtable veg)
        {
            vegRepo.Update(veg);
            return View("YourVeg", vegRepo.GetAllVegtables().ToList());
        }

        [HttpGet]
        public ViewResult EditVar(int varID) => View(varRepo.GetAllVarieties()
            .FirstOrDefault(v => v.VarietyId == varID));
        
        [HttpPost]
        public ViewResult EditVar(VegVariety var)
        {
            varRepo.Update(var);
            return View("YourVeg", vegRepo.GetAllVegtables().ToList());
        }

        [HttpPost] 
        public IActionResult DeleteVeg(int vegID)
        {
            Vegtable deletedVeg = vegRepo.DeleteVeg(vegID);
            if (deletedVeg != null)
            {
                return View("YourVeg", vegRepo.GetAllVegtables().ToList());
            }
            return View("YourVeg", vegRepo.GetAllVegtables().ToList());
        }

        [HttpPost]
        public IActionResult DeleteVar(int varID)
        {
            VegVariety deletedVar = varRepo.DeleteVar(varID);
            if (deletedVar != null)
            {
                return View("YourVeg", vegRepo.GetAllVegtables().ToList());
            }
            return View("YourVeg", vegRepo.GetAllVegtables().ToList());
        }
    }
}
