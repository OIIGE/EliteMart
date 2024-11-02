using System;
using System.ComponentModel.DataAnnotations;

namespace EliteMart.Model
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        [Range(0.01, 1000000.00)]
        public decimal Price { get; set; }

        [Range(1, 1000)]
        public int Unit { get; set; }

        [Required]
        [StringLength(100)]
        public string Category { get; set; }

        public bool IsInStock { get; set; }

        [Url]
        public string ImageUrl { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
