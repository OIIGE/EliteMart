using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;

namespace EliteMart.Validation
{
    public class PasswordValidation : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var password = value as string;
        if (password == null || password.Length < 6 || password.Length > 18
            || !password.Any(char.IsLetter)
            || !password.Any(char.IsDigit)
            || !Regex.IsMatch(password, @"[\W_]"))
        {
            return new ValidationResult("Password must be between 6 and 18 characters long, contain letters, numbers, and at least one special character.");
        }

        return ValidationResult.Success;
    }
}
}
