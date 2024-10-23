using EliteMart.DTOS.Customer;
using EliteMart.DTOS.Product;
using EliteMart.Model;

namespace EliteMart.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Customer>> GetAllAsync();
        Task<Customer> GetByIdAsync(int id);
        Task<Customer> GetByNameAsync(Product productModel);

        Task<Customer?> UpdateAsync(int id, UpdateProductDto productDto);
        Task<Customer?> DeleteAsync(int id);
        Task<Customer> CreateAsync(Product productModel);
    }
}
