using EliteMart.Validation;
using System.ComponentModel.DataAnnotations;

namespace EliteMart.DTOS.Customer
{
    public class UpdateCustomerDto
    {
        [Required]
        [EmailAddress]
        [EmailValidation]
        public string Email { get; set; }

        [Required]
        [Phone]
        [PhoneValidation]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(200)]
        public string Address { get; set; }

        [MinLength(6)]
        [MaxLength(18)]
        [DataType(DataType.Password)]
        [PasswordValidation]
        public string Password { get; set; }
    }

}


