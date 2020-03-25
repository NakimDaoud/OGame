using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO_O_Game
{
    public class OxygenGenerator : ResourceGenerator
    {
        override public List<Resource> TotalCost()
        {
            List<Resource> resources = new List<Resource>();
            Resource energie = new Resource { Name = EnumResource.ENERGIE.ToString(), LastUpdate = DateTime.Now, LastQuantity = 0 };
            Resource oxygene = new Resource { Name = EnumResource.OXYGENE.ToString(), LastUpdate = DateTime.Now, LastQuantity = 0 };
            Resource uranium = new Resource { Name = EnumResource.URANIUM.ToString(), LastUpdate = DateTime.Now, LastQuantity = 0 };
            Resource acier = new Resource { Name = EnumResource.ACIER.ToString(), LastUpdate = DateTime.Now, LastQuantity = 0 };

            for (int i = 1; i <= Level; i++)
            {
                energie.LastQuantity += i;
                oxygene.LastQuantity += (200 * (i / 12)) + 20;
                acier.LastQuantity += (1000 * (i / 8)) + 20;
                uranium.LastQuantity += (1500 * (i / 20)) + 20;
            }
            resources.Add(energie);
            resources.Add(oxygene);
            resources.Add(acier);
            resources.Add(uranium);

            return resources;
        }

        override public List<Resource> NextCost()
        {

            List<Resource> resources = new List<Resource>();
            int? energie = 1;
            if (this.Level == null)
            {
                energie = energie + this.Level;
            }

            resources.Add(new Resource { Name = EnumResource.ENERGIE.ToString(), LastUpdate = DateTime.Now, LastQuantity = energie });

            int? oxygen = (200 * (Level / 12)) + 20;
            resources.Add(new Resource { Name = EnumResource.OXYGENE.ToString(), LastUpdate = DateTime.Now, LastQuantity = oxygen });

            int? acier =  (1000 * (Level / 8)) + 20;
            resources.Add(new Resource { Name = EnumResource.ACIER.ToString(), LastUpdate = DateTime.Now, LastQuantity = acier });

            int? uranium = (1500 * (Level / 20)) + 20;
            resources.Add(new Resource { Name = EnumResource.URANIUM.ToString(), LastUpdate = DateTime.Now, LastQuantity = uranium });

            return resources;
        }

        override public List<Resource> ResourceBySecond()
        {

            List<Resource> resources = new List<Resource>();
            resources.Add(new Resource { Name = EnumResource.OXYGENE.ToString(), LastUpdate = DateTime.Now, LastQuantity = (20 * (Level / 2)) + 5 });
            return resources;
        }

    }
}
