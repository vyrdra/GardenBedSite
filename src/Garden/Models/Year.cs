using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garden.Models
{
    public class Year
    {
        public int YearID { get; set; }
        public int YearPlanted { get; set; }
        public string PlantingZone { get; set; }
        public DateTime ExpectedLastFrost { get; set; }
        public DateTime ActualLastFrost { get; set; }
        public DateTime ExpectedFirstFrost { get; set; }
        public DateTime ActualFirstFrost { get; set; }
    }
}
