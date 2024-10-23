

using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using EliteMart.Data;
using EliteMart.DTOS.Customer;
using EliteMart.Interfaces;
using EliteMart.Model;

namespace EliteMart.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _context;
        public CustomerRepository(AppDbContext context)
        { 
            _context = context;
        }

        public async Task<Customer> CreateAsync(Customer customerModel)
        {
            await _context.Customers.AddAsync(customerModel);
            await _context.SaveChangesAsync();
            return customerModel;
        }

        public async Task<Customer?> DeleteAsync(int id)
        {
            var customerModel = await _context.Customers.FirstOrDefaultAsync(x => x.Id == id);

            if (customerModel == null) 
            {
                return null;
            }

            _context.Customers.Remove(customerModel);
            await _context.SaveChangesAsync();
            return customerModel;
        }

        public async Task<List<Customer>> GetAllAsync()
        {
         return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            return await _context.Customers.FindAsync(id);
        }

        public Task<Customer> GetByNameAsync(Customer customerModel)
        {
            throw new NotImplementedException();
        }

        public async Task<Customer?> UpdateAsync(int id, UpdateCustomerDto customerDto)
        {
            var existingCustomer =  await _context.Customers.FirstOrDefaultAsync(x => x.Id == id);
            if (existingCustomer == null)
            {
                return null;
            }

            existingCustomer.PhoneNumber = customerDto.PhoneNumber;
            existingCustomer.Address = customerDto.Address;
            existingCustomer.Password = customerDto.Password;

            await _context.SaveChangesAsync();
            return existingCustomer;

        }
    }
}
