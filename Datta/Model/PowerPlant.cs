using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcess.Model
{
    public class PowerPlant
    {
        public string name { get; set; }
        public string type { get; set; }
        public int efficiency { get; set; }
        public int pmin { get; set; }
        public int pmax { get; set; }
    }
}
