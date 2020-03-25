using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO_O_Game
{
    public class Resource : IDbEntity
    {
        public string Name { get; set; }
        public int? LastQuantity { get; set; }

        public DateTime LastUpdate { get; set; }


    }
}
