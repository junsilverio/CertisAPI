using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Certis.Core.Entities.Model;
using Certis.Core.Repository;

namespace Certis.Core.Service.Interface
{
    public interface ICustomerService    
    {
        IQueryable<Customer> GetCustomers();

        Customer GetCustomer(int id);

        Customer GetCustomerByCode(string customerCode);
    }
}
