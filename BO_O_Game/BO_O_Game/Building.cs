using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO_O_Game
{
    public abstract class Building : IDbEntity
    {
        [StringLength(20, MinimumLength = 5)]
        public string Name { get; set; }

        [Range(0, Int32.MaxValue)]
        public int? Level { get; set; }

        public abstract int? CellNB();


        public virtual List<Resource> TotalCost() {
            return null;
        }

        public virtual List<Resource> NextCost()
        {
            return null;
        }
    }
}
