using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EliteMart.DTOS.Account
{
    public class RegisterDto : Controller
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }
       
    }
}
