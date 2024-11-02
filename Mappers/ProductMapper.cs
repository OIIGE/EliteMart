using EliteMart.DTOS.Product;
using EliteMart.Model;

namespace EliteMart.Mappers
{
    public static class  ProductMapper
    {
        
            public static ProductDto ToProductDto(this Product productModel)
            {
                return new ProductDto
                {
                    Id = productModel.Id,
                    ProductName = productModel.ProductName,
                    Description = productModel.Description,
                    Price = productModel.Price,
                    Unit = productModel.Unit,
                    Category = productModel.Category,
                    IsInStock = productModel.IsInStock,
                    ImageUrl = productModel.ImageUrl,
                    CreatedAt = productModel.CreatedAt,
                    UpdatedAt = productModel.UpdatedAt
                };
            }

            public static Product ToProductFromProductDto(this CreateProductDto productDto)
            {
                return new Product
                {
                    ProductName = productDto.ProductName,
                    Description = productDto.Description,
                    Price = productDto.Price,
                    Unit = productDto.Unit,
                    Category = productDto.Category,
                    IsInStock = productDto.IsInStock,
                    ImageUrl = productDto.ImageUrl,
                    CreatedAt = productDto.CreatedAt,
                    UpdatedAt = productDto.UpdatedAt
                };

            }
        }
    }

