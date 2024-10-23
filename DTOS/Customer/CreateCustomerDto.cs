using EliteMart.Validation;
using System.ComponentModel.DataAnnotations;

namespace EliteMart.DTOS.Customer
{
    public class CreateCustomerDto
    {
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [EmailValidation]
        public string Email { get; set; }

        [Required]
        [Phone]
        [PhoneValidation]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

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
