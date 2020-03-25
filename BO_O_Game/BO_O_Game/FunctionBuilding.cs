using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO_O_Game
{
    class FunctionBuilding : Building
    {
        public List<Action> Actions() {
            return null;
        }

        public override int? CellNB()
        {
            throw new NotImplementedException();
        }
    }
}
