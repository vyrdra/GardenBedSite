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
    public class AddController : Controller
    {
        private IVegtableRepository vegRepo;
        private IVegVarietyRepository varRepo;

        public AddController(IVegtableRepository repo, IVegVarietyRepository vRepo)
        {
            vegRepo = repo;
            varRepo = vRepo;
        }


        [HttpGet]
        public ViewResult Vegtable()
        {
            return View(new Vegtable());
        }

        [HttpPost]
        public ViewResult Vegtable(Vegtable veg)
        {  
            if (!vegRepo.CheckDb(veg.VegName))
            {
                vegRepo.Update(veg);
                ViewBag.Success = veg.VegName + " added to your garden.";
                return View(new Vegtable());
            }
            else
            {
                ViewBag.Success = veg.VegName + " already added to your garden.";
                return View(new Vegtable());
            }

        }    

        [HttpGet]
        public ViewResult Variety()
        {
            return View(new VegVariety());
        }

        [HttpPost]
        public ViewResult Variety(VegVariety var)
        {
            if (!varRepo.CheckDb(var.VarietyName))
            {
                Vegtable veg = vegRepo.GetVegByName(var.VegType.VegName);
                var.VegType = veg;
                varRepo.Update(var);
                ViewBag.Success = var.VarietyName + " added to your garden.";
                return View(new VegVariety());
            }
            else
            {
                ViewBag.Success = var.VarietyName + " already added to your garden.";
                return View(new VegVariety());
            }
           
        }
    }
}
