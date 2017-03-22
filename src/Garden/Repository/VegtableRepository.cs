using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Garden.Models;

namespace Garden.Repository
{
    public class VegtableRepository : IVegtableRepository
    {
        private GardenDbContext context;

        public VegtableRepository(GardenDbContext ctx)
        {
            context = ctx;
        }

        //public IEnumerable<Vegtable> Vegtables => context.Vegtables;

        public IQueryable<Vegtable> GetAllVegtables()
        {
            return context.Vegtables.Include(v => v.Varietys);
        }

        public Vegtable GetVegByName(string name)
        {
            return context.Vegtables.First(v => v.VegName == name); //hmmm this wont include the varieties of veg.....
        }

        //public List<Vegtable> GetVarsByVegName(string name)
        //{
        //    return context.Vegtables.Include(y => y.Varietys).Where(v => v.VegName == name);
        //}


            //TODO add delete vegtable

        public bool CheckDb(string name)
        {
            Vegtable vg = context.Vegtables.FirstOrDefault(v => v.VegName == name);
            
            if (vg == null)
                return false; //not in db
            else
                return true; //is in the db
        }
        
        public int Update(Vegtable veg)
        {
            //if not in the database add
            if (!CheckDb(veg.VegName))
            {
                context.Vegtables.Add(veg);
            }
            else //or get the veg and update
            {
                Vegtable dbV = context.Vegtables.First(v => v.VegName == veg.VegName);
                dbV.VegName = veg.VegName;
                dbV.VegFamily = veg.VegFamily;
                dbV.DaysGerminationMin = veg.DaysGerminationMin;
                dbV.DaysGerminationMax = veg.DaysGerminationMax;
                dbV.DiseaseProblems = veg.DiseaseProblems;
                dbV.FertilizerNeeds = veg.FertilizerNeeds;
                dbV.FullSun = veg.FullSun;
                dbV.IndoorSow = veg.IndoorSow;
                dbV.InsectProbblems = veg.InsectProbblems;
                dbV.Notes = veg.Notes;
                dbV.PlantsPerFt = veg.PlantsPerFt;
                dbV.RowDistance = veg.RowDistance;
                dbV.SeedDepth = veg.SeedDepth;
                dbV.SeedSpacing = veg.SeedSpacing;
                dbV.SoilTemp = veg.SoilTemp;
                dbV.ThinTo = veg.ThinTo;
                dbV.Transplant = veg.Transplant;
            }

            return context.SaveChanges();
        }

        public Vegtable DeleteVeg(int vegID)
        {
            Vegtable dbVeg = context.Vegtables.FirstOrDefault(v => v.VegId == vegID);
            if (dbVeg != null)
            {
                context.Vegtables.Remove(dbVeg);
                context.SaveChanges();
            }
            return dbVeg;
        }
        
    }
}
