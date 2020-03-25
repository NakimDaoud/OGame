using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO_O_Game
{
    public class Planet : IDbEntity
    {
        public string Name { get; set; }

        public int? CaseDB { get; set; }

        public virtual List<Resource> Resources { get; set; }

    }
}
