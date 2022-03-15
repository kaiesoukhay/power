using DataAcess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcess.Repository
{
    public interface IPowerPlantRepo
    {
        public Response productionplan(Request R); 
    }
}
