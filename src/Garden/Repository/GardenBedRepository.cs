using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Garden.Models;

namespace Garden.Repository
{
    public class GardenBedRepository : IGardenBedRepository
    {
        private GardenDbContext context;

        public GardenBedRepository(GardenDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<GardenBed> GetAllBeds()
        {
            return context.GardenBeds.Include(v => v.Vegtables);
        }
    }
}
