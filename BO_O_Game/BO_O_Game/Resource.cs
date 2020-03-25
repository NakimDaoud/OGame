using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO_O_Game
{
    public class Resource : IDbEntity
    {
        [StringLength(20, MinimumLength = 5)]
        public string Name { get; set; }

        [Range(0, Int32.MaxValue)]
        public int? LastQuantity { get; set; }

        [ValiditeDate(ErrorMessage = "La date est inférieure à la date actuelle")]
        public DateTime LastUpdate { get; set; }



    }

    class ValiditeDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime _dateJoin = Convert.ToDateTime(value);

            if (_dateJoin >= DateTime.Now)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(ErrorMessage);
            }
        }
    }
}
