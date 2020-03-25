using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO_O_Game
{
    public class Planet : IDbEntity
    {
        [StringLength(20, MinimumLength = 5)]
        public string Name { get; set; }

        [Range(0, Int32.MaxValue)]
        public int? CaseDB { get; set; }

        [MustHaveOneElementAttribute(ErrorMessage = "Vous avez déjà assez de ressource")]
        public virtual List<Resource> Resources { get; set; }

    }

    public class MustHaveOneElementAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var list = value as IList;
            if (list.Count <= 4)
            {
                return true;
            }
            return false;
        }
    }
}
