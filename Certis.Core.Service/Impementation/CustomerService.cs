using Certis.Core.Entities.Model;
using Certis.Core.Repository.Interface;
using Certis.Core.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Certis.Core.Service.Impementation
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;
        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public IQueryable<Customer> GetCustomers()
        {
            return _repository.GetCustomers();
        }

        public Customer GetCustomer(int id)
        {
            return _repository.GetCustomer(id);
        }

        public Customer GetCustomerByCode(string customerCode)
        {
            return _repository.GetCustomerByCode(customerCode);
        }
    }
}
