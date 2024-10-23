using EliteMart.DTOS.Customer;
using EliteMart.Model;

namespace EliteMart.Interfaces
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetAllAsync();
        Task<Customer> GetByIdAsync(int id);
        Task<Customer> GetByNameAsync(Customer customerModel);

        Task<Customer?> UpdateAsync(int id, UpdateCustomerDto customerDto);
        Task<Customer?> DeleteAsync(int id);
        Task <Customer> CreateAsync(Customer customerModel);
    }
}
