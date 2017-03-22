using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Garden.Models
{
    public class Vegtable
    {
        [Key]
        public int VegId { get; set; }

        [Required]
        public string VegName { get; set; }

        public string VegFamily { get; set; }

        public bool FullSun { get; set; }

        [Range(.125, 4)]
        public decimal SeedDepth { get; set; }

        [Range(.5, 12)]
        public decimal SeedSpacing { get; set; }

        [Range(.5, 12)]
        public int ThinTo { get; set; }

        [Range(1,20)]
        public int PlantsPerFt { get; set; }

        [Range(1, 36)]
        public int RowDistance { get; set; }

        public string IndoorSow { get; set; }

        public int SoilTemp { get; set; }

        public string FertilizerNeeds { get; set; }

        public string Transplant { get; set; }

        public string InsectProbblems { get; set; }

        public string DiseaseProblems { get; set; }

        public int DaysGerminationMin { get; set; }

        public int DaysGerminationMax { get; set; }

        public string Notes { get; set; }

        private List<VegVariety> varieties = new List<VegVariety>();
        public List<VegVariety> Varietys { get { return varieties; } }

        //private List<CompanionPlant> companions = new List<CompanionPlant>();
        //public List<CompanionPlant> Companions { get { return companions; } }

        public override bool Equals(object obj)
        {
            Vegtable vegObj = obj as Vegtable;
            if (vegObj == null)
                return false;
            else
                return VegName == vegObj.VegName;
        }

        public override int GetHashCode()
        {
            return VegId;
        }
        
    }
}
