using Amazon.DTOs.Customer;
using Amazon.Exceptions.NotFoundException;
using Amazon.Models;
using Amazon.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Services.Implements
{
    public class CustomerService : IGenericService<CustomerCreateDto>
    {
        private readonly List<Customer> _customer = new List<Customer>();
        public void Create(CustomerCreateDto dto)
        {
            var Customer = new Customer()
            {
                Id = dto.Id,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                Password = dto.Password,
                PhoneNumber = dto.PhoneNumber,

            };
            _customer.Add(Customer);

        }

        public void Delete(int id)
        {
            var customer = _customer.FirstOrDefault(c => c.Id == id);
            if (customer != null) throw new CustomerNotFoundException();
            _customer.Remove(customer);
        }

        public void GetAll()
        {
            foreach (var customer in _customer)
            {
                Console .WriteLine($"{customer.Id}-{customer.FirstName} \n {customer.PhoneNumber} \n {customer.Email}");
            }  

        }

        public void GetById(int id)
        {
            var Customer = _customer.FirstOrDefault(c => c.Id == id);
            if (Customer != null) throw new CustomerNotFoundException();
            Console.WriteLine($"{Customer.Id}-{Customer.FirstName} \n {Customer.PhoneNumber} \n {Customer.Email}");

        }
    }
}
