using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SecoundExame.Helpers
{
    public class DateValidation:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (Convert.ToDateTime(value) <= DateTime.Now)
            {
                return ValidationResult.Success;
            }
            else
                return new ValidationResult("Not Valid");
            return base.IsValid(value, validationContext);
        }
    }
}
