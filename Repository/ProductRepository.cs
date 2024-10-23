using EliteMart.DTOS.Product;
using EliteMart.Interfaces;
using EliteMart.Model;

namespace EliteMart.Repository
{
    public class ProductRepository : IProductRepository
    {
        public Task<Customer> CreateAsync(Product productModel)
        {
            throw new NotImplementedException();
        }

        public Task<Customer?> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Customer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetByNameAsync(Product productModel)
        {
            throw new NotImplementedException();
        }

        public Task<Customer?> UpdateAsync(int id, UpdateProductDto productDto)
        {
            throw new NotImplementedException();
        }
    }
}
