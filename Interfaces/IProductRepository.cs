using EliteMart.DTOS.Customer;
using EliteMart.DTOS.Product;
using EliteMart.Helpers;
using EliteMart.Model;

namespace EliteMart.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync(QueryObject query);
        Task<Product> GetByIdAsync(int id);
        Task<Product> GetByNameAsync(Product productModel);

        Task<Product?> UpdateAsync(int id, UpdateProductDto productDto);
        Task<Product?> DeleteAsync(int id);
        Task<Product> CreateAsync(Product productModel);
    }
}
