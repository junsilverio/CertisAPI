using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Certis.Core.Entities.Model;

namespace Certis.Core.Repository.Interface
{
    public interface ICustomerRepository : IDisposable
    {
        IQueryable<Customer> GetCustomers();

        Customer GetCustomer(int Id);

        Customer GetCustomerByCode(string customerCode);

        void Add(Customer customer);

        Customer Update(Customer customer);

        void Delete(Customer customer);
        
    }
}
