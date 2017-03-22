using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garden.Models
{
    public class CompanionPlant
    {
        public int CompanionID { get; set; }
        public string PlantType { get; set; }
        public string PlantName { get; set; }
        public decimal SeedDepth { get; set; }
        public decimal SeedSpacing { get; set; }
        public int ThinTo { get; set; }
        public int PlantsPerFt { get; set; }
        public int RowDistance { get; set; }
        public string IndoorSow { get; set; }
        public int SoilTemp { get; set; }
        public string FertilizerNeeds { get; set; }
        public string Transplant { get; set; }
        public string InsectProbblems { get; set; }
        public string DiseaseProblems { get; set; }
        public string Notes { get; set; }
    }
}
