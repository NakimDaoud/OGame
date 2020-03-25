using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO_O_Game
{
    public class UraniumGenerator : ResourceGenerator
    {

        override public List<Resource> TotalCost()
        {
            List<Resource> resources = new List<Resource>();
            Resource energie = new Resource { Name = EnumResource.ENERGIE.ToString(), LastUpdate = DateTime.Now, LastQuantity = 0 };
            Resource oxygene = new Resource { Name = EnumResource.OXYGENE.ToString(), LastUpdate = DateTime.Now, LastQuantity = 0 };
            Resource acier = new Resource { Name = EnumResource.ACIER.ToString(), LastUpdate = DateTime.Now, LastQuantity = 0 };

            for (int i = 1; i <= Level; i++)
            {
                energie.LastQuantity += i;
                oxygene.LastQuantity += (200 * (Level / 2)) + 20;
                acier.LastQuantity += (100 * (Level / 3)) + 20;
            }
            resources.Add(energie);
            resources.Add(oxygene);
            resources.Add(acier);

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

            int? oxygen = (200 * (Level / 2)) + 20;
            resources.Add(new Resource { Name = EnumResource.OXYGENE.ToString(), LastUpdate = DateTime.Now, LastQuantity = oxygen });

            int? acier = (100 * (Level / 3)) + 20;
            resources.Add(new Resource { Name = EnumResource.ACIER.ToString(), LastUpdate = DateTime.Now, LastQuantity = acier });

            

            return resources;
        }

        override public List<Resource> ResourceBySecond()
        {

            List<Resource> resources = new List<Resource>();
            resources.Add(new Resource { Name = EnumResource.URANIUM.ToString(), LastUpdate = DateTime.Now, LastQuantity =(int) (7 * Math.Pow((double)Level, 3)) + 2});
            return resources;
        }

    }
}
