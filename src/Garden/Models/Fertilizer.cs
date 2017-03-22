using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garden.Models
{
    public class Fertilizer
    {

        public int FertilizerID { get; set; }
        public string FertilizerName { get; set; }
        public string Formula { get; set; }
        public string FertilizerType { get; set; }
        public string ApplicationRate { get; set; }
        public string Notes { get; set; }

    }
}
