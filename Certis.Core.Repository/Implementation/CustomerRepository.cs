using Certis.Core.Entities.Model;
using Certis.Core.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Certis.Core.Repository.Implementation
{
    public class CustomerRepository : ICustomerRepository
    {

        private readonly PCSBNRContext _context;
        public CustomerRepository(PCSBNRContext context)
        {
            _context = context;
        }

        public void Add(Customer customer)
        {

            _context.Customers.Add(customer);
            _context.SaveChanges();
            
        }

        public void Delete(Customer customer)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public Customer GetCustomer(int Id)
        {
            return _context.Customers.FirstOrDefault(x => x.Id == Id);
        }

        public Customer GetCustomerByCode(string customerCode)
        {
            return _context.Customers.FirstOrDefault(x => x.CustomerCode == customerCode);
        }

        public IQueryable<Customer> GetCustomers()
        {
            return _context.Customers.AsQueryable();
        }

        public Customer Update(Customer customer)
        {
            var modified = _context.Customers.Attach(customer);
            modified.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return customer;
        }
    }
}
