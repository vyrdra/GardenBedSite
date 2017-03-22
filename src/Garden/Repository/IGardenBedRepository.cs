using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Garden.Models;

namespace Garden.Repository
{
    public interface IGardenBedRepository
    {
        IQueryable<GardenBed> GetAllBeds();
    }
}
