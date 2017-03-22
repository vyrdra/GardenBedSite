using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Garden.Models;


namespace Garden.Repository
{
    public interface IVegVarietyRepository
    {
        IQueryable<VegVariety> GetAllVarieties();

        VegVariety GetVarByName(string name);
        int Update(VegVariety var);
        VegVariety DeleteVar(int varID);
        bool CheckDb(string name);

    }
}
