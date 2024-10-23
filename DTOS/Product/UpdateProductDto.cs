using System.ComponentModel.DataAnnotations;

namespace EliteMart.DTOS.Product
{
    public class UpdateProductDto
    {
        [Range(0.01, 10000.00)]
        public decimal Price { get; set; }

        [Range(1, 10000)]
        public int Unit { get; set; }
        public bool IsInStock { get; set; }

        [Url]
        public string ImageUrl { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    }
}
