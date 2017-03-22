using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Garden.Models
{
    public class GardenBed
    {
        public int GardenBedID { get; set; } 
        public string BedLocation { get; set; }
        public string BedName { get; set; }
        public string BedDescription { get; set; }
        public string BedZone { get; set; }

        [Range(1,20)]
        public int BedLength { get; set; }
        [Range(1, 20)]
        public int BedWidth { get; set; }
        public int HoursOfSun { get; set; }

        //not sure if im gonna need a list of vegtables or varietys
        private List<Vegtable> vegtables = new List<Vegtable>();
        public List<Vegtable> Vegtables { get { return vegtables; } }

        //private List<VegVariety> varieties = new List<VegVariety>();
        //public List<VegVariety> Varieties { get { return varieties; } }

    }
}
