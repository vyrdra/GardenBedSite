using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Garden.Models
{
    public class VegVariety
    {
        [Key]
        public int VarietyId { get; set; }

        //a variety is a type of vegtable, and a vegtable has a list of varietys....
        public int VegId { get; set; }

        public Vegtable VegType { get; set; }

        [Required]
        public string VarietyName { get; set; }

        public string SupplierName { get; set; }

        public int YearPacked { get; set; }

        public string Description { get; set; }

        public string SpecialCharacteristics { get; set; }

        public int DaysToHarvest { get; set; }

        public bool? SpringPlant { get; set; }

        public bool? FallPlant { get; set; }

        public bool? Organic { get; set; }

        public bool? Heirloom { get; set; }
        
        public string Notes { get; set; }


        //private List<Vegtable> vegtable = new List<Vegtable>();
        //public List<Vegtable> Vegtable { get { return vegtable; } }
    }
}
