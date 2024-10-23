using EliteMart.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace EliteMart.Validation { 
public class PhoneValidation : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var _context = (AppDbContext)validationContext.GetService(typeof(AppDbContext));
        var phoneNumber = (string)value;
        var user = _context.Customers.FirstOrDefault(c => c.PhoneNumber == phoneNumber);

        if (user != null)
        {
            return new ValidationResult("Phone number already exists.");
        }

        return ValidationResult.Success;
    }
}
}



