using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.CustomAttribute
{
    public class CustomValidationMSG :ValidationAttribute
    {
        private string _str { get; set; }
        public CustomValidationMSG(string textstr)
        {
            _str = textstr;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == _str)
                return ValidationResult.Success;
            else
                return new ValidationResult(ErrorMessage?? "Oh Something is wrong");
        }
    }
}
