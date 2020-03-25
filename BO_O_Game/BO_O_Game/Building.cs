using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO_O_Game
{
    public abstract class Building : IDbEntity
    {
        public string Name { get; set; }

        public int? Level { get; set; }

        public abstract int? CellNB();


        public List<Resource> TotalCost() {
            return null;
        }

        public List<Resource> NextCost()
        {
            return null;
        }
    }
}
