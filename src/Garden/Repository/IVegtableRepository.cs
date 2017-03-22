using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Garden.Models;

namespace Garden.Repository
{
    public interface IVegtableRepository
    {
        IQueryable<Vegtable> GetAllVegtables();

        Vegtable GetVegByName(string name);
        int Update(Vegtable veg);
        Vegtable DeleteVeg(int vegID);
        bool CheckDb(string name);
    }
}
