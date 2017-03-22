using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Garden.Models;

namespace Garden.Repository
{
    public class VegVarietyRepository : IVegVarietyRepository
    {
        private GardenDbContext context;

        public VegVarietyRepository(GardenDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<VegVariety> GetAllVarieties()
        {
            return context.VegVarieties;
        }

        public VegVariety GetVarByName(string name)
        {
            return context.VegVarieties.First(v => v.VarietyName == name);
        }

        public bool CheckDb(string name)
        {
            VegVariety vg = context.VegVarieties.FirstOrDefault(v => v.VarietyName == name);

            if (vg == null)
                return false; //not in db
            else
                return true; //is in the db
        }

        public int Update(VegVariety var)
        {
            if (!CheckDb(var.VarietyName))
            {
                context.VegVarieties.Add(var);
            }   
            else
            {
                VegVariety dbVar = context.VegVarieties.FirstOrDefault(v => v.VarietyName == var.VarietyName);
                Vegtable dbVeg = context.Vegtables.First(v => v.VegName == var.VegType.VegName);

                dbVar.VarietyName = var.VarietyName;
                dbVar.VegType = var.VegType;
                dbVar.SupplierName = var.SupplierName;
                dbVar.Description = var.Description;
                dbVar.DaysToHarvest = var.DaysToHarvest;
                dbVar.SpecialCharacteristics = var.SpecialCharacteristics;
                dbVar.SpringPlant = var.SpringPlant;
                dbVar.Organic = var.Organic;
                dbVar.Heirloom = var.Heirloom;
                dbVar.YearPacked = var.YearPacked;            
            }
                

            return context.SaveChanges();
        }

        public VegVariety DeleteVar(int varID)
        {
            VegVariety dbVar = context.VegVarieties.FirstOrDefault(v => v.VarietyId == varID);
            if (dbVar != null)
            {
                context.VegVarieties.Remove(dbVar);
                context.SaveChanges();
            }
            return dbVar;
        }

    }
}
