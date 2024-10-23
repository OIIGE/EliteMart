using EliteMart.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace EliteMart.Validation
{
    public class EmailValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var _context = (AppDbContext)validationContext.GetService(typeof(AppDbContext));
            var email = (string)value;
            var user = _context.Customers.FirstOrDefault(c => c.Email == email);

            if (user != null)
            {
                return new ValidationResult("Email already exists.");
            }

            return ValidationResult.Success;
        }
    }
}



  
