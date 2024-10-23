using EliteMart.DTOS.Customer;
using EliteMart.Model;
using System.Runtime.CompilerServices;

namespace EliteMart.Mappers
{
    public static class CustomerMappers
    {
        public static CustomerDto ToCustomerDto(this Customer customerModel)
        {
            return new CustomerDto
            {
                Id = customerModel.Id,
                FirstName = customerModel.FirstName,
                LastName = customerModel.LastName,
                Email =  customerModel.Email,
                PhoneNumber = customerModel.PhoneNumber,
                Address = customerModel.Address,
                DOB = customerModel.DOB,
                Password = customerModel.Password
            };
        }

        public static Customer ToCustomerFromCustomerDto(this CreateCustomerDto CustomerDto)
        {
            return new Customer
            {
                FirstName = CustomerDto.FirstName,
                LastName = CustomerDto.LastName,
                Email = CustomerDto.Email,
                PhoneNumber = CustomerDto.PhoneNumber,
                Address = CustomerDto.Address,
                DOB = CustomerDto.DOB, 
                Password = CustomerDto.Password
            };
        
        }
    }
}
