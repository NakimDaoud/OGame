using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO_O_Game
{
   public class SolarSystem : IDbEntity
    {

        public string Name { get; set; }

        public virtual List<Planet> Planets { get; set; }
    }
}
