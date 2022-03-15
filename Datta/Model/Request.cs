using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcess.Model
{
    public class Request
    {
        public int load { get; set; }
        public Fuel fuels { get; set; }
        public IList<PowerPlant> powerPlants { get; set; }

    }
}
