using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO_O_Game
{
    public abstract class ResourceGenerator : Building
    {
        public override int? CellNB()
        {
            throw new NotImplementedException();
        }

        public virtual List<Resource> ResourceBySecond()
        {
            return null;
        }

        
    }
}
