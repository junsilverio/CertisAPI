using Certis.Core.Entities.Model;
using Certis.Core.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Certis.Core.WebApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _service;
        public CustomerController(ICustomerService service)
        {
            _service = service;
        }
        
        [HttpGet("customers")]
        public IEnumerable<Customer> GetCustomers()
        {
            return _service.GetCustomers().AsEnumerable();
        }

        [HttpGet("customers/{id}")]
        public Customer GetCustomer(int id)
        {
            return _service.GetCustomer(id);
        }

        //[HttpGet("customers/{code}")]
        //public Customer GetCustomerByCode(string customerCode)
        //{
        //    return _service.GetCustomerByCode(customerCode);
        //}

    }
}
